using Microsoft.AspNetCore.Mvc.ModelBinding;
using UDash.Data;
using UDash.Interfaces;
using UDash.Models;

namespace UDash.Repositories
{
	public class UserRepositories : IUserRepository
	{
		private readonly Context _context;

		public UserRepositories(Context context)
		{
			_context = context;
		}

		public LoginModel Create(LoginModel Login)
		{
			
			Login.User.Perfil = Enums.Perfil.padrao;
			Login.User.ResgiterData = DateTime.Now;
			Login.User.LastUpdate = DateTime.Now;
			Login.UserId = Login.User.Id;

			_context.Login.Add(Login);
			_context.SaveChanges();
			return Login;
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
