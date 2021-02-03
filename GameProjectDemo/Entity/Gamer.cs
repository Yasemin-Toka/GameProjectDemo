using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entity
{
    public class Gamer : IBaseGamerService

    {
       

        public int Id { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public string DateOfBirth { get; set; }


        public void Add(IBaseGamerService gamer)
        {
            throw new NotImplementedException();
        }

        public void Delete(IBaseGamerService gamer)
        {
            throw new NotImplementedException();
        }

        public void Upgrade(IBaseGamerService gamer)
        {
            throw new NotImplementedException();
        }
    }
}
