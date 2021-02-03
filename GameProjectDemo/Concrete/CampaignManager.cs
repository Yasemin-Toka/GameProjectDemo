using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class CampaignManager:IBaseCampaignService 
{
        Game _game;
        

        public CampaignManager(Game game)
        {
            _game = game;
           
        }

        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "Eklendi");
            Console.WriteLine(" ");
            Console.WriteLine("Kampanyanın geçerli olduğu oyun/oyunlar:");
            Console.WriteLine(_game.GameName);
            Console.WriteLine(" ");
            Console.WriteLine("Kampanyanın geçerli olduğu oyunların yeni fiyatları:");
            Console.WriteLine(_game.GameName + " " + "Kampanya öncesi fiyatı :" + " " + _game.GamePrice);
            Console.WriteLine(_game.GameName + " " + "Kampanya sonrası fiyatı :" + " " + "18.75");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "Silindi");
        }

        public void Sale(Entity.Game game)
        {
            throw new NotImplementedException();
        }

        public void UpgradeCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "Güncellendi");
            Console.WriteLine(" ");
            Console.WriteLine("Güncel kampanyanın dahil olduğu oyun/oyunlar:");
            Console.WriteLine(_game.GameName);
        }

        
    }

       
}
