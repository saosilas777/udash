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

		public UserModel Create(UserModel user)
		{
			user.ResgiterData = DateTime.Now;
			user.LastUpdate = DateTime.Now;
			user.Perfil = Enums.Perfil.padrao;
			user.Login.Id = user.Id;
			_context.Add(user);
			_context.SaveChanges();
			return user;
		}


		public UserModel BuscarPorEmaileLogin(string login, string email)
		{
			throw new NotImplementedException();
		}

		public UserModel BuscarPorId(Guid id)
		{
			throw new NotImplementedException();
		}

		public UserModel BuscarPorLogin(string login)
		{
			UserModel user = _context.Users.FirstOrDefault(x => x.Login.Login == login);

			if (user != null)
				return user;

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
