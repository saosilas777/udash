using Microsoft.EntityFrameworkCore;
using UDash.Data;
using UDash.Interfaces;
using UDash.Models;
using UDash.Models.ViewModels;
using UDash.Services;

namespace UDash.Repository
{
	public class CustomerRepository : ICustomerRepository
	{
		private readonly Context _context;
		private readonly ISection _section;
		public CustomerRepository(Context context,
								ISection section)
		{
			_context = context;
			_section = section;
		}


		public CustomerModel BuscarPorId(Guid id)
		{
			return _context.Customers.FirstOrDefault(x => x.Id == id);
		}

		public List<CustomerModel> BuscarTodos(Guid id)
		{
			return _context.Customers.Where(x => x.UserId == id).ToList();
		}

		public bool Create(CustomerModel customer)
		{
			string token = _section.GetUserSection();
			UserModel user = TokenService.GetDataInToken(token);

			customer.UserId = user.Id;
			_context.Add(customer);
			_context.SaveChanges();
			return true;
		}
		public bool CreateAll(List<CustomerModel> customers)
		{
			
			_context.AddRange(customers);
			_context.SaveChanges();
			return true;
		}

		public bool Deletar(CustomerModel customer)
		{
			_context.Remove(customer);
			_context.SaveChanges();
			return true;
		}

		public bool Editar(CustomerViewModel customer)
		{
			CustomerModel customerDb = BuscarPorId(customer.Id);

			customerDb.Status = customer.Status;
			customerDb.RazaoSocial = customer.RazaoSocial;
			customerDb.Loja = customer.Loja;
			customerDb.Cliente = customer.Cliente;
			customerDb.ProdutoFiscal = customer.ProdutoFiscal;
			customerDb.Fr = customer.Fr;
			customerDb.ValorMensal = customer.ValorMensal;

			_context.Update(customerDb);
			_context.SaveChanges();
			return true;

		}
		public List<CustomerModel> CreateAt()
		{
			List<CustomerModel> _customers = new List<CustomerModel>();

			for(int i = 0;i< 20; i++)
			{
				CustomerModel customer = new CustomerModel
				{
					IdSense = new Guid().ToString().Substring(0, 6),
					IdStarford = new Guid().ToString().Substring(0, 6),
					Cnpj = "01.001.000/0001-01",
					RazaoSocial = $"Mercado do seu zé {i}",
					Status = true,
					Loja = $"Mercado do seu zé {i}",
					Cliente = $"Mercado do seu zé {i}",
					ProdutoFiscal = "MRR de E-Commerce",
					Fr = "MRR",
					ValorMensal = 599.99


				};
				string token = _section.GetUserSection();
				UserModel user = TokenService.GetDataInToken(token);

				customer.UserId = user.Id;
				_customers.Add(customer);
			}



			CreateAll(_customers);
			return _customers;
		}
	}
}
