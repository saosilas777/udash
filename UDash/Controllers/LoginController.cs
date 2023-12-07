using Microsoft.AspNetCore.Mvc;
using UDash.Data;
using UDash.Interfaces;
using UDash.Models;
using UDash.Models.ViewModels;
using UDash.Repository;
using UDash.Services;

namespace UDash.Controllers
{
	public class LoginController : Controller
	{
		private readonly ILoginRepository _loginRepository;
		private readonly IUserRepository _userRepository;
		private readonly SectionService _sectionService;

		private readonly ISendEmail _sendEmail;
		
		public LoginController(ILoginRepository loginRepository,
							  IUserRepository userRepository,
							  SectionService sectionService,
							  ISendEmail sendEmail)
		{
			_loginRepository = loginRepository;
			_userRepository = userRepository;
			_sectionService = sectionService;
			_sendEmail = sendEmail;
			
		}

		public IActionResult Login()
		{
			var user = _sectionService.Section();
			
			if (user != null)
			{
			  return RedirectToAction("Index", "Home");
			};
			return View();
		}

		public IActionResult Logout()
		{
			_sectionService.RemoveSection();
			return RedirectToAction("Login");
		}
		public IActionResult SignUp()
		{
			return View();

		}

		[HttpPost]
		public IActionResult Create(LoginModel loginModel)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					TempData["ErrorMessage"] = "Não foi possível criar sua conta, verifique os dados informados.";
					return View("SignUp");

				}
				var register = _loginRepository.Create(loginModel);
				if (register == false)
				{
					TempData["ErrorMessage"] = "Login informado já existente, por favor tente novamente!";
					return View("SignUp");
				};
				TempData["SuccessMessage"] = "Cadastro realizado com sucesso, faça seu login!";
				return RedirectToAction("Login", "Login");


			}
			catch (Exception e)
			{

				TempData["ErrorMessage"] = $"Não foi possível criar sua conta, verifique os dados informados. {e.Message}";
				return View("SignUp");
			}

		}

		[HttpPost]
		public IActionResult Entrar(LoginViewModel loginViewModel)
		{

			try
			{
				if (ModelState.IsValid)
				{
					var loginDb = _loginRepository.BuscarPorLogin(loginViewModel.Login);
					if (loginDb != null && loginDb.Password == LoginServices.HashGeneration(loginViewModel.Password))
					{
						var authenticated = TokenService.Authenticate(loginDb.User);
						_sectionService.CreateSection(authenticated);
						UserModel user = TokenService.GetDataInToken(authenticated);
						if(authenticated != null)
						{
							return RedirectToAction("Index", "Home");

						}
						
					}
					TempData["ErrorMessage"] = $"Usuário ou senha inválidos, tente novamente!.";
					return View("Login", loginViewModel);
					
				}

				TempData["ErrorMessage"] = $"Para acessar é necessario informar seu login e senha!";
				return View("Login", loginViewModel);

			}
			catch (Exception e)
			{

				throw new Exception(e.Message);
			}

		}

		public IActionResult ForgotPassword()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SendMail(string email)
		{

			if(email == null)
			{
				TempData["ErrorMessage"] = $"Informe um email válido para recuperar sua senha";
				return View("ForgotPassword", email);
			}
			string senhaProvisoria = "senhaProvisoria: Udash102030";
			if (_loginRepository.BuscarPorEmail(email))
			{
				_sendEmail.SendEmail(email,"Recuperação de senha",senhaProvisoria);
			}
			return RedirectToAction("ForgotPassword","Login", email);

		}
	}
}
