using GameProjectDemo.Concrete;
using GameProjectDemo.Entity;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Gamer gamer = new Gamer { Id = 1, FirstName = "Alaaddin", LastName = "Keykubat", DateOfBirth = "01.01.1205", NationalityId = "12345678901" };
                GamerManager gamerManager = new GamerManager(new CheckManager());
                gamerManager.Add(gamer);
                gamerManager.Upgrade(gamer);
                gamerManager.Delete(gamer);

                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Game game = new Game { GameId = 10, GameName = "The Assassins Creed İnfinity", GamePrice = "25 TL" };
                GameSaleManager gameSaleManager = new GameSaleManager(gamer);
                gameSaleManager.Sale(game);

                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Campaign campaign = new Campaign { CampaignId = 1, CampaignName = "%25 indirim kampanyası", CampaignDiscount = "%25" };
                CampaignManager campaignManager = new CampaignManager(game);
                campaignManager.AddCampaign(campaign);
                Console.WriteLine(" ");
                campaignManager.DeleteCampaign(campaign);
                Console.WriteLine(" ");
                campaignManager.UpgradeCampaign(campaign);


            }
                       
        }
    }
}
