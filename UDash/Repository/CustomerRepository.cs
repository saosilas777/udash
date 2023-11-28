using Microsoft.EntityFrameworkCore;
using UDash.Data;
using UDash.Interfaces;
using UDash.Models;
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


		public Customer BuscarPorId(Guid id)
		{
			return _context.Customers.FirstOrDefault(x => x.Id == id);
		}

		public List<Customer> BuscarTodos(Guid id)
		{
			return _context.Customers.Where(x => x.UserId == id).ToList();
		}

		public bool Create(Customer customer)
		{
			string token = _section.GetUserSection();
			UserModel user = TokenService.GetDataInToken(token);

			customer.UserId = user.Id;
			_context.Add(customer);
			_context.SaveChanges();
			return true;
		}
		public bool CreateAll(List<Customer> customers)
		{
			
			_context.AddRange(customers);
			_context.SaveChanges();
			return true;
		}

		public bool Deletar(Guid id)
		{
			throw new NotImplementedException();
		}

		public Customer Editar(Customer customer)
		{
			throw new NotImplementedException();
		}
		public List<Customer> CreateAt()
		{
			List<Customer> _customers = new List<Customer>();

			for(int i = 0;i< 20; i++)
			{
				Customer customer = new Customer
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
