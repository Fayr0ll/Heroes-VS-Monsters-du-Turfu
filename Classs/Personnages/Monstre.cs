using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Heroes_VS_Monsters_du_Turfu.Classs.Personnages
{
    public class Monstre : Personnage
    {
        public List<Monstre> InitMonstre()
        {
            List<Monstre> monstres = new List<Monstre>();
            for (int i = 0; i < 29; i++)
            {
                monstres.Add(new Monstre() { Id = i + 1 });
            }
            foreach (Monstre mon in monstres)
            {
                if (mon.Id < 11)
                {
                    mon.Race = "Loup";
                    mon.Description = "Le loup féroce est un monstre intelligent mais faible. Son arme principale est sa machoire et possède peu de vie, mais a une bonne esquive.";
                    mon.Weapon = "Crocs";
                    mon.Endu = 1;
                    mon.Force = 5;
                    mon.Def = 2 + (mon.Endu * 2);
                    mon.Hp = 14 + (mon.Endu * 3);
                    mon.Spec = 0;
                    mon.Agi = 5;
                    mon.Chance = 0;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    mon.Skin = "L";
                    Console.ResetColor();
                    mon.Boss = false;
                }
                if (mon.Id > 10 && mon.Id < 21)
                {
                    mon.Race = "Orc";
                    mon.Description = "L'orc est un monstre dénué d'intelligence, il aime se nourir des diverses héros plus faibles que lui. Son arme principale est sa Lame Diforme et possède une bonne attaque.";
                    mon.Weapon = "Lame Diforme";
                    mon.Endu = 2;
                    mon.Force = 9;
                    mon.Def = 3 + (mon.Endu * 2);
                    mon.Hp = 25 + (mon.Endu * 3);
                    mon.Spec = 0;
                    mon.Agi = 3;
                    mon.Chance = 0;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    mon.Skin = "O";
                    Console.ResetColor();
                    mon.Boss = false;
                }
                if (mon.Id > 20 && mon.Id < 31)
                {
                    mon.Race = "Cyclope";
                    mon.Description = "Malfré qu'il n'a qu'un oeuil il arrivera toujours à vous suivre du regard, plutôt résistant et complet. Ne rate jamais sa cible !";
                    mon.Weapon = "Tronc d'arbre";
                    mon.Endu = 6;
                    mon.Force = 11;
                    mon.Def = 5 + (mon.Endu * 2);
                    mon.Hp = 40 + (mon.Endu * 3);
                    mon.Spec = 10;
                    mon.Agi = 4;
                    mon.Chance = 0;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    mon.Skin = "C";
                    Console.ResetColor();
                    mon.Boss = false;
                }
                /*if (mon.Id == 10)
                {
                    mon.Race = "Elfe de Sang";
                    mon.Description = "L'Elfe de Sang est aussi fort qu'intelligent, il aime joué avec l'humeur des Héros. Son arme principale est son Arc de Feu... Il est clairement le boss du jeu !";
                    mon.Weapon = "Arc de Feu";
                    mon.Endu = 9;
                    mon.Force = 12;
                    mon.Def = 5 + (mon.Endu * 2);
                    mon.Hp = 45 + (mon.Endu * 3);
                    mon.Spec = 7;
                    mon.Agi = 8;
                    mon.Chance = 0;
                    mon.Skin = "B";
                    mon.Boss = true;
                }*/
                
            }
            return monstres;
        }
        public List<Monstre> InitMonstre2(Hero h)
        {
            List<Monstre> monstres2 = new List<Monstre>();
            for (int i = 0; i < 29; i++)
            {
                monstres2.Add(new Monstre() { Id = i + 1 });
            }
            foreach (Monstre mon in monstres2)
            {
                if (h.Victoire > 0)
                {
                    if (mon.Id < 11)
                    {
                        mon.Race = "Loup";
                        mon.Description = "Le loup féroce est un monstre intelligent mais faible. Son arme principale est sa machoire et possède peu de vie, mais a une bonne esquive.";
                        mon.Weapon = "Crocs";
                        mon.Endu = 1 + (10 * h.VictoireTotale);
                        mon.Force = 5 + (10 * h.VictoireTotale);
                        mon.Def = 2 + (mon.Endu * 2) + (10 * h.VictoireTotale);
                        mon.Hp = 14 + (mon.Endu * 3) + (10 * h.VictoireTotale);
                        mon.Spec = 0 + (10 * h.VictoireTotale);
                        mon.Agi = 5 + (10 * h.VictoireTotale);
                        mon.Chance = 0;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        mon.Skin = "L";
                        Console.ResetColor();
                        mon.Boss = false;
                    }
                    if (mon.Id > 10 && mon.Id < 21)
                    {
                        mon.Race = "Orc";
                        mon.Description = "L'orc est un monstre dénué d'intelligence, il aime se nourir des diverses héros plus faibles que lui. Son arme principale est sa Lame Diforme et possède une bonne attaque.";
                        mon.Weapon = "Lame Diforme";
                        mon.Endu = 2 + (10 * h.VictoireTotale);
                        mon.Force = 9 + (10 * h.VictoireTotale);
                        mon.Def = 3 + (mon.Endu * 2) + (10 * h.VictoireTotale);
                        mon.Hp = 25 + (mon.Endu * 3) + (10 * h.VictoireTotale);
                        mon.Spec = 0 + (10 * h.VictoireTotale);
                        mon.Agi = 3 + (10 * h.VictoireTotale);
                        mon.Chance = 0;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        mon.Skin = "O";
                        Console.ResetColor();
                        mon.Boss = false;
                    }
                    if (mon.Id > 20 && mon.Id < 31)
                    {
                        mon.Race = "Cyclope";
                        mon.Description = "Malfré qu'il n'a qu'un oeuil il arrivera toujours à vous suivre du regard, plutôt résistant et complet. Ne rate jamais sa cible !";
                        mon.Weapon = "Tronc d'arbre";
                        mon.Endu = 6 + (10 * h.VictoireTotale);
                        mon.Force = 11 + (10 * h.VictoireTotale);
                        mon.Def = 5 + (mon.Endu * 2) + (10 * h.VictoireTotale);
                        mon.Hp = 40 + (mon.Endu * 3) + (10 * h.VictoireTotale);
                        mon.Spec = 10 + (10 * h.VictoireTotale);
                        mon.Agi = 4 + (10 * h.VictoireTotale);
                        mon.Chance = 0;
                        Console.ForegroundColor= ConsoleColor.DarkMagenta;
                        mon.Skin = "C";
                        Console.ResetColor();
                        mon.Boss = false;
                    }
                }
            }
            return monstres2;
        }
        public List<Monstre> InitMonstreBoss(Hero h)
        {
            List<Monstre> monstresb = new List<Monstre>();
            for (int i = 0; i < 5; i++)
            {
                monstresb.Add(new Monstre() { Id = i + 1 });
            }
            foreach (Monstre mon in monstresb)
            {
                if (mon.Id < 5)
                {
                    mon.Race = "Sbire Boss";
                    mon.Description = "La garde rapporchée du boss, quand on les rencontre, on prie d'avoir assez de dégats que pour les affronter.";
                    mon.Weapon = "Dagues";
                    mon.Endu = 3 + 2 + (10 * h.VictoireTotale);
                    mon.Force = 15 + 2 + (10 * h.VictoireTotale);
                    mon.Def = 5 + (mon.Endu * 2) + 2 + (10 * h.VictoireTotale);
                    mon.Hp = 75 + (mon.Endu * 3) + 2 + (10 * h.VictoireTotale);
                    mon.Spec = 0 + 2 + (10 * h.VictoireTotale);
                    mon.Agi = 4 + 2 + (10 * h.VictoireTotale);
                    mon.Chance = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    mon.Skin = "S";
                    Console.ResetColor();
                    mon.Boss = false;
                }
                if (mon.Id == 5)
                {
                    mon.Race = "Elfe de Sang";
                    mon.Description = "L'Elfe de Sang est aussi fort qu'intelligent, il aime joué avec l'humeur des Héros. Son arme principale est son Arc de Feu... Il est clairement le boss du jeu !";
                    mon.Weapon = "Arc de Feu";
                    mon.Endu = 9 + 2 + (10 * h.VictoireTotale);
                    mon.Force = 20 + 2 + (10 * h.VictoireTotale);
                    mon.Def = 5 + (mon.Endu * 2) + 2 + (10 * h.VictoireTotale);
                    mon.Hp = 90 + (mon.Endu * 3) + 2 + (10 * h.VictoireTotale);
                    mon.Spec = 7 + 2 + (10 * h.VictoireTotale);
                    mon.Agi = 6 + 2 + (10 * h.VictoireTotale);
                    mon.Chance = 0;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    mon.Skin = "B";
                    Console.ResetColor();
                    mon.Boss = true;
                }

            }
            return monstresb;
        }
        public List<Monstre> InitMonstreBoss2()
        {
            List<Monstre> monstresb2 = new List<Monstre>();
            for (int i = 0; i < 5; i++)
            {
                monstresb2.Add(new Monstre() { Id = i + 1 });
            }
            foreach (Monstre mon in monstresb2)
            {
                if (mon.Id < 5)
                {
                    mon.Race = "Sbire Boss";
                    mon.Description = "La garde rapporchée du boss, quand on les rencontre, on prie d'avoir assez de dégats que pour les affronter.";
                    mon.Weapon = "Dagues";
                    mon.Endu = 3;
                    mon.Force = 15;
                    mon.Def = 5 + (mon.Endu * 2);
                    mon.Hp = 75 + (mon.Endu * 3);
                    mon.Spec = 0;
                    mon.Agi = 4;
                    mon.Chance = 0;
                    Console.ForegroundColor= ConsoleColor.Red;
                    mon.Skin = "S";
                    Console.ResetColor();
                    mon.Boss = false;
                }
                if (mon.Id == 5)
                {
                    mon.Race = "Elfe de Sang";
                    mon.Description = "L'Elfe de Sang est aussi fort qu'intelligent, il aime joué avec l'humeur des Héros. Son arme principale est son Arc de Feu... Il est clairement le boss du jeu !";
                    mon.Weapon = "Arc de Feu";
                    mon.Endu = 9;
                    mon.Force = 20;
                    mon.Def = 5 + (mon.Endu * 2);
                    mon.Hp = 90 + (mon.Endu * 3);
                    mon.Spec = 7;
                    mon.Agi = 8;
                    mon.Chance = 0;
                    Console.ForegroundColor= ConsoleColor.DarkRed;
                    mon.Skin = "B";
                    Console.ResetColor();
                    mon.Boss = true;
                }

            }
            return monstresb2;
        }
    }
}
