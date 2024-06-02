using Heroes_VS_Monsters_du_Turfu.Classs.Actions;
using Heroes_VS_Monsters_du_Turfu.Classs.PicturesAndSounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters_du_Turfu.Classs.Personnages
{
    public class Coffre : Personnage
    {
        public string Skin = "↨";
        public bool Gros = false;
        public bool LuckCoffre(Coffre c)
        {
            int test = Radomizer.DeTrois();
            if (test == 3) 
            {
                c.Gros = true;
            }
            else c.Gros = false;
            return c.Gros;
        }
        public static void Loot(Hero h, Coffre c)
        {
            Pictures p = new Pictures();
            Thread.Sleep(2000);
            SoundManager.Instance.Play("Coffre.wav");
            p.RenderboardCoffre();
            Thread.Sleep(2500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"                                                                                                                     Vous tombez sur un coffre au trésor !");
            c.LuckCoffre(c);
            if (c.Gros is true) 
            {
                c.Gold = 2 * Radomizer.DeQuatre();
                c.Plastic = 2 * Radomizer.DeQuatre();
                c.Cuir = 2 * Radomizer.DeQuatre();
                Console.WriteLine($"                                                                                                        Vous recevez: {c.Gold} pièces d'Or, {c.Plastic} plastiques et {c.Cuir} cuirs !");
            }
            else
            {
                c.Gold = Radomizer.DeQuatre();
                c.Plastic = Radomizer.DeQuatre();
                c.Cuir = Radomizer.DeQuatre();
                Console.WriteLine($"                                                                                                       Vous recevez: {c.Gold} pièces d'Or, {c.Plastic} plastiques et {c.Cuir} cuirs !");
            }
            h.Gold += c.Gold;
            h.Plastic += c.Plastic;
            h.Cuir += c.Cuir;
            Console.WriteLine($"                                                                                                     Vous avez désormais {h.Gold} pièces d'Or, {h.Plastic} plastiques et {h.Cuir} cuirs au total !");
            Thread.Sleep(4000);
            Console.ResetColor();
            Console.Clear();
        }
        public List<Coffre> InitCoffre()
        {
            List<Coffre> coffres = new List<Coffre>();
            for (int i = 0; i < 10; i++)
            {
                coffres.Add(new Coffre() { Id = i + 1 });
            }
            foreach (Coffre c in coffres)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                c.Skin = "↨";
                Console.ResetColor();
            }
            return coffres;
        }
    }
}
