using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        ICheckService _checkService;

        public GamerManager()
        {
        }

        public GamerManager(ICheckService checkService)
        {

            _checkService = checkService;
        }

        public void Add(Gamer gamer)
        {
            if (_checkService.Check(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "Kayıt Oldu!");
            }

        }

        public void Delete(Gamer gamer)
        {
            if (_checkService.Check(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "Kayıt Silindi!");
            }
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Upgrade(Gamer gamer)
        {
            if (_checkService.Check(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "Kayıt Güncellendi!");
            }
        }


        
    }
}
