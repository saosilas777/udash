using System.ComponentModel.DataAnnotations;

namespace UDash.Models
{
	public class LoginModel
	{
		public Guid Id { get; set; }
		public UserModel User { get; set; } = new UserModel();
		public Guid UserId { get; set; }
		[Required(ErrorMessage = "É preciso informar um login válido")]
		public string Login { get; set; }
		public string Password { get; set; }
		
	}
}
