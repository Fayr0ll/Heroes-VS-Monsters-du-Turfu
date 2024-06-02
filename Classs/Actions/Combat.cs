using Heroes_VS_Monsters_du_Turfu.Classs.Personnages;
using Heroes_VS_Monsters_du_Turfu.Classs.PicturesAndSounds;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Heroes_VS_Monsters_du_Turfu.Classs.Actions
{
    public static class Combat
    {
        public static void EnCombat(Hero h, Monstre m)
        {
            Console.Clear();
            Pictures p = new Pictures();
            switch (m.Race)
            {
                case "Elfe de Sang":
                    p.RenderboardElfeFeu();
                    SoundManager.Instance.Play("Elfe de Sang.wav");
                    break;
                case "Loup":
                    p.RenderboardWolf();
                    SoundManager.Instance.Play("Loup.wav");
                    Thread.Sleep(2000);
                    break;
                case "Cyclope":
                    p.RenderBoardh1();
                    SoundManager.Instance.Play("Cyclope.wav");
                    Thread.Sleep(2000);
                    break;
                case "Orc":
                    p.RenderboardOrc();
                    SoundManager.Instance.Play("Orc.wav");
                    Thread.Sleep(2000);
                    break;
                case "Sbire Boss":
                    p.RenderboardSbire();
                    SoundManager.Instance.Play("SbireBoss.wav");
                    Thread.Sleep(3500);
                    break;
            }
            if (m.Race == "Elfe de Sang") SoundManager.Instance.Play("BossCombat.wav");
            else SoundManager.Instance.Play("Combat.wav");
            int temp = h.Hp;
            
            do
            {
                int degatH = 5 + h.Force + Radomizer.DeSix() - ((m.Endu / 2) + m.Def);
                int degatM = 4 + m.Force + Radomizer.DeSix() - ((h.Endu / 2) + h.Def);
                Console.ForegroundColor = ConsoleColor.Cyan;
                degatH = m.Pdvm(degatH);
                Console.WriteLine($"{(h as Hero).Pseudo} attaque un(e) {m.Race} et lui inflige {degatH} dégats lui laissant {m.Hp} points de vies");
                Thread.Sleep(1000);
                if (m.Hp > 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    degatM = h.Pdvh(degatM);
                    Console.WriteLine($"{m.Race} attaque {(h as Hero).Pseudo} et lui inflige {degatM} dégats lui laissant {h.Hp} points de vies");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                }

            } while (!h.Mort is true && !m.Mort is true);

            if (h.Mort is true)
            {
                EndGame(h);
            }
            if (m.Mort is true) 
            {
                SoundManager.Instance.Play("VictoireCombat1.wav");
                Thread.Sleep(3000);
                if (m.Race == "Elfe de Sang") h.VictoireTotale += 1;
                if (m.Race == "Loup") h.VicLoup += 1;
                if (m.Race == "Orc") h.VicOrc += 1;
                if (m.Race == "Cyclope") h.VicCyc += 1;
                h.Hp = temp;
                h.Victoire += 1;
                h.Hp += 5;
                h.Force += 2;
                h.Def += 2;
                h.Agi += 2;
                h.Chance += 2;
                h.Drop(m, h);
                Console.Clear();
                SoundManager.Instance.Play("Combat1.wav");
            }
        }
        public static void EndGame(Hero h)
        {
            SoundManager.Instance.Play("GameOver.wav");
            Pictures p = new Pictures();
            p.RenderboardDead();
            Console.WriteLine("                                                                                                             Vous êtes décédé");
            Thread.Sleep(8000);
            Console.Clear();
            p.RenderboardGameOver();
            Thread.Sleep(5000);
            p.RenderboardGenerique();
            Console.Clear();
            Spawn.StartGame();
        }
        public static void Mag(Hero h)
        {
            SoundManager.Instance.Play("Boutique.wav");
            ConsoleKeyInfo ckii;
            Pictures pm = new Pictures();
            pm.RenderBoardMag();
            Console.WriteLine("                                                                                                Le Marchand Ambulant vous salue, que désirez vous ?");
            Console.WriteLine("                                                                                             Pour 20 pièces d'or, je vous proposes un boost + 3 en Force");
            Console.WriteLine("                                                                                  Pour 15 cuirs, je vous proposes une amélioration de votre slip donnant + 3 en Défense");
            Console.WriteLine("                                                                    Pour 12 plastiques, je cède cet utile slime familier nommé 'La Bille' qui te donne +1 en Force, 1 en Défense et + 2 en Chance");
            Console.WriteLine("                                                                      À l'aide du pavé numérique appuyer sur (1) pour le boost (2) pour le up du slip (3) pour 'La Bille' ou (4) pour déguerpir !");
            ckii = Console.ReadKey();
            switch (ckii.Key) 
            {
                case ConsoleKey.NumPad1:
                    if (h.Gold >= 20)
                    {
                        h.Gold -= 20;
                        h.Force += 3;
                        Console.WriteLine("                                                                                                Merci pour votre achat !");
                        Thread.Sleep(1000);
                    }
                    break;
                case ConsoleKey.NumPad2:
                    if (h.Cuir >= 15)
                    {
                        h.Cuir -= 15;
                        h.Def += 3;
                        Console.WriteLine("                                                                                                Merci pour votre achat !");
                        Thread.Sleep(1000);
                    }
                    break;
                case ConsoleKey.NumPad3:
                    if (h.Plastic >= 12)
                    {
                        h.Plastic -= 12;
                        h.Force += 1;
                        h.Def += 1;
                        h.Chance += 2;
                        Console.WriteLine("                                                                                               Merci pour votre achat !");
                        Thread.Sleep(1000);
                    }
                    break;
                case ConsoleKey.NumPad4:
                    Console.WriteLine("                                                                                           Au revoir ! Que votre mort soit douloureuse !");
                    Thread.Sleep(1000);
                    break;
                default: Console.WriteLine("                                                                       Veullez utiliser (1) (2) (3) ou (4) ... Ne faites pas la brute sur le clavier !");
                    Thread.Sleep(1000);
                    break;
            }
            SoundManager.Instance.Play("Combat1.wav");
        }
    }
}
