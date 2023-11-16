using UDash.Interfaces;
using UDash.Models;

namespace UDash.Repositories
{
	public class UserRepositories : IUserRepository
	{

		public UserModel Create(UserModel user)
		{
			throw new NotImplementedException();
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
			throw new NotImplementedException();
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
