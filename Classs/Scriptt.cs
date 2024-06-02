using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Heroes_VS_Monsters_du_Turfu.Classs
{
    public static class Scriptt
    {
        public static void Histoire()
        {
            Console.WriteLine();
        }
        public static void Règles()
        {                                  
            Console.WriteLine("                                                                                                      Sélectionnez votre Héro.");
            Thread.Sleep(1000);          
            Console.WriteLine("                                                                  Défiez les petits monstres pour évoluer votre Héro (Statistiques, amélioration item, boost, ...).");
            Thread.Sleep(1000);          
            Console.WriteLine("                                                                                                Combattez leur chef l'Elfe de Sang !");
            Thread.Sleep(1000);          
            Console.WriteLine("                                                                                                Attention qu'il y a plusieurs étage !");
            Thread.Sleep(1000);          
            Console.WriteLine("                                                             Ressortez Victorieux et la gloire vous sera assurée ! Ou mourrez et finissez dans l'oublis intergalactique !");
            Thread.Sleep(1000);          
        }
    }
}
