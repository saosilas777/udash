using UDash.Models;
using UDash.Models.ViewModels;

namespace UDash.Interfaces
{
	public interface IUserRepository
	{
		bool Create(LoginModel login);

		UserModel BuscarPorLogin(LoginViewModel login);
		UserModel BuscarPorEmaileLogin(string login, string email);
		List<UserModel> BuscarTodos();
		UserModel BuscarPorId(Guid id);
		UserModel Editar(UserModel contato);
		bool Deletar(Guid id);



	}
}
