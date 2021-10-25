using System;

namespace OdevHaftaBesCozum
{
    class Program
    {
        static void Main(string[] args)
        {
          GamerManager gamerManager = new GamerManager(new UserValidationManager());
          gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1984,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 12345
            });
           
        }
    }
}
