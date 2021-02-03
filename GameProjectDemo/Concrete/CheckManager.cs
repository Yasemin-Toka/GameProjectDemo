using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class CheckManager : ICheckService
    {
        public bool Check(Gamer gamer)
        {
            bool user = true;
            if (user ==true)
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
