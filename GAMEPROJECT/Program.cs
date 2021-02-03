using System;

namespace GAMEPROJECT
{
    class Program
    {
        static void Main(string[] args)

            //Oyuncu Ekleme işlemi
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());

            Gamer gamer1 = new Gamer
            { Id = 1, 
              BirthYear = 1994,
              FirstName = "HATİCE",
              LastName = "İNAL", 
              IdentityNumber = 123 
            
            };

            gamerManager.Add(gamer1);

            //Oyun ekleme işlemi
            

            GameManager gameManager = new GameManager();
            Games game1 = new Games
            {
                Id = 2,
                GameName = "PBG",
                GamePrice = 100
            };

            gameManager.Add(game1);


            //Kampanya Ekledik.
            
            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign 
            { 

             Id = 3,
             CampaignName = "Sepette 30 TL İskonto ",
             CampaignAmount = 30 
            
            };

            campaignManager.Add(campaign1);

            //Satış manager classına eklediğimiz oyun,oyuncu ve kampanyayı parametre ile gönderdik.
            //SalesManager classına gidip bakabilirsin.satış işlemi orda gerçekleşti.

            SalesManager salesManager=new SalesManager();

            salesManager.Sales(game1,gamer1,campaign1);
            
        }
    }
}
