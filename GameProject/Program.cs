using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            { 
                Id = 1, 
                BirthDay = 1995, 
                FirstName = "MEHMET MESUT", 
                LastName = "ATO", 
                IndentityNumber = 12345678910 
            });
        }
    }
}
