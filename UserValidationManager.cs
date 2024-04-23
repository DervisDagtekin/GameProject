using System;
namespace GameProject
{
	public class UserValidationManager:IUserValidationService
	{
		public bool Validate(Gamer gamer)
		{
			if(gamer.BirthYear == 2000 && gamer.FirstName == "Derviş" && gamer.LastName== "Dağtekin" && gamer.IdentityNumber== 12345)
			{
				return true;
			}
			else
			{
				return false;
			}
		}	

	}
}

