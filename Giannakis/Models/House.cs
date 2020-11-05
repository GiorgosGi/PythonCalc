using Giannakis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giannakis.Models
{
    class House : Interface1
    {
        public void houseTokTok()
        {
            Console.WriteLine("Giannakis hearing someone knocking the door: tok tok ...");
        }

        public void GiannisClosesDoor()
        {
            Console.WriteLine("Giannis closes door");
        }

        public void GiannisOpensDoor()
        {
            Console.WriteLine("Giannis says: Hi Annoula!, and he opens the door");
        }

        public void GiannisAndAnnoula()
        {
            Console.WriteLine("Giannis and Annoula go for a walk!");
        }
    }
}
