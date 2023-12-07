﻿using Microsoft.AspNetCore.Mvc;
using UDash.Interfaces;
using UDash.Models;
using UDash.Models.ViewModels;
using UDash.Services;

namespace UDash.Controllers
{
	public class UserController : Controller
	{
		private readonly ILoginRepository _loginRepository;
		private readonly ISection _section;

		public UserController(ILoginRepository loginRepository, ISection section)
		{
			_loginRepository = loginRepository;
			_section = section;
		}
	
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult ChangePassword()
		{
			var user = TokenService.GetDataInToken(_section.GetUserSection());
			ChangePasswordViewModel viewModel = new();
			viewModel.UserId = user.Id;
			return View(viewModel);
		}

		[HttpPost]
		public IActionResult ChangePassword(ChangePasswordViewModel viewModel)
		{
			try
			{
				if (viewModel.NewPassword != viewModel.ConfirmPassword)
				{
					TempData["ErrorMessage"] = "As novas senhas digitadas não conferem";
					return View("ChangePassword", viewModel);
				}
				if (!ModelState.IsValid)
				{
					TempData["ErrorMessage"] = "Os dados não conferem";
					return View("ChangePassword", viewModel);
				}
				LoginModel login = _loginRepository.BuscarPorId(viewModel.UserId);
				viewModel.NewPassword = LoginServices.HashGeneration(viewModel.NewPassword);
				viewModel.OldPassword = LoginServices.HashGeneration(viewModel.OldPassword);
				if (viewModel.OldPassword != login.Password)
				{
					TempData["ErrorMessage"] = "A senha atual não confere";
					return View("ChangePassword", viewModel);
				}
				if (viewModel.NewPassword == login.Password)
				{
					TempData["ErrorMessage"] = "A nova senha não pode ser igual a senha atual";
					return View("ChangePassword", viewModel);
				}
				/*if(viewModel.NewPassword != viewModel.ConfirmPassword)
				{
					TempData["ErrorMessage"] = "As senhas atuais não conferem";
					return RedirectToAction("ChangePassword", viewModel);
				}*/
				login.Password = viewModel.NewPassword;
				_loginRepository.ChangePassword(login);
				TempData["SuccessMessage"] = "Senha Atualizada com sucesso!";
				return View();
				


			}
			catch (Exception)
			{

				throw;
			}
		}


	}
}
