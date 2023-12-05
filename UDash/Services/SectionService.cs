using UDash.Interfaces;
using UDash.Models;

namespace UDash.Services
{
	
	public class SectionService
	{
		private readonly ISection _section;
		private readonly IUserRepository _userRepository;

		public SectionService(ISection section, IUserRepository userRepository)
		{
			_section = section;
			_userRepository = userRepository;
		}
		public UserModel Section()
		{
			try
			{
				var token = _section.GetUserSection();
				if (token == null) return null;
				UserModel user = TokenService.GetDataInToken(token);
				UserModel userDB = _userRepository.BuscarPorId(user.Id);
				if (userDB == null)
				{
					return new UserModel();
				}
				return userDB;
			}
			catch (Exception)
			{

				throw;
			}

		}
		public void RemoveSection()
		{
			_section.UserSectionRemove();
		}
		public void CreateSection(string token)
		{
			_section.UserSectionCreate(token);
		}

	}
}
