using Microsoft.AspNetCore.Mvc;
using UDash.Models;
using UDash.Services;

namespace UDash.ViewComponents
{
	public class Header : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			try
			{
				string? UserSection = HttpContext.Session.GetString("Token");

				if (string.IsNullOrEmpty(UserSection))
				{
					return null;
				}
				UserModel? user = TokenService.GetDataInToken(UserSection);
				return View(user);
			}
			catch (Exception e)
			{

				throw new Exception(e.Message);
			}
			
		}

	}
}
