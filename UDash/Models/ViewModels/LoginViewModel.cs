using System.ComponentModel.DataAnnotations;

namespace UDash.Models.ViewModels
{
	public class LoginViewModel
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		[Required(ErrorMessage = "É preciso informar um login válido")]
		public string Login { get; set; }
		public string Password { get; set; }
	}
}
