using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using UDash.Data;
using UDash.Interfaces;
using UDash.Models;
using UDash.Models.ViewModels;
using UDash.Services;

namespace UDash.Repository
{
	public class LoginRepository : ILoginRepository
	{
		private readonly Context _context;

		public LoginRepository(Context context)
		{
			_context = context;
		}



		public bool Create(LoginModel login)
		{

			LoginModel? LoginsDB = _context.Login.FirstOrDefault(x => x.Login == login.Login);
			if (LoginsDB == null)
			{
				login.User.Perfil = Enums.Perfil.padrao;
				login.User.ResgiterData = DateTime.Now;
				login.User.LastUpdate = DateTime.Now;
				login.Password = LoginServices.HashGeneration(login.Password);

				_context.Login.Add(login);
				_context.SaveChanges();
				return true;
			}
			return false;

		}
		public LoginModel BuscarPorLogin(string login)
		{
			LoginModel? loginModelDb = _context.Login.Include(x => x.User).FirstOrDefault(x => x.Login == login);

			return loginModelDb;
		}
		public bool BuscarPorEmail(string email)
		{

			UserModel? userModelDb = _context.Users.FirstOrDefault(x => x.Email == email);
			if (userModelDb == null) return false;
			return true;
		}


	}
}
