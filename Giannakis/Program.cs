using Giannakis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giannakis
{
    class Program
    {
        static void Main(string[] args)
        {
            House house         = new House();
            Annoula annoula     = new Annoula();
            Giannis giannis     = new Giannis();

            annoula.annoulaToksDoor();
            house.houseTokTok();
            annoula.annoulaSaysHi();
            house.GiannisOpensDoor();
            giannis.closeDoorGiannakis();
            house.GiannisAndAnnoula();
        }
    }
}
