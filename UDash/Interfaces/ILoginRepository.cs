using UDash.Models;
using UDash.Models.ViewModels;

namespace UDash.Interfaces
{
	public interface ILoginRepository
	{
		bool Create(LoginModel login);

		LoginModel BuscarPorLogin(string login);
		bool BuscarPorEmail(string email);
		LoginModel BuscarPorId(Guid id);
		void ChangePassword(LoginModel login);

	}
}
