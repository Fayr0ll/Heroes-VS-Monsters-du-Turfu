using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using Heroes_VS_Monsters_du_Turfu.Classs.PicturesAndSounds;
using Heroes_VS_Monsters_du_Turfu.Classs.Personnages;
using System.ComponentModel.Design;
using System.Windows.Input;
using System.Collections;


namespace Heroes_VS_Monsters_du_Turfu.Classs.Actions
{

    public static class Deplacement
    {
        public static void Move(Hero h, string[,] mapt, List<Monstre> monsters, List<Buisson> buissons, List<Coffre> coffres, List<Arbre> arbres, List<Pnj> pnjs)//, List<Mur> m1, List<Mur> m2)
        {
            Thread.Sleep(1500);
            Console.WriteLine($"                                                                                Étage {h.VictoireTotale + 1}");
            Thread.Sleep(2000);
            ConsoleKeyInfo ckii;
            SoundManager.Instance.Play("Combat1.wav");
            int poss = 0;
            int puss = 0;
            int possmAx = 14;
            int pussmAx = 44;
            Pictures picture = new Pictures();
            Plateauprincipale(mapt);

            do
            {

                ckii = Console.ReadKey();

                mapt[poss, puss] = " ";

                switch (ckii.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (mapt[poss, puss] == " " || mapt[poss, puss] == "#" || mapt[poss, puss] == "@")// || mapt[poss, puss] == "|" || mapt[poss, puss] == "_")
                        {
                            if (puss == 0)
                            {
                                Thread.Sleep(1000);
                                Console.WriteLine("Vous vous heurtez à un mur, le mieux serait d'ouvrir les yeux lors de vos déplacements.");
                            }
                            if (puss > 0)
                            {
                                if (mapt[poss, puss - 1] == "#")
                                {
                                    Console.WriteLine("Ce buisson est trop épineux que pour le traverser, tentez de le contourner !");
                                    Thread.Sleep(1000);
                                    break;
                                }
                                if (mapt[poss, puss - 1] == "@")
                                {
                                    Console.WriteLine("Un arbre vous barre la route... Ouvre les yeux !");
                                    Thread.Sleep(1000);
                                    break;
                                }
                                /*if (mapt[poss, puss - 1] == "|" || mapt[poss, puss - 1] == "_")
                                {
                                    Console.WriteLine("Vous heurtez un mur ! Attention !");
                                    Thread.Sleep(1000);
                                    break;
                                }*/
                                puss--;
                            }

                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (mapt[poss, puss] == " " || mapt[poss, puss] == "#" || mapt[poss, puss] == "@")// || mapt[poss, puss] == "|" || mapt[poss, puss] == "_")
                        {
                            if (puss == pussmAx)
                            {
                                Thread.Sleep(1000);
                                Console.WriteLine("Vous vous heurtez à un mur, le mieux serait d'ouvrir les yeux lors de vos déplacements.");
                            }
                            if (puss < pussmAx)
                            {
                                if (mapt[poss, puss + 1] == "#")
                                {
                                    Console.WriteLine("Ce buisson est trop épineux que pour le traverser, tentez de le contourner !");
                                    Thread.Sleep(1000);
                                    break;
                                }
                                if (mapt[poss, puss + 1] == "@")
                                {
                                    Console.WriteLine("Un arbre vous barre la route... Ouvre les yeux !");
                                    Thread.Sleep(1000);
                                    break;
                                }
                                /*if (mapt[poss, puss + 1] == "|" || mapt[poss, puss + 1] == "_")
                                {
                                    Console.WriteLine("Vous heurtez un mur ! Attention !");
                                    Thread.Sleep(1000);
                                    break;
                                }*/
                                puss++;
                            }
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (mapt[poss, puss] == " " || mapt[poss, puss] == "#" || mapt[poss, puss] == "@")// || mapt[poss, puss] == "|" || mapt[poss, puss] == "_")
                        {
                            if (poss == 0)
                            {
                                Thread.Sleep(1000);
                                Console.WriteLine("Vous vous heurtez à un mur, le mieux serait d'ouvrir les yeux lors de vos déplacements.");
                            }
                            if (poss > 0)
                            {
                                if (mapt[poss - 1, puss] == "#")
                                {
                                    Console.WriteLine("Ce buisson est trop épineux que pour le traverser, tentez de le contourner !");
                                    Thread.Sleep(1000);
                                    break;
                                }
                                if (mapt[poss - 1, puss] == "@")
                                {
                                    Console.WriteLine("Un arbre vous barre la route... Ouvre les yeux !");
                                    Thread.Sleep(1000);
                                    break;
                                }
                                /*if (mapt[poss - 1, puss] == "|" || mapt[poss - 1, puss] == "_")
                                {
                                    Console.WriteLine("Vous heurtez un mur ! Attention !");
                                    Thread.Sleep(1000);
                                    break;
                                }*/
                                poss--;
                            }
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (mapt[poss, puss] == " " || mapt[poss, puss] == "#" || mapt[poss, puss] == "@") //|| mapt[poss, puss] == "|" || mapt[poss, puss] == "_")
                        {
                            if (poss == possmAx)
                            {
                                Thread.Sleep(1000);
                                Console.WriteLine("Vous vous heurtez à un mur, le mieux serait d'ouvrir les yeux lors de vos déplacements.");
                            }
                            if (poss < possmAx)
                            {
                                if (mapt[poss + 1, puss] == "#")
                                {
                                    Console.WriteLine("Ce buisson est trop épineux que pour le traverser, tentez de le contourner !");
                                    Thread.Sleep(1000);
                                    break;
                                }
                                if (mapt[poss + 1, puss] == "@")
                                {
                                    Console.WriteLine("Un arbre vous barre la route... Ouvre les yeux !");
                                    Thread.Sleep(1000);
                                    break;
                                }
                                /*if (mapt[poss + 1, puss] == "|" || mapt[poss + 1, puss] == "_")
                                {
                                    Console.WriteLine("Vous heurtez un mur ! Attention !");
                                    Thread.Sleep(1000);
                                    break;
                                }*/
                                poss++;
                            }
                        }
                        break;

                    case ConsoleKey.Enter:
                        Console.Clear();
                        picture.RenderboardInventaire();
                        Console.WriteLine($"                                                                                               {h.Pseudo} Votre Inventaire dispose de:");
                        Console.WriteLine($"                                                                                                         Or = {h.Gold}");
                        Console.WriteLine($"                                                                                                        Cuir = {h.Cuir}");
                        Console.WriteLine($"                                                                                                    Plastique = {h.Plastic}");
                        Console.WriteLine($"                                                                     Un tour à la boutique du Marchand Ambulant ? Appuyer sur '8' à l'aide du pavé numérique !");
                        ckii = Console.ReadKey();
                        if (ckii.Key is ConsoleKey.NumPad8)
                        {
                            Console.Clear();
                            Combat.Mag(h);
                        }
                        do
                        {
                            ckii = Console.ReadKey();
                            if (ckii.Key is ConsoleKey.Enter)
                            {
                                Console.Clear();
                                Plateauprincipale(mapt);
                                break;
                            }
                            Console.WriteLine("                                                                                  Appuyer sur Enter semblait pourtant ne pas être compliqué");
                        } while (ckii.Key == ConsoleKey.Enter);
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine($"                                                                                  Dommage d'abandonner si vite ! Au revoir {h.Pseudo} Mr le lâche...");
                        break;

                    default:
                        Console.WriteLine("Appuyer sur les Flèches Directionelles pour vous déplacer, Enter pour accéder à l'Inventaire/Pause et escape pour quitter");
                        break;

                }
                Console.Clear();
                mapt[poss, puss] = h.Skin;
                Pnj pj;
                Monstre ms;
                Coffre cc;
                h.Poss = poss;
                h.Puss = puss;

                if (h.Poss != possmAx)
                {
                    if (mapt[h.Poss + 1, h.Puss] == "O" || mapt[h.Poss + 1, h.Puss] == "Q" || mapt[h.Poss + 1, h.Puss] == "L" || mapt[h.Poss + 1, h.Puss] == "C" || mapt[h.Poss + 1, h.Puss] == "↨")
                    {
                        foreach (Coffre coffre in coffres)
                        {
                            if (coffre.Poss == h.Poss + 1 && coffre.Puss == h.Puss)
                            {
                                mapt[h.Poss + 1, h.Puss] = " ";
                                cc = coffre;
                                Coffre.Loot(h, cc);
                            }
                        }
                        foreach (Monstre monstre in monsters)
                        {
                            if (monstre.Poss == h.Poss + 1 && monstre.Puss == h.Puss)
                            {
                                mapt[h.Poss + 1, h.Puss] = " ";
                                ms = monstre;
                                Combat.EnCombat(h, ms);
                            }

                        }
                        foreach (Pnj pnj in pnjs)
                        {
                            if (pnj.Poss == h.Poss + 1 && pnj.Puss == h.Puss)
                            {
                                pj = pnj;
                                Quest.DQuest(h, pj);
                                if (pnj.Complete is true) mapt[h.Poss + 1, h.Puss] = " ";
                            }
                        }
                    }
                }

                if (h.Poss != 0)
                {
                    if (mapt[h.Poss - 1, h.Puss] == "O" || mapt[h.Poss - 1, h.Puss] == "Q" || mapt[h.Poss - 1, h.Puss] == "L" || mapt[h.Poss - 1, h.Puss] == "C" || mapt[h.Poss - 1, h.Puss] == "↨")
                    {
                        foreach (Coffre coffre in coffres)
                        {
                            if (coffre.Poss == h.Poss - 1 && coffre.Puss == h.Puss)
                            {
                                mapt[h.Poss - 1, h.Puss] = " ";
                                cc = coffre;
                                Coffre.Loot(h, cc);
                            }
                        }
                        foreach (Monstre monstre in monsters)
                        {
                            if (monstre.Poss == h.Poss - 1 && monstre.Puss == h.Puss)
                            {
                                mapt[h.Poss - 1, h.Puss] = " ";
                                ms = monstre;
                                Combat.EnCombat(h, ms);
                            }
                        }
                        foreach (Pnj pnj in pnjs)
                        {
                            if (pnj.Poss == h.Poss - 1 && pnj.Puss == h.Puss)
                            {
                                pj = pnj;
                                Quest.DQuest(h, pj);
                                if (pnj.Complete is true) mapt[h.Poss - 1, h.Puss] = " ";
                            }
                        }
                    }
                }

                if (h.Puss != pussmAx)
                {
                    if (mapt[h.Poss, h.Puss + 1] == "O" || mapt[h.Poss, h.Puss + 1] == "Q" || mapt[h.Poss, h.Puss + 1] == "L" || mapt[h.Poss, h.Puss + 1] == "C" || mapt[h.Poss, h.Puss + 1] == "↨")
                    {
                        foreach (Coffre coffre in coffres)
                        {
                            if (coffre.Puss == h.Puss + 1 && coffre.Poss == h.Poss)
                            {
                                mapt[h.Poss, h.Puss + 1] = " ";
                                cc = coffre;
                                Coffre.Loot(h, cc);
                            }
                        }
                        foreach (Monstre monstre in monsters)
                        {
                            if (monstre.Puss == h.Puss + 1 && monstre.Poss == h.Poss)
                            {
                                mapt[h.Poss, h.Puss + 1] = " ";
                                ms = monstre;
                                Combat.EnCombat(h, ms);
                            }
                        }
                        foreach (Pnj pnj in pnjs)
                        {
                            if (pnj.Poss == h.Puss + 1 && pnj.Poss == h.Puss)
                            {
                                pj = pnj;
                                Quest.DQuest(h, pj);
                                if (pnj.Complete is true) mapt[h.Poss, h.Puss + 1] = " ";
                            }
                        }
                    }
                }

                if (h.Puss != 0)
                {
                    if (mapt[h.Poss, h.Puss - 1] == "O" || mapt[h.Poss, h.Puss - 1] == "Q" || mapt[h.Poss, h.Puss - 1] == "L" || mapt[h.Poss, h.Puss - 1] == "C" || mapt[h.Poss, h.Puss - 1] == "↨")
                    {
                        foreach (Coffre coffre in coffres)
                        {
                            if (coffre.Puss == h.Puss - 1 && coffre.Poss == h.Poss)
                            {
                                mapt[h.Poss, h.Puss - 1] = " ";
                                cc = coffre;
                                Coffre.Loot(h, cc);
                            }
                        }
                        foreach (Monstre monstre in monsters)
                        {
                            if (monstre.Puss == h.Puss - 1 && monstre.Poss == h.Poss)
                            {
                                mapt[h.Poss, h.Puss - 1] = " ";
                                ms = monstre;
                                Combat.EnCombat(h, ms);
                            }
                        }
                        foreach (Pnj pnj in pnjs)
                        {
                            if (pnj.Puss == h.Puss - 1 && pnj.Poss == h.Poss)
                            {
                                pj = pnj;
                                Quest.DQuest(h, pj);
                                if (pnj.Complete is true) mapt[h.Poss, h.Puss - 1] = " ";
                            }
                        }
                    }
                }
                Plateauprincipale(mapt);
            }
            while (ckii.Key != ConsoleKey.Escape && (h.QuestComplete != 3));
            h.VictoireEtage++;
            h.QuestComplete = 0;
        }
        
        public static void Plateauprincipale(string[,] mapt)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine($"-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"| {mapt[0, 0]} | {mapt[0, 1]} | {mapt[0, 2]} | {mapt[0, 3]} | {mapt[0, 4]} | {mapt[0, 5]} | {mapt[0, 6]} | {mapt[0, 7]} | {mapt[0, 8]} | {mapt[0, 9]} | {mapt[0, 10]} | {mapt[0, 11]} | {mapt[0, 12]} | {mapt[0, 13]} | {mapt[0, 14]} | {mapt[0, 15]} | {mapt[0, 16]} | {mapt[0, 17]} | {mapt[0, 18]} | {mapt[0, 19]} | {mapt[0, 20]} | {mapt[0, 21]} | {mapt[0, 22]} | {mapt[0, 23]} | {mapt[0, 24]} | {mapt[0, 25]} | {mapt[0, 26]} | {mapt[0, 27]} | {mapt[0, 28]} | {mapt[0, 29]} | {mapt[0, 30]} | {mapt[0, 31]} | {mapt[0, 32]} | {mapt[0, 33]} | {mapt[0, 34]} | {mapt[0, 35]} | {mapt[0, 36]} | {mapt[0, 37]} | {mapt[0, 38]} | {mapt[0, 39]} | {mapt[0, 40]} | {mapt[0, 41]} | {mapt[0, 42]} | {mapt[0, 43]} | {mapt[0, 44]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[1, 0]} | {mapt[1, 1]} | {mapt[1, 2]} | {mapt[1, 3]} | {mapt[1, 4]} | {mapt[1, 5]} | {mapt[1, 6]} | {mapt[1, 7]} | {mapt[1, 8]} | {mapt[1, 9]} | {mapt[1, 10]} | {mapt[1, 11]} | {mapt[1, 12]} | {mapt[1, 13]} | {mapt[1, 14]} | {mapt[1, 15]} | {mapt[1, 16]} | {mapt[1, 17]} | {mapt[1, 18]} | {mapt[1, 19]} | {mapt[1, 20]} | {mapt[1, 21]} | {mapt[1, 22]} | {mapt[1, 23]} | {mapt[1, 24]} | {mapt[1, 25]} | {mapt[1, 26]} | {mapt[1, 27]} | {mapt[1, 28]} | {mapt[1, 29]} | {mapt[1, 30]} | {mapt[1, 31]} | {mapt[1, 32]} | {mapt[1, 33]} | {mapt[1, 34]} | {mapt[1, 35]} | {mapt[1, 36]} | {mapt[1, 37]} | {mapt[1, 38]} | {mapt[1, 39]} | {mapt[1, 40]} | {mapt[1, 41]} | {mapt[1, 42]} | {mapt[1, 43]} | {mapt[1, 44]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[2, 0]} | {mapt[2, 1]} | {mapt[2, 2]} | {mapt[2, 3]} | {mapt[2, 4]} | {mapt[2, 5]} | {mapt[2, 6]} | {mapt[2, 7]} | {mapt[2, 8]} | {mapt[2, 9]} | {mapt[2, 10]} | {mapt[2, 11]} | {mapt[2, 12]} | {mapt[2, 13]} | {mapt[2, 14]} | {mapt[2, 15]} | {mapt[2, 16]} | {mapt[2, 17]} | {mapt[2, 18]} | {mapt[2, 19]} | {mapt[2, 20]} | {mapt[2, 21]} | {mapt[2, 22]} | {mapt[2, 23]} | {mapt[2, 24]} | {mapt[2, 25]} | {mapt[2, 26]} | {mapt[2, 27]} | {mapt[2, 28]} | {mapt[2, 29]} | {mapt[2, 30]} | {mapt[2, 31]} | {mapt[2, 32]} | {mapt[2, 33]} | {mapt[2, 34]} | {mapt[2, 35]} | {mapt[2, 36]} | {mapt[2, 37]} | {mapt[2, 38]} | {mapt[2, 39]} | {mapt[2, 40]} | {mapt[2, 41]} | {mapt[2, 42]} | {mapt[2, 43]} | {mapt[2, 44]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[3, 0]} | {mapt[3, 1]} | {mapt[3, 2]} | {mapt[3, 3]} | {mapt[3, 4]} | {mapt[3, 5]} | {mapt[3, 6]} | {mapt[3, 7]} | {mapt[3, 8]} | {mapt[3, 9]} | {mapt[3, 10]} | {mapt[3, 11]} | {mapt[3, 12]} | {mapt[3, 13]} | {mapt[3, 14]} | {mapt[3, 15]} | {mapt[3, 16]} | {mapt[3, 17]} | {mapt[3, 18]} | {mapt[3, 19]} | {mapt[3, 20]} | {mapt[3, 21]} | {mapt[3, 22]} | {mapt[3, 23]} | {mapt[3, 24]} | {mapt[3, 25]} | {mapt[3, 26]} | {mapt[3, 27]} | {mapt[3, 28]} | {mapt[3, 29]} | {mapt[3, 30]} | {mapt[3, 31]} | {mapt[3, 32]} | {mapt[3, 33]} | {mapt[3, 34]} | {mapt[3, 35]} | {mapt[3, 36]} | {mapt[3, 37]} | {mapt[3, 38]} | {mapt[3, 39]} | {mapt[3, 40]} | {mapt[3, 41]} | {mapt[3, 42]} | {mapt[3, 43]} | {mapt[3, 44]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[4, 0]} | {mapt[4, 1]} | {mapt[4, 2]} | {mapt[4, 3]} | {mapt[4, 4]} | {mapt[4, 5]} | {mapt[4, 6]} | {mapt[4, 7]} | {mapt[4, 8]} | {mapt[4, 9]} | {mapt[4, 10]} | {mapt[4, 11]} | {mapt[4, 12]} | {mapt[4, 13]} | {mapt[4, 14]} | {mapt[4, 15]} | {mapt[4, 16]} | {mapt[4, 17]} | {mapt[4, 18]} | {mapt[4, 19]} | {mapt[4, 20]} | {mapt[4, 21]} | {mapt[4, 22]} | {mapt[4, 23]} | {mapt[4, 24]} | {mapt[4, 25]} | {mapt[4, 26]} | {mapt[4, 27]} | {mapt[4, 28]} | {mapt[4, 29]} | {mapt[4, 30]} | {mapt[4, 31]} | {mapt[4, 32]} | {mapt[4, 33]} | {mapt[4, 34]} | {mapt[4, 35]} | {mapt[4, 36]} | {mapt[4, 37]} | {mapt[4, 38]} | {mapt[4, 39]} | {mapt[4, 40]} | {mapt[4, 41]} | {mapt[4, 42]} | {mapt[4, 43]} | {mapt[4, 44]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[5, 0]} | {mapt[5, 1]} | {mapt[5, 2]} | {mapt[5, 3]} | {mapt[5, 4]} | {mapt[5, 5]} | {mapt[5, 6]} | {mapt[5, 7]} | {mapt[5, 8]} | {mapt[5, 9]} | {mapt[5, 10]} | {mapt[5, 11]} | {mapt[5, 12]} | {mapt[5, 13]} | {mapt[5, 14]} | {mapt[5, 15]} | {mapt[5, 16]} | {mapt[5, 17]} | {mapt[5, 18]} | {mapt[5, 19]} | {mapt[5, 20]} | {mapt[5, 21]} | {mapt[5, 22]} | {mapt[5, 23]} | {mapt[5, 24]} | {mapt[5, 25]} | {mapt[5, 26]} | {mapt[5, 27]} | {mapt[5, 28]} | {mapt[5, 29]} | {mapt[5, 30]} | {mapt[5, 31]} | {mapt[5, 32]} | {mapt[5, 33]} | {mapt[5, 34]} | {mapt[5, 35]} | {mapt[5, 36]} | {mapt[5, 37]} | {mapt[5, 38]} | {mapt[5, 39]} | {mapt[5, 40]} | {mapt[5, 41]} | {mapt[5, 42]} | {mapt[5, 43]} | {mapt[5, 44]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[6, 0]} | {mapt[6, 1]} | {mapt[6, 2]} | {mapt[6, 3]} | {mapt[6, 4]} | {mapt[6, 5]} | {mapt[6, 6]} | {mapt[6, 7]} | {mapt[6, 8]} | {mapt[6, 9]} | {mapt[6, 10]} | {mapt[6, 11]} | {mapt[6, 12]} | {mapt[6, 13]} | {mapt[6, 14]} | {mapt[6, 15]} | {mapt[6, 16]} | {mapt[6, 17]} | {mapt[6, 18]} | {mapt[6, 19]} | {mapt[6, 20]} | {mapt[6, 21]} | {mapt[6, 22]} | {mapt[6, 23]} | {mapt[6, 24]} | {mapt[6, 25]} | {mapt[6, 26]} | {mapt[6, 27]} | {mapt[6, 28]} | {mapt[6, 29]} | {mapt[6, 30]} | {mapt[6, 31]} | {mapt[6, 32]} | {mapt[6, 33]} | {mapt[6, 34]} | {mapt[6, 35]} | {mapt[6, 36]} | {mapt[6, 37]} | {mapt[6, 38]} | {mapt[6, 39]} | {mapt[6, 40]} | {mapt[6, 41]} | {mapt[6, 42]} | {mapt[6, 43]} | {mapt[6, 44]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[7, 0]} | {mapt[7, 1]} | {mapt[7, 2]} | {mapt[7, 3]} | {mapt[7, 4]} | {mapt[7, 5]} | {mapt[7, 6]} | {mapt[7, 7]} | {mapt[7, 8]} | {mapt[7, 9]} | {mapt[7, 10]} | {mapt[7, 11]} | {mapt[7, 12]} | {mapt[7, 13]} | {mapt[7, 14]} | {mapt[7, 15]} | {mapt[7, 16]} | {mapt[7, 17]} | {mapt[7, 18]} | {mapt[7, 19]} | {mapt[7, 20]} | {mapt[7, 21]} | {mapt[7, 22]} | {mapt[7, 23]} | {mapt[7, 24]} | {mapt[7, 25]} | {mapt[7, 26]} | {mapt[7, 27]} | {mapt[7, 28]} | {mapt[7, 29]} | {mapt[7, 30]} | {mapt[7, 31]} | {mapt[7, 32]} | {mapt[7, 33]} | {mapt[7, 34]} | {mapt[7, 35]} | {mapt[7, 36]} | {mapt[7, 37]} | {mapt[7, 38]} | {mapt[7, 39]} | {mapt[7, 40]} | {mapt[7, 41]} | {mapt[7, 42]} | {mapt[7, 43]} | {mapt[7, 44]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[8, 0]} | {mapt[8, 1]} | {mapt[8, 2]} | {mapt[8, 3]} | {mapt[8, 4]} | {mapt[8, 5]} | {mapt[8, 6]} | {mapt[8, 7]} | {mapt[8, 8]} | {mapt[8, 9]} | {mapt[8, 10]} | {mapt[8, 11]} | {mapt[8, 12]} | {mapt[8, 13]} | {mapt[8, 14]} | {mapt[8, 15]} | {mapt[8, 16]} | {mapt[8, 17]} | {mapt[8, 18]} | {mapt[8, 19]} | {mapt[8, 20]} | {mapt[8, 21]} | {mapt[8, 22]} | {mapt[8, 23]} | {mapt[8, 24]} | {mapt[8, 25]} | {mapt[8, 26]} | {mapt[8, 27]} | {mapt[8, 28]} | {mapt[8, 29]} | {mapt[8, 30]} | {mapt[8, 31]} | {mapt[8, 32]} | {mapt[8, 33]} | {mapt[8, 34]} | {mapt[8, 35]} | {mapt[8, 36]} | {mapt[8, 37]} | {mapt[8, 38]} | {mapt[8, 39]} | {mapt[8, 40]} | {mapt[8, 41]} | {mapt[8, 42]} | {mapt[8, 43]} | {mapt[8, 44]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[9, 0]} | {mapt[9, 1]} | {mapt[9, 2]} | {mapt[9, 3]} | {mapt[9, 4]} | {mapt[9, 5]} | {mapt[9, 6]} | {mapt[9, 7]} | {mapt[9, 8]} | {mapt[9, 9]} | {mapt[9, 10]} | {mapt[9, 11]} | {mapt[9, 12]} | {mapt[9, 13]} | {mapt[9, 14]} | {mapt[9, 15]} | {mapt[9, 16]} | {mapt[9, 17]} | {mapt[9, 18]} | {mapt[9, 19]} | {mapt[9, 20]} | {mapt[9, 21]} | {mapt[9, 22]} | {mapt[9, 23]} | {mapt[9, 24]} | {mapt[9, 25]} | {mapt[9, 26]} | {mapt[9, 27]} | {mapt[9, 28]} | {mapt[9, 29]} | {mapt[9, 30]} | {mapt[9, 31]} | {mapt[9, 32]} | {mapt[9, 33]} | {mapt[9, 34]} | {mapt[9, 35]} | {mapt[9, 36]} | {mapt[9, 37]} | {mapt[9, 38]} | {mapt[9, 39]} | {mapt[9, 40]} | {mapt[9, 41]} | {mapt[9, 42]} | {mapt[9, 43]} | {mapt[9, 44]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[10, 0]} | {mapt[10, 1]} | {mapt[10, 2]} | {mapt[10, 3]} | {mapt[10, 4]} | {mapt[10, 5]} | {mapt[10, 6]} | {mapt[10, 7]} | {mapt[10, 8]} | {mapt[10, 9]} | {mapt[10, 10]} | {mapt[10, 11]} | {mapt[10, 12]} | {mapt[10, 13]} | {mapt[10, 14]} | {mapt[10, 15]} | {mapt[10, 16]} | {mapt[10, 17]} | {mapt[10, 18]} | {mapt[10, 19]} | {mapt[10, 20]} | {mapt[10, 21]} | {mapt[10, 22]} | {mapt[10, 23]} | {mapt[10, 24]} | {mapt[10, 25]} | {mapt[10, 26]} | {mapt[10, 27]} | {mapt[10, 28]} | {mapt[10, 29]} | {mapt[10, 30]} | {mapt[10, 31]} | {mapt[10, 32]} | {mapt[10, 33]} | {mapt[10, 34]} | {mapt[10, 35]} | {mapt[10, 36]} | {mapt[10, 37]} | {mapt[10, 38]} | {mapt[10, 39]} | {mapt[10, 40]} | {mapt[10, 41]} | {mapt[10, 42]} | {mapt[10, 43]} | {mapt[10, 44]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[11, 0]} | {mapt[11, 1]} | {mapt[11, 2]} | {mapt[11, 3]} | {mapt[11, 4]} | {mapt[11, 5]} | {mapt[11, 6]} | {mapt[11, 7]} | {mapt[11, 8]} | {mapt[11, 9]} | {mapt[11, 10]} | {mapt[11, 11]} | {mapt[11, 12]} | {mapt[11, 13]} | {mapt[11, 14]} | {mapt[11, 15]} | {mapt[11, 16]} | {mapt[11, 17]} | {mapt[11, 18]} | {mapt[11, 19]} | {mapt[11, 20]} | {mapt[11, 21]} | {mapt[11, 22]} | {mapt[11, 23]} | {mapt[11, 24]} | {mapt[11, 25]} | {mapt[11, 26]} | {mapt[11, 27]} | {mapt[11, 28]} | {mapt[11, 29]} | {mapt[11, 30]} | {mapt[11, 31]} | {mapt[11, 32]} | {mapt[11, 33]} | {mapt[11, 34]} | {mapt[11, 35]} | {mapt[11, 36]} | {mapt[11, 37]} | {mapt[11, 38]} | {mapt[11, 39]} | {mapt[11, 40]} | {mapt[11, 41]} | {mapt[11, 42]} | {mapt[11, 43]} | {mapt[11, 44]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[12, 0]} | {mapt[12, 1]} | {mapt[12, 2]} | {mapt[12, 3]} | {mapt[12, 4]} | {mapt[12, 5]} | {mapt[12, 6]} | {mapt[12, 7]} | {mapt[12, 8]} | {mapt[12, 9]} | {mapt[12, 10]} | {mapt[12, 11]} | {mapt[12, 12]} | {mapt[12, 13]} | {mapt[12, 14]} | {mapt[12, 15]} | {mapt[12, 16]} | {mapt[12, 17]} | {mapt[12, 18]} | {mapt[12, 19]} | {mapt[12, 20]} | {mapt[12, 21]} | {mapt[12, 22]} | {mapt[12, 23]} | {mapt[12, 24]} | {mapt[12, 25]} | {mapt[12, 26]} | {mapt[12, 27]} | {mapt[12, 28]} | {mapt[12, 29]} | {mapt[12, 30]} | {mapt[12, 31]} | {mapt[12, 32]} | {mapt[12, 33]} | {mapt[12, 34]} | {mapt[12, 35]} | {mapt[12, 36]} | {mapt[12, 37]} | {mapt[12, 38]} | {mapt[12, 39]} | {mapt[12, 40]} | {mapt[12, 41]} | {mapt[12, 42]} | {mapt[12, 43]} | {mapt[12, 44]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[13, 0]} | {mapt[13, 1]} | {mapt[13, 2]} | {mapt[13, 3]} | {mapt[13, 4]} | {mapt[13, 5]} | {mapt[13, 6]} | {mapt[13, 7]} | {mapt[13, 8]} | {mapt[13, 9]} | {mapt[13, 10]} | {mapt[13, 11]} | {mapt[13, 12]} | {mapt[13, 13]} | {mapt[13, 14]} | {mapt[13, 15]} | {mapt[13, 16]} | {mapt[13, 17]} | {mapt[13, 18]} | {mapt[13, 19]} | {mapt[13, 20]} | {mapt[13, 21]} | {mapt[13, 22]} | {mapt[13, 23]} | {mapt[13, 24]} | {mapt[13, 25]} | {mapt[13, 26]} | {mapt[13, 27]} | {mapt[13, 28]} | {mapt[13, 29]} | {mapt[13, 30]} | {mapt[13, 31]} | {mapt[13, 32]} | {mapt[13, 33]} | {mapt[13, 34]} | {mapt[13, 35]} | {mapt[13, 36]} | {mapt[13, 37]} | {mapt[13, 38]} | {mapt[13, 39]} | {mapt[13, 40]} | {mapt[13, 41]} | {mapt[13, 42]} | {mapt[13, 43]} | {mapt[13, 44]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[14, 0]} | {mapt[14, 1]} | {mapt[14, 2]} | {mapt[14, 3]} | {mapt[14, 4]} | {mapt[14, 5]} | {mapt[14, 6]} | {mapt[14, 7]} | {mapt[14, 8]} | {mapt[14, 9]} | {mapt[14, 10]} | {mapt[14, 11]} | {mapt[14, 12]} | {mapt[14, 13]} | {mapt[14, 14]} | {mapt[14, 15]} | {mapt[14, 16]} | {mapt[14, 17]} | {mapt[14, 18]} | {mapt[14, 19]} | {mapt[14, 20]} | {mapt[14, 21]} | {mapt[14, 22]} | {mapt[14, 23]} | {mapt[14, 24]} | {mapt[14, 25]} | {mapt[14, 26]} | {mapt[14, 27]} | {mapt[14, 28]} | {mapt[14, 29]} | {mapt[14, 30]} | {mapt[14, 31]} | {mapt[14, 32]} | {mapt[14, 33]} | {mapt[14, 34]} | {mapt[14, 35]} | {mapt[14, 36]} | {mapt[14, 37]} | {mapt[14, 38]} | {mapt[14, 39]} | {mapt[14, 40]} | {mapt[14, 41]} | {mapt[14, 42]} | {mapt[14, 43]} | {mapt[14, 44]} |");
            Console.WriteLine($"-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.DarkBlue;

            Console.WriteLine("                                                                                                                                                                              ");
            Console.WriteLine("                                                                                                        ▄████████  ▄█  ████████▄     ▄████████                                ");
            Console.WriteLine("     '#' = Buisson                                                                                     ███    ███ ███  ███   ▀███   ███    ███                                ");
            Console.WriteLine("     '↨' = Coffre                                                                                      ███    ███ ███▌ ███    ███   ███    █▀                                 ");
            Console.WriteLine("     '@' = Arbre                                                                                       ███    ███ ███▌ ███    ███  ▄███▄▄▄                                    ");
            Console.WriteLine("                                                                                                     ▀███████████ ███▌ ███    ███ ▀▀███▀▀▀                                    ");
            Console.WriteLine("     'L' = Loup : Le plus faible des monstre                                                           ███    ███ ███  ███    ███   ███    █▄                                 ");
            Console.WriteLine("     'O' = Orc : Un monstre intermédiaire à ne pas sous-estimer                                        ███    ███ ███  ███   ▄███   ███    ███                                ");
            Console.WriteLine("     'C' = Cyclope : Même avec un seul oeuil le battre semble un être défis                            ███    █▀  █▀   ████████▀    ██████████                                ");
            Console.WriteLine("                                                                                                                                                                                     ");
            Console.WriteLine("                                                                           Astuce n°1 : Finir les 3 quêtes permettent d'accéder au Boss et à sa garde rapporchée !                   ");
            Console.WriteLine("                                                                           Astuce n°2 : Privilégiez les faibles monstres pour évoluer votre personnage                               ");                      
            Console.WriteLine("     'V' = Hero : Vous, le Vagabond                                        Astuce n°3 : Il y a des coffres par étage et peuvent être plus gros par chance                            ");
            Console.WriteLine("     'P' = Hero : TuK_Personne                                             Astuce n°4 : Le Boss sera toujours à votre opposé et toujours accessible contrairement à tout le reste    ");                        
            Console.WriteLine("     'G' = Hero : Geek'Oh                                                  Astuce n°5 : Tuez un maximum de monstre vous permettra d'achetez diverses avantages dans la boutique      ");
            Console.WriteLine("     'D' = Hero : Demi Portion |                                           Astuce n°6 : Appuyez sur Enter pour accédez au menu de pause et à la boutique                             ");
            Console.WriteLine("     'T' = Hero : TotoBlox                                                 Astuce n°7 : Nulle besoin de 'Alt' + 'F4' pour fuir, prenez vos jambes à votre coups ou appuyer sur 'Esc' ");

            Console.ResetColor();                                                                                                    
                                                                                                                     
        }


        /*public static void RenderboardPlateau(string[,] mapt)
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[0, 0]}  |  {mapt[0, 1]}  |  {mapt[0, 2]}  |  {mapt[0, 3]}  |  {mapt[0, 4]}  |  {mapt[0, 5]}  |  {mapt[0, 6]}  |  {mapt[0, 7]}  |  {mapt[0, 8]}  |  {mapt[0, 9]}  |  {mapt[0, 10]}  |  {mapt[0, 11]}  |  {mapt[0, 12]}  |  {mapt[0, 13]}  |  {mapt[0, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[1, 0]}  |  {mapt[1, 1]}  |  {mapt[1, 2]}  |  {mapt[1, 3]}  |  {mapt[1, 4]}  |  {mapt[1, 5]}  |  {mapt[1, 6]}  |  {mapt[1, 7]}  |  {mapt[1, 8]}  |  {mapt[1, 9]}  |  {mapt[1, 10]}  |  {mapt[1, 11]}  |  {mapt[1, 12]}  |  {mapt[1, 13]}  |  {mapt[1, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[2, 0]}  |  {mapt[2, 1]}  |  {mapt[2, 2]}  |  {mapt[2, 3]}  |  {mapt[2, 4]}  |  {mapt[2, 5]}  |  {mapt[2, 6]}  |  {mapt[2, 7]}  |  {mapt[2, 8]}  |  {mapt[2, 9]}  |  {mapt[2, 10]}  |  {mapt[2, 11]}  |  {mapt[2, 12]}  |  {mapt[2, 13]}  |  {mapt[2, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[3, 0]}  |  {mapt[3, 1]}  |  {mapt[3, 2]}  |  {mapt[3, 3]}  |  {mapt[3, 4]}  |  {mapt[3, 5]}  |  {mapt[3, 6]}  |  {mapt[3, 7]}  |  {mapt[3, 8]}  |  {mapt[3, 9]}  |  {mapt[3, 10]}  |  {mapt[3, 11]}  |  {mapt[3, 12]}  |  {mapt[3, 13]}  |  {mapt[3, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[4, 0]}  |  {mapt[4, 1]}  |  {mapt[4, 2]}  |  {mapt[4, 3]}  |  {mapt[4, 4]}  |  {mapt[4, 5]}  |  {mapt[4, 6]}  |  {mapt[4, 7]}  |  {mapt[4, 8]}  |  {mapt[4, 9]}  |  {mapt[4, 10]}  |  {mapt[4, 11]}  |  {mapt[4, 12]}  |  {mapt[4, 13]}  |  {mapt[4, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[5, 0]}  |  {mapt[5, 1]}  |  {mapt[5, 2]}  |  {mapt[5, 3]}  |  {mapt[5, 4]}  |  {mapt[5, 5]}  |  {mapt[5, 6]}  |  {mapt[5, 7]}  |  {mapt[5, 8]}  |  {mapt[5, 9]}  |  {mapt[5, 10]}  |  {mapt[5, 11]}  |  {mapt[5, 12]}  |  {mapt[5, 13]}  |  {mapt[5, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[6, 0]}  |  {mapt[6, 1]}  |  {mapt[6, 2]}  |  {mapt[6, 3]}  |  {mapt[6, 4]}  |  {mapt[6, 5]}  |  {mapt[6, 6]}  |  {mapt[6, 7]}  |  {mapt[6, 8]}  |  {mapt[6, 9]}  |  {mapt[6, 10]}  |  {mapt[6, 11]}  |  {mapt[6, 12]}  |  {mapt[6, 13]}  |  {mapt[6, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[7, 0]}  |  {mapt[7, 1]}  |  {mapt[7, 2]}  |  {mapt[7, 3]}  |  {mapt[7, 4]}  |  {mapt[7, 5]}  |  {mapt[7, 6]}  |  {mapt[7, 7]}  |  {mapt[7, 8]}  |  {mapt[7, 9]}  |  {mapt[7, 10]}  |  {mapt[7, 11]}  |  {mapt[7, 12]}  |  {mapt[7, 13]}  |  {mapt[7, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[8, 0]}  |  {mapt[8, 1]}  |  {mapt[8, 2]}  |  {mapt[8, 3]}  |  {mapt[8, 4]}  |  {mapt[8, 5]}  |  {mapt[8, 6]}  |  {mapt[8, 7]}  |  {mapt[8, 8]}  |  {mapt[8, 9]}  |  {mapt[8, 10]}  |  {mapt[8, 11]}  |  {mapt[8, 12]}  |  {mapt[8, 13]}  |  {mapt[8, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[9, 0]}  |  {mapt[9, 1]}  |  {mapt[9, 2]}  |  {mapt[9, 3]}  |  {mapt[9, 4]}  |  {mapt[9, 5]}  |  {mapt[9, 6]}  |  {mapt[9, 7]}  |  {mapt[9, 8]}  |  {mapt[9, 9]}  |  {mapt[9, 10]}  |  {mapt[9, 11]}  |  {mapt[9, 12]}  |  {mapt[9, 13]}  |  {mapt[9, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[10, 0]}  |  {mapt[10, 1]}  |  {mapt[10, 2]}  |  {mapt[10, 3]}  |  {mapt[10, 4]}  |  {mapt[10, 5]}  |  {mapt[10, 6]}  |  {mapt[10, 7]}  |  {mapt[10, 8]}  |  {mapt[10, 9]}  |  {mapt[10, 10]}  |  {mapt[10, 11]}  |  {mapt[10, 12]}  |  {mapt[10, 13]}  |  {mapt[10, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[11, 0]}  |  {mapt[11, 1]}  |  {mapt[11, 2]}  |  {mapt[11, 3]}  |  {mapt[11, 4]}  |  {mapt[11, 5]}  |  {mapt[11, 6]}  |  {mapt[11, 7]}  |  {mapt[11, 8]}  |  {mapt[11, 9]}  |  {mapt[11, 10]}  |  {mapt[11, 11]}  |  {mapt[11, 12]}  |  {mapt[11, 13]}  |  {mapt[11, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[12, 0]}  |  {mapt[12, 1]}  |  {mapt[12, 2]}  |  {mapt[12, 3]}  |  {mapt[12, 4]}  |  {mapt[12, 5]}  |  {mapt[12, 6]}  |  {mapt[12, 7]}  |  {mapt[12, 8]}  |  {mapt[12, 9]}  |  {mapt[12, 10]}  |  {mapt[12, 11]}  |  {mapt[12, 12]}  |  {mapt[12, 13]}  |  {mapt[12, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[13, 0]}  |  {mapt[13, 1]}  |  {mapt[13, 2]}  |  {mapt[13, 3]}  |  {mapt[13, 4]}  |  {mapt[13, 5]}  |  {mapt[13, 6]}  |  {mapt[13, 7]}  |  {mapt[13, 8]}  |  {mapt[13, 9]}  |  {mapt[13, 10]}  |  {mapt[13, 11]}  |  {mapt[13, 12]}  |  {mapt[13, 13]}  |  {mapt[13, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"|  {mapt[14, 0]}  |  {mapt[14, 1]}  |  {mapt[14, 2]}  |  {mapt[14, 3]}  |  {mapt[14, 4]}  |  {mapt[14, 5]}  |  {mapt[14, 6]}  |  {mapt[14, 7]}  |  {mapt[14, 8]}  |  {mapt[14, 9]}  |  {mapt[14, 10]}  |  {mapt[14, 11]}  |  {mapt[14, 12]}  |  {mapt[14, 13]}  |  {mapt[14, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
        }*/
    }
    /*
     *  public static void Plateauprincipale(string[,] mapt)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine($"-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"| {mapt[0, 0]} | {mapt[0, 1]} | {mapt[0, 2]} | {mapt[0, 3]} | {mapt[0, 4]} | {mapt[0, 5]} | {mapt[0, 6]} | {mapt[0, 7]} | {mapt[0, 8]} | {mapt[0, 9]} | {mapt[0, 10]} | {mapt[0, 11]} | {mapt[0, 12]} | {mapt[0, 13]} | {mapt[0, 14]} | {mapt[0, 15]} | {mapt[0, 16]} | {mapt[0, 17]} | {mapt[0, 18]} | {mapt[0, 19]} | {mapt[0, 20]} | {mapt[0, 21]} | {mapt[0, 22]} | {mapt[0, 23]} | {mapt[0, 24]} | {mapt[0, 25]} | {mapt[0, 26]} | {mapt[0, 27]} | {mapt[0, 28]} | {mapt[0, 29]} | {mapt[0, 30]} | {mapt[0, 31]} | {mapt[0, 32]} | {mapt[0, 33]} | {mapt[0, 34]} | {mapt[0, 35]} | {mapt[0, 36]} | {mapt[0, 37]} | {mapt[0, 38]} | {mapt[0, 39]} | {mapt[0, 40]} | {mapt[0, 41]} | {mapt[0, 42]} | {mapt[0, 43]} | {mapt[0, 44]} | {mapt[0, 45]} | {mapt[0, 46]} | {mapt[0, 47]} | {mapt[0, 48]} | {mapt[0, 49]} | {mapt[0, 50]} | {mapt[0, 51]} | {mapt[0, 52]} | {mapt[0, 53]} | {mapt[0, 54]} | {mapt[0, 55]} | {mapt[0, 56]} | {mapt[0, 57]} | {mapt[0, 58]} | {mapt[0, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[1, 0]} | {mapt[1, 1]} | {mapt[1, 2]} | {mapt[1, 3]} | {mapt[1, 4]} | {mapt[1, 5]} | {mapt[1, 6]} | {mapt[1, 7]} | {mapt[1, 8]} | {mapt[1, 9]} | {mapt[1, 10]} | {mapt[1, 11]} | {mapt[1, 12]} | {mapt[1, 13]} | {mapt[1, 14]} | {mapt[1, 15]} | {mapt[1, 16]} | {mapt[1, 17]} | {mapt[1, 18]} | {mapt[1, 19]} | {mapt[1, 20]} | {mapt[1, 21]} | {mapt[1, 22]} | {mapt[1, 23]} | {mapt[1, 24]} | {mapt[1, 25]} | {mapt[1, 26]} | {mapt[1, 27]} | {mapt[1, 28]} | {mapt[1, 29]} | {mapt[1, 30]} | {mapt[1, 31]} | {mapt[1, 32]} | {mapt[1, 33]} | {mapt[1, 34]} | {mapt[1, 35]} | {mapt[1, 36]} | {mapt[1, 37]} | {mapt[1, 38]} | {mapt[1, 39]} | {mapt[1, 40]} | {mapt[1, 41]} | {mapt[1, 42]} | {mapt[1, 43]} | {mapt[1, 44]} | {mapt[1, 45]} | {mapt[1, 46]} | {mapt[1, 47]} | {mapt[1, 48]} | {mapt[1, 49]} | {mapt[1, 50]} | {mapt[1, 51]} | {mapt[1, 52]} | {mapt[1, 53]} | {mapt[1, 54]} | {mapt[1, 55]} | {mapt[1, 56]} | {mapt[1, 57]} | {mapt[1, 58]} | {mapt[1, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[2, 0]} | {mapt[2, 1]} | {mapt[2, 2]} | {mapt[2, 3]} | {mapt[2, 4]} | {mapt[2, 5]} | {mapt[2, 6]} | {mapt[2, 7]} | {mapt[2, 8]} | {mapt[2, 9]} | {mapt[2, 10]} | {mapt[2, 11]} | {mapt[2, 12]} | {mapt[2, 13]} | {mapt[2, 14]} | {mapt[2, 15]} | {mapt[2, 16]} | {mapt[2, 17]} | {mapt[2, 18]} | {mapt[2, 19]} | {mapt[2, 20]} | {mapt[2, 21]} | {mapt[2, 22]} | {mapt[2, 23]} | {mapt[2, 24]} | {mapt[2, 25]} | {mapt[2, 26]} | {mapt[2, 27]} | {mapt[2, 28]} | {mapt[2, 29]} | {mapt[2, 30]} | {mapt[2, 31]} | {mapt[2, 32]} | {mapt[2, 33]} | {mapt[2, 34]} | {mapt[2, 35]} | {mapt[2, 36]} | {mapt[2, 37]} | {mapt[2, 38]} | {mapt[2, 39]} | {mapt[2, 40]} | {mapt[2, 41]} | {mapt[2, 42]} | {mapt[2, 43]} | {mapt[2, 44]} | {mapt[2, 45]} | {mapt[2, 46]} | {mapt[2, 47]} | {mapt[2, 48]} | {mapt[2, 49]} | {mapt[2, 50]} | {mapt[2, 51]} | {mapt[2, 52]} | {mapt[2, 53]} | {mapt[2, 54]} | {mapt[2, 55]} | {mapt[2, 56]} | {mapt[2, 57]} | {mapt[2, 58]} | {mapt[2, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[3, 0]} | {mapt[3, 1]} | {mapt[3, 2]} | {mapt[3, 3]} | {mapt[3, 4]} | {mapt[3, 5]} | {mapt[3, 6]} | {mapt[3, 7]} | {mapt[3, 8]} | {mapt[3, 9]} | {mapt[3, 10]} | {mapt[3, 11]} | {mapt[3, 12]} | {mapt[3, 13]} | {mapt[3, 14]} | {mapt[3, 15]} | {mapt[3, 16]} | {mapt[3, 17]} | {mapt[3, 18]} | {mapt[3, 19]} | {mapt[3, 20]} | {mapt[3, 21]} | {mapt[3, 22]} | {mapt[3, 23]} | {mapt[3, 24]} | {mapt[3, 25]} | {mapt[3, 26]} | {mapt[3, 27]} | {mapt[3, 28]} | {mapt[3, 29]} | {mapt[3, 30]} | {mapt[3, 31]} | {mapt[3, 32]} | {mapt[3, 33]} | {mapt[3, 34]} | {mapt[3, 35]} | {mapt[3, 36]} | {mapt[3, 37]} | {mapt[3, 38]} | {mapt[3, 39]} | {mapt[3, 40]} | {mapt[3, 41]} | {mapt[3, 42]} | {mapt[3, 43]} | {mapt[3, 44]} | {mapt[3, 45]} | {mapt[3, 46]} | {mapt[3, 47]} | {mapt[3, 48]} | {mapt[3, 49]} | {mapt[3, 50]} | {mapt[3, 51]} | {mapt[3, 52]} | {mapt[3, 53]} | {mapt[3, 54]} | {mapt[3, 55]} | {mapt[3, 56]} | {mapt[3, 57]} | {mapt[3, 58]} | {mapt[3, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[4, 0]} | {mapt[4, 1]} | {mapt[4, 2]} | {mapt[4, 3]} | {mapt[4, 4]} | {mapt[4, 5]} | {mapt[4, 6]} | {mapt[4, 7]} | {mapt[4, 8]} | {mapt[4, 9]} | {mapt[4, 10]} | {mapt[4, 11]} | {mapt[4, 12]} | {mapt[4, 13]} | {mapt[4, 14]} | {mapt[4, 15]} | {mapt[4, 16]} | {mapt[4, 17]} | {mapt[4, 18]} | {mapt[4, 19]} | {mapt[4, 20]} | {mapt[4, 21]} | {mapt[4, 22]} | {mapt[4, 23]} | {mapt[4, 24]} | {mapt[4, 25]} | {mapt[4, 26]} | {mapt[4, 27]} | {mapt[4, 28]} | {mapt[4, 29]} | {mapt[4, 30]} | {mapt[4, 31]} | {mapt[4, 32]} | {mapt[4, 33]} | {mapt[4, 34]} | {mapt[4, 35]} | {mapt[4, 36]} | {mapt[4, 37]} | {mapt[4, 38]} | {mapt[4, 39]} | {mapt[4, 40]} | {mapt[4, 41]} | {mapt[4, 42]} | {mapt[4, 43]} | {mapt[4, 44]} | {mapt[4, 45]} | {mapt[4, 46]} | {mapt[4, 47]} | {mapt[4, 48]} | {mapt[4, 49]} | {mapt[4, 50]} | {mapt[4, 51]} | {mapt[4, 52]} | {mapt[4, 53]} | {mapt[4, 54]} | {mapt[4, 55]} | {mapt[4, 56]} | {mapt[4, 57]} | {mapt[4, 58]} | {mapt[4, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[5, 0]} | {mapt[5, 1]} | {mapt[5, 2]} | {mapt[5, 3]} | {mapt[5, 4]} | {mapt[5, 5]} | {mapt[5, 6]} | {mapt[5, 7]} | {mapt[5, 8]} | {mapt[5, 9]} | {mapt[5, 10]} | {mapt[5, 11]} | {mapt[5, 12]} | {mapt[5, 13]} | {mapt[5, 14]} | {mapt[5, 15]} | {mapt[5, 16]} | {mapt[5, 17]} | {mapt[5, 18]} | {mapt[5, 19]} | {mapt[5, 20]} | {mapt[5, 21]} | {mapt[5, 22]} | {mapt[5, 23]} | {mapt[5, 24]} | {mapt[5, 25]} | {mapt[5, 26]} | {mapt[5, 27]} | {mapt[5, 28]} | {mapt[5, 29]} | {mapt[5, 30]} | {mapt[5, 31]} | {mapt[5, 32]} | {mapt[5, 33]} | {mapt[5, 34]} | {mapt[5, 35]} | {mapt[5, 36]} | {mapt[5, 37]} | {mapt[5, 38]} | {mapt[5, 39]} | {mapt[5, 40]} | {mapt[5, 41]} | {mapt[5, 42]} | {mapt[5, 43]} | {mapt[5, 44]} | {mapt[5, 45]} | {mapt[5, 46]} | {mapt[5, 47]} | {mapt[5, 48]} | {mapt[5, 49]} | {mapt[5, 50]} | {mapt[5, 51]} | {mapt[5, 52]} | {mapt[5, 53]} | {mapt[5, 54]} | {mapt[5, 55]} | {mapt[5, 56]} | {mapt[5, 57]} | {mapt[5, 58]} | {mapt[5, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[6, 0]} | {mapt[6, 1]} | {mapt[6, 2]} | {mapt[6, 3]} | {mapt[6, 4]} | {mapt[6, 5]} | {mapt[6, 6]} | {mapt[6, 7]} | {mapt[6, 8]} | {mapt[6, 9]} | {mapt[6, 10]} | {mapt[6, 11]} | {mapt[6, 12]} | {mapt[6, 13]} | {mapt[6, 14]} | {mapt[6, 15]} | {mapt[6, 16]} | {mapt[6, 17]} | {mapt[6, 18]} | {mapt[6, 19]} | {mapt[6, 20]} | {mapt[6, 21]} | {mapt[6, 22]} | {mapt[6, 23]} | {mapt[6, 24]} | {mapt[6, 25]} | {mapt[6, 26]} | {mapt[6, 27]} | {mapt[6, 28]} | {mapt[6, 29]} | {mapt[6, 30]} | {mapt[6, 31]} | {mapt[6, 32]} | {mapt[6, 33]} | {mapt[6, 34]} | {mapt[6, 35]} | {mapt[6, 36]} | {mapt[6, 37]} | {mapt[6, 38]} | {mapt[6, 39]} | {mapt[6, 40]} | {mapt[6, 41]} | {mapt[6, 42]} | {mapt[6, 43]} | {mapt[6, 44]} | {mapt[6, 45]} | {mapt[6, 46]} | {mapt[6, 47]} | {mapt[6, 48]} | {mapt[6, 49]} | {mapt[6, 50]} | {mapt[6, 51]} | {mapt[6, 52]} | {mapt[6, 53]} | {mapt[6, 54]} | {mapt[6, 55]} | {mapt[6, 56]} | {mapt[6, 57]} | {mapt[6, 58]} | {mapt[6, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[7, 0]} | {mapt[7, 1]} | {mapt[7, 2]} | {mapt[7, 3]} | {mapt[7, 4]} | {mapt[7, 5]} | {mapt[7, 6]} | {mapt[7, 7]} | {mapt[7, 8]} | {mapt[7, 9]} | {mapt[7, 10]} | {mapt[7, 11]} | {mapt[7, 12]} | {mapt[7, 13]} | {mapt[7, 14]} | {mapt[7, 15]} | {mapt[7, 16]} | {mapt[7, 17]} | {mapt[7, 18]} | {mapt[7, 19]} | {mapt[7, 20]} | {mapt[7, 21]} | {mapt[7, 22]} | {mapt[7, 23]} | {mapt[7, 24]} | {mapt[7, 25]} | {mapt[7, 26]} | {mapt[7, 27]} | {mapt[7, 28]} | {mapt[7, 29]} | {mapt[7, 30]} | {mapt[7, 31]} | {mapt[7, 32]} | {mapt[7, 33]} | {mapt[7, 34]} | {mapt[7, 35]} | {mapt[7, 36]} | {mapt[7, 37]} | {mapt[7, 38]} | {mapt[7, 39]} | {mapt[7, 40]} | {mapt[7, 41]} | {mapt[7, 42]} | {mapt[7, 43]} | {mapt[7, 44]} | {mapt[7, 45]} | {mapt[7, 46]} | {mapt[7, 47]} | {mapt[7, 48]} | {mapt[7, 49]} | {mapt[7, 50]} | {mapt[7, 51]} | {mapt[7, 52]} | {mapt[7, 53]} | {mapt[7, 54]} | {mapt[7, 55]} | {mapt[7, 56]} | {mapt[7, 57]} | {mapt[7, 58]} | {mapt[7, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[8, 0]} | {mapt[8, 1]} | {mapt[8, 2]} | {mapt[8, 3]} | {mapt[8, 4]} | {mapt[8, 5]} | {mapt[8, 6]} | {mapt[8, 7]} | {mapt[8, 8]} | {mapt[8, 9]} | {mapt[8, 10]} | {mapt[8, 11]} | {mapt[8, 12]} | {mapt[8, 13]} | {mapt[8, 14]} | {mapt[8, 15]} | {mapt[8, 16]} | {mapt[8, 17]} | {mapt[8, 18]} | {mapt[8, 19]} | {mapt[8, 20]} | {mapt[8, 21]} | {mapt[8, 22]} | {mapt[8, 23]} | {mapt[8, 24]} | {mapt[8, 25]} | {mapt[8, 26]} | {mapt[8, 27]} | {mapt[8, 28]} | {mapt[8, 29]} | {mapt[8, 30]} | {mapt[8, 31]} | {mapt[8, 32]} | {mapt[8, 33]} | {mapt[8, 34]} | {mapt[8, 35]} | {mapt[8, 36]} | {mapt[8, 37]} | {mapt[8, 38]} | {mapt[8, 39]} | {mapt[8, 40]} | {mapt[8, 41]} | {mapt[8, 42]} | {mapt[8, 43]} | {mapt[8, 44]} | {mapt[8, 45]} | {mapt[8, 46]} | {mapt[8, 47]} | {mapt[8, 48]} | {mapt[8, 49]} | {mapt[8, 50]} | {mapt[8, 51]} | {mapt[8, 52]} | {mapt[8, 53]} | {mapt[8, 54]} | {mapt[8, 55]} | {mapt[8, 56]} | {mapt[8, 57]} | {mapt[8, 58]} | {mapt[8, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[9, 0]} | {mapt[9, 1]} | {mapt[9, 2]} | {mapt[9, 3]} | {mapt[9, 4]} | {mapt[9, 5]} | {mapt[9, 6]} | {mapt[9, 7]} | {mapt[9, 8]} | {mapt[9, 9]} | {mapt[9, 10]} | {mapt[9, 11]} | {mapt[9, 12]} | {mapt[9, 13]} | {mapt[9, 14]} | {mapt[9, 15]} | {mapt[9, 16]} | {mapt[9, 17]} | {mapt[9, 18]} | {mapt[9, 19]} | {mapt[9, 20]} | {mapt[9, 21]} | {mapt[9, 22]} | {mapt[9, 23]} | {mapt[9, 24]} | {mapt[9, 25]} | {mapt[9, 26]} | {mapt[9, 27]} | {mapt[9, 28]} | {mapt[9, 29]} | {mapt[9, 30]} | {mapt[9, 31]} | {mapt[9, 32]} | {mapt[9, 33]} | {mapt[9, 34]} | {mapt[9, 35]} | {mapt[9, 36]} | {mapt[9, 37]} | {mapt[9, 38]} | {mapt[9, 39]} | {mapt[9, 40]} | {mapt[9, 41]} | {mapt[9, 42]} | {mapt[9, 43]} | {mapt[9, 44]} | {mapt[9, 45]} | {mapt[9, 46]} | {mapt[9, 47]} | {mapt[9, 48]} | {mapt[9, 49]} | {mapt[9, 50]} | {mapt[9, 51]} | {mapt[9, 52]} | {mapt[9, 53]} | {mapt[9, 54]} | {mapt[9, 55]} | {mapt[9, 56]} | {mapt[9, 57]} | {mapt[9, 58]} | {mapt[9, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[10, 0]} | {mapt[10, 1]} | {mapt[10, 2]} | {mapt[10, 3]} | {mapt[10, 4]} | {mapt[10, 5]} | {mapt[10, 6]} | {mapt[10, 7]} | {mapt[10, 8]} | {mapt[10, 9]} | {mapt[10, 10]} | {mapt[10, 11]} | {mapt[10, 12]} | {mapt[10, 13]} | {mapt[10, 14]} | {mapt[10, 15]} | {mapt[10, 16]} | {mapt[10, 17]} | {mapt[10, 18]} | {mapt[10, 19]} | {mapt[10, 20]} | {mapt[10, 21]} | {mapt[10, 22]} | {mapt[10, 23]} | {mapt[10, 24]} | {mapt[10, 25]} | {mapt[10, 26]} | {mapt[10, 27]} | {mapt[10, 28]} | {mapt[10, 29]} | {mapt[10, 30]} | {mapt[10, 31]} | {mapt[10, 32]} | {mapt[10, 33]} | {mapt[10, 34]} | {mapt[10, 35]} | {mapt[10, 36]} | {mapt[10, 37]} | {mapt[10, 38]} | {mapt[10, 39]} | {mapt[10, 40]} | {mapt[10, 41]} | {mapt[10, 42]} | {mapt[10, 43]} | {mapt[10, 44]} | {mapt[10, 45]} | {mapt[10, 46]} | {mapt[10, 47]} | {mapt[10, 48]} | {mapt[10, 49]} | {mapt[10, 50]} | {mapt[10, 51]} | {mapt[10, 52]} | {mapt[10, 53]} | {mapt[10, 54]} | {mapt[10, 55]} | {mapt[10, 56]} | {mapt[10, 57]} | {mapt[10, 58]} | {mapt[10, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[11, 0]} | {mapt[11, 1]} | {mapt[11, 2]} | {mapt[11, 3]} | {mapt[11, 4]} | {mapt[11, 5]} | {mapt[11, 6]} | {mapt[11, 7]} | {mapt[11, 8]} | {mapt[11, 9]} | {mapt[11, 10]} | {mapt[11, 11]} | {mapt[11, 12]} | {mapt[11, 13]} | {mapt[11, 14]} | {mapt[11, 15]} | {mapt[11, 16]} | {mapt[11, 17]} | {mapt[11, 18]} | {mapt[11, 19]} | {mapt[11, 20]} | {mapt[11, 21]} | {mapt[11, 22]} | {mapt[11, 23]} | {mapt[11, 24]} | {mapt[11, 25]} | {mapt[11, 26]} | {mapt[11, 27]} | {mapt[11, 28]} | {mapt[11, 29]} | {mapt[11, 30]} | {mapt[11, 31]} | {mapt[11, 32]} | {mapt[11, 33]} | {mapt[11, 34]} | {mapt[11, 35]} | {mapt[11, 36]} | {mapt[11, 37]} | {mapt[11, 38]} | {mapt[11, 39]} | {mapt[11, 40]} | {mapt[11, 41]} | {mapt[11, 42]} | {mapt[11, 43]} | {mapt[11, 44]} | {mapt[11, 45]} | {mapt[11, 46]} | {mapt[11, 47]} | {mapt[11, 48]} | {mapt[11, 49]} | {mapt[11, 50]} | {mapt[11, 51]} | {mapt[11, 52]} | {mapt[11, 53]} | {mapt[11, 54]} | {mapt[11, 55]} | {mapt[11, 56]} | {mapt[11, 57]} | {mapt[11, 58]} | {mapt[11, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[12, 0]} | {mapt[12, 1]} | {mapt[12, 2]} | {mapt[12, 3]} | {mapt[12, 4]} | {mapt[12, 5]} | {mapt[12, 6]} | {mapt[12, 7]} | {mapt[12, 8]} | {mapt[12, 9]} | {mapt[12, 10]} | {mapt[12, 11]} | {mapt[12, 12]} | {mapt[12, 13]} | {mapt[12, 14]} | {mapt[12, 15]} | {mapt[12, 16]} | {mapt[12, 17]} | {mapt[12, 18]} | {mapt[12, 19]} | {mapt[12, 20]} | {mapt[12, 21]} | {mapt[12, 22]} | {mapt[12, 23]} | {mapt[12, 24]} | {mapt[12, 25]} | {mapt[12, 26]} | {mapt[12, 27]} | {mapt[12, 28]} | {mapt[12, 29]} | {mapt[12, 30]} | {mapt[12, 31]} | {mapt[12, 32]} | {mapt[12, 33]} | {mapt[12, 34]} | {mapt[12, 35]} | {mapt[12, 36]} | {mapt[12, 37]} | {mapt[12, 38]} | {mapt[12, 39]} | {mapt[12, 40]} | {mapt[12, 41]} | {mapt[12, 42]} | {mapt[12, 43]} | {mapt[12, 44]} | {mapt[12, 45]} | {mapt[12, 46]} | {mapt[12, 47]} | {mapt[12, 48]} | {mapt[12, 49]} | {mapt[12, 50]} | {mapt[12, 51]} | {mapt[12, 52]} | {mapt[12, 53]} | {mapt[12, 54]} | {mapt[12, 55]} | {mapt[12, 56]} | {mapt[12, 57]} | {mapt[12, 58]} | {mapt[12, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[13, 0]} | {mapt[13, 1]} | {mapt[13, 2]} | {mapt[13, 3]} | {mapt[13, 4]} | {mapt[13, 5]} | {mapt[13, 6]} | {mapt[13, 7]} | {mapt[13, 8]} | {mapt[13, 9]} | {mapt[13, 10]} | {mapt[13, 11]} | {mapt[13, 12]} | {mapt[13, 13]} | {mapt[13, 14]} | {mapt[13, 15]} | {mapt[13, 16]} | {mapt[13, 17]} | {mapt[13, 18]} | {mapt[13, 19]} | {mapt[13, 20]} | {mapt[13, 21]} | {mapt[13, 22]} | {mapt[13, 23]} | {mapt[13, 24]} | {mapt[13, 25]} | {mapt[13, 26]} | {mapt[13, 27]} | {mapt[13, 28]} | {mapt[13, 29]} | {mapt[13, 30]} | {mapt[13, 31]} | {mapt[13, 32]} | {mapt[13, 33]} | {mapt[13, 34]} | {mapt[13, 35]} | {mapt[13, 36]} | {mapt[13, 37]} | {mapt[13, 38]} | {mapt[13, 39]} | {mapt[13, 40]} | {mapt[13, 41]} | {mapt[13, 42]} | {mapt[13, 43]} | {mapt[13, 44]} | {mapt[13, 45]} | {mapt[13, 46]} | {mapt[13, 47]} | {mapt[13, 48]} | {mapt[13, 49]} | {mapt[13, 50]} | {mapt[13, 51]} | {mapt[13, 52]} | {mapt[13, 53]} | {mapt[13, 54]} | {mapt[13, 55]} | {mapt[13, 56]} | {mapt[13, 57]} | {mapt[13, 58]} | {mapt[13, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[14, 0]} | {mapt[14, 1]} | {mapt[14, 2]} | {mapt[14, 3]} | {mapt[14, 4]} | {mapt[14, 5]} | {mapt[14, 6]} | {mapt[14, 7]} | {mapt[14, 8]} | {mapt[14, 9]} | {mapt[14, 10]} | {mapt[14, 11]} | {mapt[14, 12]} | {mapt[14, 13]} | {mapt[14, 14]} | {mapt[14, 15]} | {mapt[14, 16]} | {mapt[14, 17]} | {mapt[14, 18]} | {mapt[14, 19]} | {mapt[14, 20]} | {mapt[14, 21]} | {mapt[14, 22]} | {mapt[14, 23]} | {mapt[14, 24]} | {mapt[14, 25]} | {mapt[14, 26]} | {mapt[14, 27]} | {mapt[14, 28]} | {mapt[14, 29]} | {mapt[14, 30]} | {mapt[14, 31]} | {mapt[14, 32]} | {mapt[14, 33]} | {mapt[14, 34]} | {mapt[14, 35]} | {mapt[14, 36]} | {mapt[14, 37]} | {mapt[14, 38]} | {mapt[14, 39]} | {mapt[14, 40]} | {mapt[14, 41]} | {mapt[14, 42]} | {mapt[14, 43]} | {mapt[14, 44]} | {mapt[14, 45]} | {mapt[14, 46]} | {mapt[14, 47]} | {mapt[14, 48]} | {mapt[14, 49]} | {mapt[14, 50]} | {mapt[14, 51]} | {mapt[14, 52]} | {mapt[14, 53]} | {mapt[14, 54]} | {mapt[14, 55]} | {mapt[14, 56]} | {mapt[14, 57]} | {mapt[14, 58]} | {mapt[14, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[15, 0]} | {mapt[15, 1]} | {mapt[15, 2]} | {mapt[15, 3]} | {mapt[15, 4]} | {mapt[15, 5]} | {mapt[15, 6]} | {mapt[15, 7]} | {mapt[15, 8]} | {mapt[15, 9]} | {mapt[15, 10]} | {mapt[15, 11]} | {mapt[15, 12]} | {mapt[15, 13]} | {mapt[15, 14]} | {mapt[15, 15]} | {mapt[15, 16]} | {mapt[15, 17]} | {mapt[15, 18]} | {mapt[15, 19]} | {mapt[15, 20]} | {mapt[15, 21]} | {mapt[15, 22]} | {mapt[15, 23]} | {mapt[15, 24]} | {mapt[15, 25]} | {mapt[15, 26]} | {mapt[15, 27]} | {mapt[15, 28]} | {mapt[15, 29]} | {mapt[15, 30]} | {mapt[15, 31]} | {mapt[15, 32]} | {mapt[15, 33]} | {mapt[15, 34]} | {mapt[15, 35]} | {mapt[15, 36]} | {mapt[15, 37]} | {mapt[15, 38]} | {mapt[15, 39]} | {mapt[15, 40]} | {mapt[15, 41]} | {mapt[15, 42]} | {mapt[15, 43]} | {mapt[15, 44]} | {mapt[15, 45]} | {mapt[15, 46]} | {mapt[15, 47]} | {mapt[15, 48]} | {mapt[15, 49]} | {mapt[15, 50]} | {mapt[15, 51]} | {mapt[15, 52]} | {mapt[15, 53]} | {mapt[15, 54]} | {mapt[15, 55]} | {mapt[15, 56]} | {mapt[15, 57]} | {mapt[15, 58]} | {mapt[15, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+-------+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[16, 0]} | {mapt[16, 1]} | {mapt[16, 2]} | {mapt[16, 3]} | {mapt[16, 4]} | {mapt[16, 5]} | {mapt[16, 6]} | {mapt[16, 7]} | {mapt[16, 8]} | {mapt[16, 9]} | {mapt[16, 10]} | {mapt[16, 11]} | {mapt[16, 12]} | {mapt[16, 13]} | {mapt[16, 14]} | {mapt[16, 15]} | {mapt[16, 16]} | {mapt[16, 17]} | {mapt[16, 18]} | {mapt[16, 19]} | {mapt[16, 20]} | {mapt[16, 21]} | {mapt[16, 22]} | {mapt[16, 23]} | {mapt[16, 24]} | {mapt[16, 25]} | {mapt[16, 26]} | {mapt[16, 27]} | {mapt[16, 28]} | {mapt[16, 29]} | {mapt[16, 30]} | {mapt[16, 31]} | {mapt[16, 32]} | {mapt[16, 33]} | {mapt[16, 34]} | {mapt[16, 35]} | {mapt[1616, 36]} | {mapt[16, 37]} | {mapt[16, 38]} | {mapt[16, 39]} | {mapt[16, 40]} | {mapt[16, 41]} | {mapt[16, 42]} | {mapt[16, 43]} | {mapt[16, 44]} | {mapt[16, 45]} | {mapt[16, 46]} | {mapt[16, 47]} | {mapt[16, 48]} | {mapt[16, 49]} | {mapt[16, 50]} | {mapt[16, 51]} | {mapt[16, 52]} | {mapt[16, 53]} | {mapt[16, 54]} | {mapt[16, 55]} | {mapt[16, 56]} | {mapt[16, 57]} | {mapt[16, 58]} | {mapt[16, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+-------+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[17, 0]} | {mapt[17, 1]} | {mapt[17, 2]} | {mapt[17, 3]} | {mapt[17, 4]} | {mapt[17, 5]} | {mapt[17, 6]} | {mapt[17, 7]} | {mapt[17, 8]} | {mapt[17, 9]} | {mapt[17, 10]} | {mapt[17, 11]} | {mapt[17, 12]} | {mapt[17, 13]} | {mapt[17, 14]} | {mapt[17, 15]} | {mapt[17, 16]} | {mapt[17, 17]} | {mapt[17, 18]} | {mapt[17, 19]} | {mapt[17, 20]} | {mapt[17, 21]} | {mapt[17, 22]} | {mapt[17, 23]} | {mapt[17, 24]} | {mapt[17, 25]} | {mapt[17, 26]} | {mapt[17, 27]} | {mapt[17, 28]} | {mapt[17, 29]} | {mapt[17, 30]} | {mapt[17, 31]} | {mapt[17, 32]} | {mapt[17, 33]} | {mapt[17, 34]} | {mapt[17, 35]} | {mapt[1717, 36]} | {mapt[17, 37]} | {mapt[17, 38]} | {mapt[17, 39]} | {mapt[17, 40]} | {mapt[17, 41]} | {mapt[17, 42]} | {mapt[17, 43]} | {mapt[17, 44]} | {mapt[17, 45]} | {mapt[17, 46]} | {mapt[17, 47]} | {mapt[17, 48]} | {mapt[17, 49]} | {mapt[17, 50]} | {mapt[17, 51]} | {mapt[17, 52]} | {mapt[17, 53]} | {mapt[17, 54]} | {mapt[17, 55]} | {mapt[17, 56]} | {mapt[17, 57]} | {mapt[17, 58]} | {mapt[17, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+-------+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[18, 0]} | {mapt[18, 1]} | {mapt[18, 2]} | {mapt[18, 3]} | {mapt[18, 4]} | {mapt[18, 5]} | {mapt[18, 6]} | {mapt[18, 7]} | {mapt[18, 8]} | {mapt[18, 9]} | {mapt[18, 10]} | {mapt[18, 11]} | {mapt[18, 12]} | {mapt[18, 13]} | {mapt[18, 14]} | {mapt[18, 15]} | {mapt[18, 16]} | {mapt[18, 17]} | {mapt[18, 18]} | {mapt[18, 19]} | {mapt[18, 20]} | {mapt[18, 21]} | {mapt[18, 22]} | {mapt[18, 23]} | {mapt[18, 24]} | {mapt[18, 25]} | {mapt[18, 26]} | {mapt[18, 27]} | {mapt[18, 28]} | {mapt[18, 29]} | {mapt[18, 30]} | {mapt[18, 31]} | {mapt[18, 32]} | {mapt[18, 33]} | {mapt[18, 34]} | {mapt[18, 35]} | {mapt[1818, 36]} | {mapt[18, 37]} | {mapt[18, 38]} | {mapt[18, 39]} | {mapt[18, 40]} | {mapt[18, 41]} | {mapt[18, 42]} | {mapt[18, 43]} | {mapt[18, 44]} | {mapt[18, 45]} | {mapt[18, 46]} | {mapt[18, 47]} | {mapt[18, 48]} | {mapt[18, 49]} | {mapt[18, 50]} | {mapt[18, 51]} | {mapt[18, 52]} | {mapt[18, 53]} | {mapt[18, 54]} | {mapt[18, 55]} | {mapt[18, 56]} | {mapt[18, 57]} | {mapt[18, 58]} | {mapt[18, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+-------+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[19, 0]} | {mapt[19, 1]} | {mapt[19, 2]} | {mapt[19, 3]} | {mapt[19, 4]} | {mapt[19, 5]} | {mapt[19, 6]} | {mapt[19, 7]} | {mapt[19, 8]} | {mapt[19, 9]} | {mapt[19, 10]} | {mapt[19, 11]} | {mapt[19, 12]} | {mapt[19, 13]} | {mapt[19, 14]} | {mapt[19, 15]} | {mapt[19, 16]} | {mapt[19, 17]} | {mapt[19, 18]} | {mapt[19, 19]} | {mapt[19, 20]} | {mapt[19, 21]} | {mapt[19, 22]} | {mapt[19, 23]} | {mapt[19, 24]} | {mapt[19, 25]} | {mapt[19, 26]} | {mapt[19, 27]} | {mapt[19, 28]} | {mapt[19, 29]} | {mapt[19, 30]} | {mapt[19, 31]} | {mapt[19, 32]} | {mapt[19, 33]} | {mapt[19, 34]} | {mapt[19, 35]} | {mapt[1919, 36]} | {mapt[19, 37]} | {mapt[19, 38]} | {mapt[19, 39]} | {mapt[19, 40]} | {mapt[19, 41]} | {mapt[19, 42]} | {mapt[19, 43]} | {mapt[19, 44]} | {mapt[19, 45]} | {mapt[19, 46]} | {mapt[19, 47]} | {mapt[19, 48]} | {mapt[19, 49]} | {mapt[19, 50]} | {mapt[19, 51]} | {mapt[19, 52]} | {mapt[19, 53]} | {mapt[19, 54]} | {mapt[19, 55]} | {mapt[19, 56]} | {mapt[19, 57]} | {mapt[19, 58]} | {mapt[19, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+-------+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[20, 0]} | {mapt[20, 1]} | {mapt[20, 2]} | {mapt[20, 3]} | {mapt[20, 4]} | {mapt[20, 5]} | {mapt[20, 6]} | {mapt[20, 7]} | {mapt[20, 8]} | {mapt[20, 9]} | {mapt[20, 10]} | {mapt[20, 11]} | {mapt[20, 12]} | {mapt[20, 13]} | {mapt[20, 14]} | {mapt[20, 15]} | {mapt[20, 16]} | {mapt[20, 17]} | {mapt[20, 18]} | {mapt[20, 19]} | {mapt[20, 20]} | {mapt[20, 21]} | {mapt[20, 22]} | {mapt[20, 23]} | {mapt[20, 24]} | {mapt[20, 25]} | {mapt[20, 26]} | {mapt[20, 27]} | {mapt[20, 28]} | {mapt[20, 29]} | {mapt[20, 30]} | {mapt[20, 31]} | {mapt[20, 32]} | {mapt[20, 33]} | {mapt[20, 34]} | {mapt[20, 35]} | {mapt[2020, 36]} | {mapt[20, 37]} | {mapt[20, 38]} | {mapt[20, 39]} | {mapt[20, 40]} | {mapt[20, 41]} | {mapt[20, 42]} | {mapt[20, 43]} | {mapt[20, 44]} | {mapt[20, 45]} | {mapt[20, 46]} | {mapt[20, 47]} | {mapt[20, 48]} | {mapt[20, 49]} | {mapt[20, 50]} | {mapt[20, 51]} | {mapt[20, 52]} | {mapt[20, 53]} | {mapt[20, 54]} | {mapt[20, 55]} | {mapt[20, 56]} | {mapt[20, 57]} | {mapt[20, 58]} | {mapt[20, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+-------+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[21, 0]} | {mapt[21, 1]} | {mapt[21, 2]} | {mapt[21, 3]} | {mapt[21, 4]} | {mapt[21, 5]} | {mapt[21, 6]} | {mapt[21, 7]} | {mapt[21, 8]} | {mapt[21, 9]} | {mapt[21, 10]} | {mapt[21, 11]} | {mapt[21, 12]} | {mapt[21, 13]} | {mapt[21, 14]} | {mapt[21, 15]} | {mapt[21, 16]} | {mapt[21, 17]} | {mapt[21, 18]} | {mapt[21, 19]} | {mapt[21, 20]} | {mapt[21, 21]} | {mapt[21, 22]} | {mapt[21, 23]} | {mapt[21, 24]} | {mapt[21, 25]} | {mapt[21, 26]} | {mapt[21, 27]} | {mapt[21, 28]} | {mapt[21, 29]} | {mapt[21, 30]} | {mapt[21, 31]} | {mapt[21, 32]} | {mapt[21, 33]} | {mapt[21, 34]} | {mapt[21, 35]} | {mapt[2121, 36]} | {mapt[21, 37]} | {mapt[21, 38]} | {mapt[21, 39]} | {mapt[21, 40]} | {mapt[21, 41]} | {mapt[21, 42]} | {mapt[21, 43]} | {mapt[21, 44]} | {mapt[21, 45]} | {mapt[21, 46]} | {mapt[21, 47]} | {mapt[21, 48]} | {mapt[21, 49]} | {mapt[21, 50]} | {mapt[21, 51]} | {mapt[21, 52]} | {mapt[21, 53]} | {mapt[21, 54]} | {mapt[21, 55]} | {mapt[21, 56]} | {mapt[21, 57]} | {mapt[21, 58]} | {mapt[21, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+-------+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[22, 0]} | {mapt[22, 1]} | {mapt[22, 2]} | {mapt[22, 3]} | {mapt[22, 4]} | {mapt[22, 5]} | {mapt[22, 6]} | {mapt[22, 7]} | {mapt[22, 8]} | {mapt[22, 9]} | {mapt[22, 10]} | {mapt[22, 11]} | {mapt[22, 12]} | {mapt[22, 13]} | {mapt[22, 14]} | {mapt[22, 15]} | {mapt[22, 16]} | {mapt[22, 17]} | {mapt[22, 18]} | {mapt[22, 19]} | {mapt[22, 20]} | {mapt[22, 21]} | {mapt[22, 22]} | {mapt[22, 23]} | {mapt[22, 24]} | {mapt[22, 25]} | {mapt[22, 26]} | {mapt[22, 27]} | {mapt[22, 28]} | {mapt[22, 29]} | {mapt[22, 30]} | {mapt[22, 31]} | {mapt[22, 32]} | {mapt[22, 33]} | {mapt[22, 34]} | {mapt[22, 35]} | {mapt[2222, 36]} | {mapt[22, 37]} | {mapt[22, 38]} | {mapt[22, 39]} | {mapt[22, 40]} | {mapt[22, 41]} | {mapt[22, 42]} | {mapt[22, 43]} | {mapt[22, 44]} | {mapt[22, 45]} | {mapt[22, 46]} | {mapt[22, 47]} | {mapt[22, 48]} | {mapt[22, 49]} | {mapt[22, 50]} | {mapt[22, 51]} | {mapt[22, 52]} | {mapt[22, 53]} | {mapt[22, 54]} | {mapt[22, 55]} | {mapt[22, 56]} | {mapt[22, 57]} | {mapt[22, 58]} | {mapt[22, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+-------+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[23, 0]} | {mapt[23, 1]} | {mapt[23, 2]} | {mapt[23, 3]} | {mapt[23, 4]} | {mapt[23, 5]} | {mapt[23, 6]} | {mapt[23, 7]} | {mapt[23, 8]} | {mapt[23, 9]} | {mapt[23, 10]} | {mapt[23, 11]} | {mapt[23, 12]} | {mapt[23, 13]} | {mapt[23, 14]} | {mapt[23, 15]} | {mapt[23, 16]} | {mapt[23, 17]} | {mapt[23, 18]} | {mapt[23, 19]} | {mapt[23, 20]} | {mapt[23, 21]} | {mapt[23, 22]} | {mapt[23, 23]} | {mapt[23, 24]} | {mapt[23, 25]} | {mapt[23, 26]} | {mapt[23, 27]} | {mapt[23, 28]} | {mapt[23, 29]} | {mapt[23, 30]} | {mapt[23, 31]} | {mapt[23, 32]} | {mapt[23, 33]} | {mapt[23, 34]} | {mapt[23, 35]} | {mapt[2323, 36]} | {mapt[23, 37]} | {mapt[23, 38]} | {mapt[23, 39]} | {mapt[23, 40]} | {mapt[23, 41]} | {mapt[23, 42]} | {mapt[23, 43]} | {mapt[23, 44]} | {mapt[23, 45]} | {mapt[23, 46]} | {mapt[23, 47]} | {mapt[23, 48]} | {mapt[23, 49]} | {mapt[23, 50]} | {mapt[23, 51]} | {mapt[23, 52]} | {mapt[23, 53]} | {mapt[23, 54]} | {mapt[23, 55]} | {mapt[23, 56]} | {mapt[23, 57]} | {mapt[23, 58]} | {mapt[23, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+-------+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[24, 0]} | {mapt[24, 1]} | {mapt[24, 2]} | {mapt[24, 3]} | {mapt[24, 4]} | {mapt[24, 5]} | {mapt[24, 6]} | {mapt[24, 7]} | {mapt[24, 8]} | {mapt[24, 9]} | {mapt[24, 10]} | {mapt[24, 11]} | {mapt[24, 12]} | {mapt[24, 13]} | {mapt[24, 14]} | {mapt[24, 15]} | {mapt[24, 16]} | {mapt[24, 17]} | {mapt[24, 18]} | {mapt[24, 19]} | {mapt[24, 20]} | {mapt[24, 21]} | {mapt[24, 22]} | {mapt[24, 23]} | {mapt[24, 24]} | {mapt[24, 25]} | {mapt[24, 26]} | {mapt[24, 27]} | {mapt[24, 28]} | {mapt[24, 29]} | {mapt[24, 30]} | {mapt[24, 31]} | {mapt[24, 32]} | {mapt[24, 33]} | {mapt[24, 34]} | {mapt[24, 35]} | {mapt[2424, 36]} | {mapt[24, 37]} | {mapt[24, 38]} | {mapt[24, 39]} | {mapt[24, 40]} | {mapt[24, 41]} | {mapt[24, 42]} | {mapt[24, 43]} | {mapt[24, 44]} | {mapt[24, 45]} | {mapt[24, 46]} | {mapt[24, 47]} | {mapt[24, 48]} | {mapt[24, 49]} | {mapt[24, 50]} | {mapt[24, 51]} | {mapt[24, 52]} | {mapt[24, 53]} | {mapt[24, 54]} | {mapt[24, 55]} | {mapt[24, 56]} | {mapt[24, 57]} | {mapt[24, 58]} | {mapt[24, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+-------+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[25, 0]} | {mapt[25, 1]} | {mapt[25, 2]} | {mapt[25, 3]} | {mapt[25, 4]} | {mapt[25, 5]} | {mapt[25, 6]} | {mapt[25, 7]} | {mapt[25, 8]} | {mapt[25, 9]} | {mapt[25, 10]} | {mapt[25, 11]} | {mapt[25, 12]} | {mapt[25, 13]} | {mapt[25, 14]} | {mapt[25, 15]} | {mapt[25, 16]} | {mapt[25, 17]} | {mapt[25, 18]} | {mapt[25, 19]} | {mapt[25, 20]} | {mapt[25, 21]} | {mapt[25, 22]} | {mapt[25, 23]} | {mapt[25, 24]} | {mapt[25, 25]} | {mapt[25, 26]} | {mapt[25, 27]} | {mapt[25, 28]} | {mapt[25, 29]} | {mapt[25, 30]} | {mapt[25, 31]} | {mapt[25, 32]} | {mapt[25, 33]} | {mapt[25, 34]} | {mapt[25, 35]} | {mapt[2525, 36]} | {mapt[25, 37]} | {mapt[25, 38]} | {mapt[25, 39]} | {mapt[25, 40]} | {mapt[25, 41]} | {mapt[25, 42]} | {mapt[25, 43]} | {mapt[25, 44]} | {mapt[25, 45]} | {mapt[25, 46]} | {mapt[25, 47]} | {mapt[25, 48]} | {mapt[25, 49]} | {mapt[25, 50]} | {mapt[25, 51]} | {mapt[25, 52]} | {mapt[25, 53]} | {mapt[25, 54]} | {mapt[25, 55]} | {mapt[25, 56]} | {mapt[25, 57]} | {mapt[25, 58]} | {mapt[25, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+-------+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[26, 0]} | {mapt[26, 1]} | {mapt[26, 2]} | {mapt[26, 3]} | {mapt[26, 4]} | {mapt[26, 5]} | {mapt[26, 6]} | {mapt[26, 7]} | {mapt[26, 8]} | {mapt[26, 9]} | {mapt[26, 10]} | {mapt[26, 11]} | {mapt[26, 12]} | {mapt[26, 13]} | {mapt[26, 14]} | {mapt[26, 15]} | {mapt[26, 16]} | {mapt[26, 17]} | {mapt[26, 18]} | {mapt[26, 19]} | {mapt[26, 20]} | {mapt[26, 21]} | {mapt[26, 22]} | {mapt[26, 23]} | {mapt[26, 24]} | {mapt[26, 25]} | {mapt[26, 26]} | {mapt[26, 27]} | {mapt[26, 28]} | {mapt[26, 29]} | {mapt[26, 30]} | {mapt[26, 31]} | {mapt[26, 32]} | {mapt[26, 33]} | {mapt[26, 34]} | {mapt[26, 35]} | {mapt[2626, 36]} | {mapt[26, 37]} | {mapt[26, 38]} | {mapt[26, 39]} | {mapt[26, 40]} | {mapt[26, 41]} | {mapt[26, 42]} | {mapt[26, 43]} | {mapt[26, 44]} | {mapt[26, 45]} | {mapt[26, 46]} | {mapt[26, 47]} | {mapt[26, 48]} | {mapt[26, 49]} | {mapt[26, 50]} | {mapt[26, 51]} | {mapt[26, 52]} | {mapt[26, 53]} | {mapt[26, 54]} | {mapt[26, 55]} | {mapt[26, 56]} | {mapt[26, 57]} | {mapt[26, 58]} | {mapt[26, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+-------+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[27, 0]} | {mapt[27, 1]} | {mapt[27, 2]} | {mapt[27, 3]} | {mapt[27, 4]} | {mapt[27, 5]} | {mapt[27, 6]} | {mapt[27, 7]} | {mapt[27, 8]} | {mapt[27, 9]} | {mapt[27, 10]} | {mapt[27, 11]} | {mapt[27, 12]} | {mapt[27, 13]} | {mapt[27, 14]} | {mapt[27, 15]} | {mapt[27, 16]} | {mapt[27, 17]} | {mapt[27, 18]} | {mapt[27, 19]} | {mapt[27, 20]} | {mapt[27, 21]} | {mapt[27, 22]} | {mapt[27, 23]} | {mapt[27, 24]} | {mapt[27, 25]} | {mapt[27, 26]} | {mapt[27, 27]} | {mapt[27, 28]} | {mapt[27, 29]} | {mapt[27, 30]} | {mapt[27, 31]} | {mapt[27, 32]} | {mapt[27, 33]} | {mapt[27, 34]} | {mapt[27, 35]} | {mapt[2727, 36]} | {mapt[27, 37]} | {mapt[27, 38]} | {mapt[27, 39]} | {mapt[27, 40]} | {mapt[27, 41]} | {mapt[27, 42]} | {mapt[27, 43]} | {mapt[27, 44]} | {mapt[27, 45]} | {mapt[27, 46]} | {mapt[27, 47]} | {mapt[27, 48]} | {mapt[27, 49]} | {mapt[27, 50]} | {mapt[27, 51]} | {mapt[27, 52]} | {mapt[27, 53]} | {mapt[27, 54]} | {mapt[27, 55]} | {mapt[27, 56]} | {mapt[27, 57]} | {mapt[27, 58]} | {mapt[27, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+-------+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[28, 0]} | {mapt[28, 1]} | {mapt[28, 2]} | {mapt[28, 3]} | {mapt[28, 4]} | {mapt[28, 5]} | {mapt[28, 6]} | {mapt[28, 7]} | {mapt[28, 8]} | {mapt[28, 9]} | {mapt[28, 10]} | {mapt[28, 11]} | {mapt[28, 12]} | {mapt[28, 13]} | {mapt[28, 14]} | {mapt[28, 15]} | {mapt[28, 16]} | {mapt[28, 17]} | {mapt[28, 18]} | {mapt[28, 19]} | {mapt[28, 20]} | {mapt[28, 21]} | {mapt[28, 22]} | {mapt[28, 23]} | {mapt[28, 24]} | {mapt[28, 25]} | {mapt[28, 26]} | {mapt[28, 27]} | {mapt[28, 28]} | {mapt[28, 29]} | {mapt[28, 30]} | {mapt[28, 31]} | {mapt[28, 32]} | {mapt[28, 33]} | {mapt[28, 34]} | {mapt[28, 35]} | {mapt[2828, 36]} | {mapt[28, 37]} | {mapt[28, 38]} | {mapt[28, 39]} | {mapt[28, 40]} | {mapt[28, 41]} | {mapt[28, 42]} | {mapt[28, 43]} | {mapt[28, 44]} | {mapt[28, 45]} | {mapt[28, 46]} | {mapt[28, 47]} | {mapt[28, 48]} | {mapt[28, 49]} | {mapt[28, 50]} | {mapt[28, 51]} | {mapt[28, 52]} | {mapt[28, 53]} | {mapt[28, 54]} | {mapt[28, 55]} | {mapt[28, 56]} | {mapt[28, 57]} | {mapt[28, 58]} | {mapt[28, 59]} |");
            Console.WriteLine($"|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+---+---+---+---+---+---+---+---+---+---+---+---+---+---|---+-------+---+---+---+---+---+---+---+---+---+---+---+---|");
            Console.WriteLine($"| {mapt[29, 0]} | {mapt[29, 1]} | {mapt[29, 2]} | {mapt[29, 3]} | {mapt[29, 4]} | {mapt[29, 5]} | {mapt[29, 6]} | {mapt[29, 7]} | {mapt[29, 8]} | {mapt[29, 9]} | {mapt[29, 10]} | {mapt[29, 11]} | {mapt[29, 12]} | {mapt[29, 13]} | {mapt[29, 14]} | {mapt[29, 15]} | {mapt[29, 16]} | {mapt[29, 17]} | {mapt[29, 18]} | {mapt[29, 19]} | {mapt[29, 20]} | {mapt[29, 21]} | {mapt[29, 22]} | {mapt[29, 23]} | {mapt[29, 24]} | {mapt[29, 25]} | {mapt[29, 26]} | {mapt[29, 27]} | {mapt[29, 28]} | {mapt[29, 29]} | {mapt[29, 30]} | {mapt[29, 31]} | {mapt[29, 32]} | {mapt[29, 33]} | {mapt[29, 34]} | {mapt[29, 35]} | {mapt[2929, 36]} | {mapt[29, 37]} | {mapt[29, 38]} | {mapt[29, 39]} | {mapt[29, 40]} | {mapt[29, 41]} | {mapt[29, 42]} | {mapt[29, 43]} | {mapt[29, 44]} | {mapt[29, 45]} | {mapt[29, 46]} | {mapt[29, 47]} | {mapt[29, 48]} | {mapt[29, 49]} | {mapt[29, 50]} | {mapt[29, 51]} | {mapt[29, 52]} | {mapt[29, 53]} | {mapt[29, 54]} | {mapt[29, 55]} | {mapt[29, 56]} | {mapt[29, 57]} | {mapt[29, 58]} | {mapt[29, 59]} |");
            Console.WriteLine($"-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            Console.ResetColor();
        }
  
     */
}