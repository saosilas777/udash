using Microsoft.AspNetCore.Mvc.ModelBinding;
using UDash.Data;
using UDash.Interfaces;
using UDash.Models;
using UDash.Models.ViewModels;

namespace UDash.Repositories
{
	public class UserRepositories : IUserRepository
	{
		private readonly Context _context;

		public UserRepositories(Context context)
		{
			_context = context;
		}

		public LoginModel Create(LoginModel login)
		{
			login.User.Perfil = Enums.Perfil.padrao;
			login.User.ResgiterData = DateTime.Now;
			login.User.LastUpdate = DateTime.Now;
						
			_context.Login.Add(login);
			_context.SaveChanges();
			return login;
		}


		public UserModel BuscarPorEmaileLogin(string login, string email)
		{
			throw new NotImplementedException();
		}

		public UserModel BuscarPorId(Guid id)
		{
			throw new NotImplementedException();
		}

		public UserModel BuscarPorLogin(LoginModel login)
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
