using UDash.Models.ViewModels;
using UDash.Models;

namespace UDash.Interfaces
{
	public interface ICustomerRepository
	{
		bool Create(CustomerModel customer);
		CustomerModel BuscarPorId(Guid id);
		List<CustomerModel> BuscarTodos(Guid id);
		bool Editar(CustomerViewModel customer);
		bool Deletar(CustomerModel customer);
		List<CustomerModel> AdicionarTodos(List<CustomerModel> customers);

	}
}
