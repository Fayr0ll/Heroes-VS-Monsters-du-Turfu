using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters_du_Turfu.Classs.Personnages
{
    public class Pnj : Personnage
    {
        public bool Complete = false;
        public List<Pnj> InitPnj()
        {
            List<Pnj> pnjs = new List<Pnj>();
            for (int i = 0; i < 3; i++)
            {
                pnjs.Add(new Pnj() { Id = i + 1 });
            }
            foreach (Pnj p in pnjs)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                p.Skin = "Q";
                Console.ResetColor();
            }
            return pnjs;
        }
    }
}
