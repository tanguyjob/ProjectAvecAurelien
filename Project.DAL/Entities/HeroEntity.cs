using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class HeroEntity
    {
        public int IdHero { get; set; }
        public string Name { get; set; }
        public int Endurance { get; set; }
        public int Strength { get; set; }
        public int IdRace { get; set; }


    }
}
