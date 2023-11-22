namespace UDash.Interfaces
{
	public interface ISection
	{
		void UserSectionCreate(string token);
		void UserSectionRemove();
		string GetUserSection();
	}
}
