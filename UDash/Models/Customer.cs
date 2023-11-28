using System.ComponentModel.DataAnnotations;

namespace UDash.Models
{
	public class Customer
	{
		[Key]
		public Guid Id { get; set; }
		public string IdSense { get; set; } = string.Empty;
		public string IdStarford { get; set; } = string.Empty;
		public string Cnpj { get; set; } = string.Empty;
		public bool Status { get; set; } = true;
		public string RazaoSocial { get; set; } = string.Empty;
		public string Loja { get; set; } = string.Empty;
		public string Cliente { get; set; } = string.Empty;
		public string ProdutoFiscal { get; set; } = string.Empty;
		public string Fr { get; set; } = string.Empty;
		public double ValorMensal { get; set; }
		public Guid UserId { get; set; }

	}
}
