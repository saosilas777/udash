using UDash.Models.ViewModels;
using UDash.Models;

namespace UDash.Interfaces
{
	public interface ICustomerRepository
	{
		bool Create(Customer customer);
		Customer BuscarPorId(Guid id);
		List<Customer> BuscarTodos(Guid id);
		Customer Editar(Customer customer);
		bool Deletar(Guid id);

	}
}
