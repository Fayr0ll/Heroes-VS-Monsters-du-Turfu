using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters_du_Turfu.Classs.Personnages
{
    public class Mur : Personnage
    {
        public List<Mur> InitMur()
        {
            List<Mur> murs = new List<Mur>();
            for (int i = 0; i < 5; i++)
            {
                murs.Add(new Mur() { Id = i + 1 });
            }
            foreach (Mur m in murs)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                m.Skin = "|";
                Console.ResetColor();
            }
            return murs;
        }
        public List<Mur> InitMur2()
        {
            List<Mur> murs = new List<Mur>();
            for (int i = 0; i < 5; i++)
            {
                murs.Add(new Mur() { Id = i + 1 });
            }
            foreach (Mur m in murs)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                m.Skin = "_";
                Console.ResetColor();
            }
            return murs;
        }
    }
}
