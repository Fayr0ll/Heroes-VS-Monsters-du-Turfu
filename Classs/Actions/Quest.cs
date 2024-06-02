using Heroes_VS_Monsters_du_Turfu.Classs.Personnages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters_du_Turfu.Classs.Actions
{
    public static class Quest
    {
        public static bool DQuest(Hero h, Pnj pj)
        {
            switch (pj.Id) 
            { 
                case 1 :
                    if (h.VicLoup > 5) 
                    {
                        pj.Complete = true;
                        Console.WriteLine($"{h.Pseudo} voici le surplus de mes cuirs comme promis !");
                        h.Cuir += 5;
                        Console.WriteLine($"{h.Pseudo} reçois 5 cuirs pour avoir accomplis la quête du tueur de Loups !");
                        h.QuestComplete += 1;
                        break;
                    }
                    else Console.WriteLine($"Bonjour {h.Pseudo}, j'ai une quête à te proposer étranger... Tues plus que 5 Loups et tu recevras mon surplus de cuirs !");
                    break;
                case 2 :
                    if (h.VicOrc > 5)
                    {
                        pj.Complete = true;
                        Console.WriteLine($"{h.Pseudo} voici le surplus de mes cuirs comme promis !");
                        h.Cuir += 5;
                        Console.WriteLine($"{h.Pseudo} reçois 5 plastiques pour avoir accomplis la quête du tueur d'Orcs !");
                        h.QuestComplete += 1;
                        break;
                    }
                    else Console.WriteLine($"Bonjour {h.Pseudo}, j'ai une quête à te proposer étranger... Tues plus que 5 Orcs et tu recevras mon plastique personnel !");
                    break; 
                case 3 :
                    if (h.VicCyc > 5)
                    {
                        pj.Complete = true;
                        Console.WriteLine($"{h.Pseudo} voici le sac d' Or comme promis !");
                        h.Cuir += 5;
                        Console.WriteLine($"{h.Pseudo} reçois 20 pièces d'Or pour avoir accomplis la quête du tueur d'Orcs !");
                        h.QuestComplete += 1;
                        break;
                    }
                    else Console.WriteLine($"Bonjour {h.Pseudo}, j'ai une quête à te proposer étranger... Tues plus que 5 Cyclopes et tu recevras mon plastique personnel !");
                    break;
            }
            return pj.Complete;
        }
    }
}
