using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using UDash.Data;
using UDash.Interfaces;
using UDash.Models;
using UDash.Models.ViewModels;

namespace UDash.Repository
{
	public class UserRepository : IUserRepository
	{
		private readonly Context _context;

		public UserRepository(Context context)
		{
			_context = context;
		}

		public bool Create(LoginModel login)
		{
			
				LoginModel LoginsDB = _context.Login.FirstOrDefault(x => x.Login == login.Login);
				if(LoginsDB == null)
				{
					login.User.Perfil = Enums.Perfil.padrao;
					login.User.ResgiterData = DateTime.Now;
					login.User.LastUpdate = DateTime.Now;

					_context.Login.Add(login);
					_context.SaveChanges();
					return true;
				}
			return false;
			
		}

		public bool SaveToken(UserModel user, string token)
		{
			user.Token = token;
			_context.Update(user);
			_context.SaveChanges();

			return true;

		}


		public UserModel BuscarPorEmaileLogin(string login, string email)
		{
			throw new NotImplementedException();
		}

		public UserModel BuscarPorId(Guid id)
		{
			throw new NotImplementedException();
		}

		public UserModel BuscarPorLogin(LoginViewModel login)
		{
			LoginModel loginDB = _context.Login.FirstOrDefault(x => x.Login == login.Login);
			if(loginDB != null)
			{
				UserModel user = _context.Users.FirstOrDefault(x => x.Id == loginDB.UserId);
				return user;
			}

			return null;


		}

		public List<UserModel> BuscarTodos()
		{
			throw new NotImplementedException();
		}

		

		public bool Deletar(Guid id)
		{
			throw new NotImplementedException();
		}

		public UserModel Editar(UserModel contato)
		{
			throw new NotImplementedException();
		}

		
	}
}
