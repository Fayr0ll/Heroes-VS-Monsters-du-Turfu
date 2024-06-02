using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Heroes_VS_Monsters_du_Turfu.Classs.Personnages
{
    public class Buisson : Personnage
    {
        public string Skin;
        public List<Buisson> InitBuisson()
        {
            List<Buisson> buissons = new List<Buisson>();
            for (int i = 0; i < 10; i++)
            {
                buissons.Add(new Buisson() { Id = i + 1 });
            }
            foreach (Buisson b in buissons)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                b.Skin = "#";
                Console.ResetColor();
            }
            return buissons;
        }
        public List<Buisson> InitBuisson2()
        {
            List<Buisson> buissons = new List<Buisson>();
            for (int i = 0; i < 50; i++)
            {
                buissons.Add(new Buisson() { Id = i + 1 });
            }
            foreach (Buisson b in buissons)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                b.Skin = "#";
                Console.ResetColor();
            }
            return buissons;
        }
    }
}
