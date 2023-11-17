using UDash.Models;

namespace UDash.Interfaces
{
	public interface IUserRepository
	{
			UserModel Create(UserModel user);

		
			UserModel BuscarPorLogin(string login);
			UserModel BuscarPorEmaileLogin(string login, string email);
			List<UserModel> BuscarTodos();
			UserModel BuscarPorId(Guid id);
			UserModel Editar(UserModel contato);
			bool Deletar(Guid id);


		
	}
}
