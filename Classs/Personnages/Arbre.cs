using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters_du_Turfu.Classs.Personnages
{
    public class Arbre : Personnage
    {
        public string Skin;
        
        public List<Arbre> InitArbre()
        {
            List<Arbre> arbres = new List<Arbre>();
            for (int i = 0; i < 10; i++)
            {
                arbres.Add(new Arbre() { Id = i + 1 });
            }
            foreach (Arbre a in arbres)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                a.Skin = "@";
                Console.ResetColor();
            }
            return arbres;
        }
        public List<Arbre> InitArbre2()
        {
            List<Arbre> arbres = new List<Arbre>();
            for (int i = 0; i < 200; i++)
            {
                arbres.Add(new Arbre() { Id = i + 1 });
            }
            foreach (Arbre a in arbres)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                a.Skin = "@";
                Console.ResetColor();
            }
            return arbres;
        }
    }
}
