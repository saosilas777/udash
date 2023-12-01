namespace UDash.Models.ViewModels
{
    public class CustomerViewModel
    {
		public Guid Id { get; set; }		
		public bool Status { get; set; }
		public string RazaoSocial { get; set; } = string.Empty;
		public string Loja { get; set; } = string.Empty;
		public string Cliente { get; set; } = string.Empty;
		public string ProdutoFiscal { get; set; } = string.Empty;
		public string Fr { get; set; } = string.Empty;
		public double ValorMensal { get; set; }
	}
}
