using Heroes_VS_Monsters_du_Turfu.Classs.Personnages;
using Heroes_VS_Monsters_du_Turfu.Classs.PicturesAndSounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters_du_Turfu.Classs.Actions
{
    public static class DeplacementBoss
    {
            public static void Move(Hero h, string[,] mapt2, List<Monstre> monsters, List<Buisson> buissons, List<Arbre> arbres)
            {
                Thread.Sleep(1500);
                Console.WriteLine($"                                                                                Boss {h.VictoireTotale + 1}");
                Thread.Sleep(2000);
                ConsoleKeyInfo ckii;
                SoundManager.Instance.Play("Combat1.wav");
                int poss = 0;
                int puss = 0;
                int mAx = 14;
                Pictures picture = new Pictures();
                RenderboardPlateau(mapt2);
                h.VicLoup = 0;
                h.VicOrc = 0;
                h.VicCyc = 0;

                do
                {

                    ckii = Console.ReadKey();

                    mapt2[poss, puss] = " ";

                    switch (ckii.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (mapt2[poss, puss] == " " || mapt2[poss, puss] == "#" || mapt2[poss, puss] == "@")
                            {
                                if (puss == 0)
                                {
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Vous vous heurtez à un mur, le mieux serait d'ouvrir les yeux lors de vos déplacements.");
                                }
                                if (puss > 0)
                                {
                                    if (mapt2[poss, puss - 1] == "#")
                                    {
                                        Console.WriteLine("Ce buisson est trop épineux que pour le traverser, tentez de le contourner !");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    if (mapt2[poss, puss - 1] == "@")
                                    {
                                        Console.WriteLine("Un arbre vous barre la route... Ouvre les yeux !");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    puss--;
                                }

                            }
                            break;

                        case ConsoleKey.RightArrow:
                            if (mapt2[poss, puss] == " " || mapt2[poss, puss] == "#" || mapt2[poss, puss] == "@")
                            {
                                if (puss == mAx)
                                {
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Vous vous heurtez à un mur, le mieux serait d'ouvrir les yeux lors de vos déplacements.");
                                }
                                if (puss < mAx)
                                {
                                    if (mapt2[poss, puss + 1] == "#")
                                    {
                                        Console.WriteLine("Ce buisson est trop épineux que pour le traverser, tentez de le contourner !");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    if (mapt2[poss, puss + 1] == "@")
                                    {
                                        Console.WriteLine("Un arbre vous barre la route... Ouvre les yeux !");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    puss++;
                                }
                            }
                            break;

                        case ConsoleKey.UpArrow:
                            if (mapt2[poss, puss] == " " || mapt2[poss, puss] == "#" || mapt2[poss, puss] == "@")
                            {
                                if (poss == 0)
                                {
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Vous vous heurtez à un mur, le mieux serait d'ouvrir les yeux lors de vos déplacements.");
                                }
                                if (poss > 0)
                                {
                                    if (mapt2[poss - 1, puss] == "#")
                                    {
                                        Console.WriteLine("Ce buisson est trop épineux que pour le traverser, tentez de le contourner !");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    if (mapt2[poss - 1, puss] == "@")
                                    {
                                        Console.WriteLine("Un arbre vous barre la route... Ouvre les yeux !");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    poss--;
                                }
                            }
                            break;

                        case ConsoleKey.DownArrow:
                            if (mapt2[poss, puss] == " " || mapt2[poss, puss] == "#" || mapt2[poss, puss] == "@")
                            {
                                if (poss == mAx)
                                {
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Vous vous heurtez à un mur, le mieux serait d'ouvrir les yeux lors de vos déplacements.");
                                }
                                if (poss < mAx)
                                {
                                    if (mapt2[poss + 1, puss] == "#")
                                    {
                                        Console.WriteLine("Ce buisson est trop épineux que pour le traverser, tentez de le contourner !");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    if (mapt2[poss + 1, puss] == "@")
                                    {
                                        Console.WriteLine("Un arbre vous barre la route... Ouvre les yeux !");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    poss++;
                                }
                            }
                            break;


                        case ConsoleKey.Enter:
                            Console.Clear();
                            picture.RenderboardInventaire();
                            Console.WriteLine($"                                                                                               Votre Inventaire dispose de:");
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
                                    RenderboardPlateau(mapt2);
                                    break;
                                }
                                Console.WriteLine("Appuyer sur Enter semblait pourtant ne pas être compliqué");
                            } while (ckii.Key == ConsoleKey.Enter);
                            break;

                        case ConsoleKey.Escape:
                            Console.WriteLine(" Au revoir");
                            break;

                        default:
                            Console.WriteLine("Appuyer sur les Flèches Directionelles pour vous déplacer, Enter pour accéder à l'Inventaire/Pause et escape pour quitter");
                            break;

                    }
                    Console.Clear();
                    mapt2[poss, puss] = h.Skin;
                    Monstre ms;
                    h.Poss = poss;
                    h.Puss = puss;

                    if (h.Poss != mAx)
                    {
                        if (mapt2[h.Poss + 1, h.Puss] == "S" || mapt2[h.Poss + 1, h.Puss] == "B")
                        {
                            foreach (Monstre monstre in monsters)
                            {
                                if (monstre.Poss == h.Poss + 1 && monstre.Puss == h.Puss)
                                {
                                    mapt2[h.Poss + 1, h.Puss] = " ";
                                    ms = monstre;
                                    Combat.EnCombat(h, ms);
                                }
                            }
                        }
                    }

                    if (h.Poss != 0)
                    {
                        if (mapt2[h.Poss - 1, h.Puss] == "S" || mapt2[h.Poss - 1, h.Puss] == "B")
                        {
                            foreach (Monstre monstre in monsters)
                            {
                                if (monstre.Poss == h.Poss - 1 && monstre.Puss == h.Puss)
                                {
                                    mapt2[h.Poss - 1, h.Puss] = " ";
                                    ms = monstre;
                                    Combat.EnCombat(h, ms);
                                }
                            }
                        }
                    }

                    if (h.Puss != mAx)
                    {
                        if (mapt2[h.Poss, h.Puss + 1] == "S" || mapt2[h.Poss, h.Puss + 1] == "B")
                        {
                            foreach (Monstre monstre in monsters)
                            {
                                if (monstre.Puss == h.Puss + 1 && monstre.Poss == h.Poss)
                                {
                                    mapt2[h.Poss, h.Puss + 1] = " ";
                                    ms = monstre;
                                    Combat.EnCombat(h, ms);
                                }
                            }
                        }
                    }

                    if (h.Puss != 0)
                    {
                        if (mapt2[h.Poss, h.Puss - 1] == "S" || mapt2[h.Poss, h.Puss - 1] == "B")
                        {
                            foreach (Monstre monstre in monsters)
                            {
                                if (monstre.Puss == h.Puss - 1 && monstre.Poss == h.Poss)
                                {
                                    mapt2[h.Poss, h.Puss - 1] = " ";
                                    ms = monstre;
                                    Combat.EnCombat(h, ms);
                                }
                            }
                        }
                    }
                    RenderboardPlateau(mapt2);
                }
                while (ckii.Key != ConsoleKey.Escape && h.VictoireTotale != h.VictoireEtage);
            }
        public static void RenderboardPlateau(string[,] mapt2)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("-------------------------------------------------------------------------------------------                   ▄████████    ▄████████    ▄██████▄   ▄█          ▄████████    ▄████████                       ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                  ███    ███   ███    ███   ███    ███ ███         ███    ███   ███    ███                       ");
            Console.WriteLine($"|  {mapt2[0, 0]}  |  {mapt2[0, 1]}  |  {mapt2[0, 2]}  |  {mapt2[0, 3]}  |  {mapt2[0, 4]}  |  {mapt2[0, 5]}  |  {mapt2[0, 6]}  |  {mapt2[0, 7]}  |  {mapt2[0, 8]}  |  {mapt2[0, 9]}  |  {mapt2[0, 10]}  |  {mapt2[0, 11]}  |  {mapt2[0, 12]}  |  {mapt2[0, 13]}  |  {mapt2[0, 14]}  |                  ███    ███   ███    █▀    ███    █▀  ███         ███    █▀    ███    █▀                        ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                 ▄███▄▄▄▄██▀  ▄███▄▄▄      ▄███        ███        ▄███▄▄▄       ███                              ");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|                ▀▀███▀▀▀▀▀   ▀▀███▀▀▀     ▀▀███ ████▄  ███       ▀▀███▀▀▀     ▀███████████                       ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                ▀███████████   ███    █▄    ███    ███ ███         ███    █▄           ███                       ");
            Console.WriteLine($"|  {mapt2[1, 0]}  |  {mapt2[1, 1]}  |  {mapt2[1, 2]}  |  {mapt2[1, 3]}  |  {mapt2[1, 4]}  |  {mapt2[1, 5]}  |  {mapt2[1, 6]}  |  {mapt2[1, 7]}  |  {mapt2[1, 8]}  |  {mapt2[1, 9]}  |  {mapt2[1, 10]}  |  {mapt2[1, 11]}  |  {mapt2[1, 12]}  |  {mapt2[1, 13]}  |  {mapt2[1, 14]}  |                  ███    ███   ███    ███   ███    ███ ███▌    ▄   ███    ███    ▄█    ███                       ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                  ███    ███   ██████████   ████████▀  █████▄▄██   ██████████  ▄████████▀                        ");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|                  ███    ███                           ▀                                                         ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                                                                                                 ");
            Console.WriteLine($"|  {mapt2[2, 0]}  |  {mapt2[2, 1]}  |  {mapt2[2, 2]}  |  {mapt2[2, 3]}  |  {mapt2[2, 4]}  |  {mapt2[2, 5]}  |  {mapt2[2, 6]}  |  {mapt2[2, 7]}  |  {mapt2[2, 8]}  |  {mapt2[2, 9]}  |  {mapt2[2, 10]}  |  {mapt2[2, 11]}  |  {mapt2[2, 12]}  |  {mapt2[2, 13]}  |  {mapt2[2, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                                                                                                 ");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|       Règle n°1: Déplacez vous dans la grille grâce aux flèches directionelles ← ↑ ↓ → sur le clavier ! ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |       Règle n°2: Affrontez des Loups, Orcs, Cyclopes et Boss pour gravir les 100 étages du jeu !        ");
            Console.WriteLine($"|  {mapt2[3, 0]}  |  {mapt2[3, 1]}  |  {mapt2[3, 2]}  |  {mapt2[3, 3]}  |  {mapt2[3, 4]}  |  {mapt2[3, 5]}  |  {mapt2[3, 6]}  |  {mapt2[3, 7]}  |  {mapt2[3, 8]}  |  {mapt2[3, 9]}  |  {mapt2[3, 10]}  |  {mapt2[3, 11]}  |  {mapt2[3, 12]}  |  {mapt2[3, 13]}  |  {mapt2[3, 14]}  |       Règle n°3: Le seul moyen d'atteindre l'étage suivant est de battre le Boss !                      ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |       Règle n°4: Prenez un plaisir à massacrer vos adversaires sinon celà risque d'être long !          ");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|                                                                                                                 ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                                                                                                 ");
            Console.WriteLine($"|  {mapt2[4, 0]}  |  {mapt2[4, 1]}  |  {mapt2[4, 2]}  |  {mapt2[4, 3]}  |  {mapt2[4, 4]}  |  {mapt2[4, 5]}  |  {mapt2[4, 6]}  |  {mapt2[4, 7]}  |  {mapt2[4, 8]}  |  {mapt2[4, 9]}  |  {mapt2[4, 10]}  |  {mapt2[4, 11]}  |  {mapt2[4, 12]}  |  {mapt2[4, 13]}  |  {mapt2[4, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                                                                                                 ");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|                                                                                                                 ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                                                                                                 ");
            Console.WriteLine($"|  {mapt2[5, 0]}  |  {mapt2[5, 1]}  |  {mapt2[5, 2]}  |  {mapt2[5, 3]}  |  {mapt2[5, 4]}  |  {mapt2[5, 5]}  |  {mapt2[5, 6]}  |  {mapt2[5, 7]}  |  {mapt2[5, 8]}  |  {mapt2[5, 9]}  |  {mapt2[5, 10]}  |  {mapt2[5, 11]}  |  {mapt2[5, 12]}  |  {mapt2[5, 13]}  |  {mapt2[5, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                                                                                                 ");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|                                  ▄████████  ▄█  ████████▄     ▄████████                                         ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                  ███    ███ ███  ███   ▀███   ███    ███                                        ");
            Console.WriteLine($"|  {mapt2[6, 0]}  |  {mapt2[6, 1]}  |  {mapt2[6, 2]}  |  {mapt2[6, 3]}  |  {mapt2[6, 4]}  |  {mapt2[6, 5]}  |  {mapt2[6, 6]}  |  {mapt2[6, 7]}  |  {mapt2[6, 8]}  |  {mapt2[6, 9]}  |  {mapt2[6, 10]}  |  {mapt2[6, 11]}  |  {mapt2[6, 12]}  |  {mapt2[6, 13]}  |  {mapt2[6, 14]}  |                                  ███    ███ ███▌ ███    ███   ███    █▀                                         ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                  ███    ███ ███▌ ███    ███  ▄███▄▄▄                                            ");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|                                ▀███████████ ███▌ ███    ███ ▀▀███▀▀▀                                            ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                  ███    ███ ███  ███    ███   ███    █▄                                         ");
            Console.WriteLine($"|  {mapt2[7, 0]}  |  {mapt2[7, 1]}  |  {mapt2[7, 2]}  |  {mapt2[7, 3]}  |  {mapt2[7, 4]}  |  {mapt2[7, 5]}  |  {mapt2[7, 6]}  |  {mapt2[7, 7]}  |  {mapt2[7, 8]}  |  {mapt2[7, 9]}  |  {mapt2[7, 10]}  |  {mapt2[7, 11]}  |  {mapt2[7, 12]}  |  {mapt2[7, 13]}  |  {mapt2[7, 14]}  |                                  ███    ███ ███  ███   ▄███   ███    ███                                        ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                  ███    █▀  █▀   ████████▀    ██████████                                        ");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|                                                                                                                 ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                                                                                                 ");
            Console.WriteLine($"|  {mapt2[8, 0]}  |  {mapt2[8, 1]}  |  {mapt2[8, 2]}  |  {mapt2[8, 3]}  |  {mapt2[8, 4]}  |  {mapt2[8, 5]}  |  {mapt2[8, 6]}  |  {mapt2[8, 7]}  |  {mapt2[8, 8]}  |  {mapt2[8, 9]}  |  {mapt2[8, 10]}  |  {mapt2[8, 11]}  |  {mapt2[8, 12]}  |  {mapt2[8, 13]}  |  {mapt2[8, 14]}  |                                                                                                                 ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |       '@' = Arbre                                                                                               ");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|       '#' = Buisson                                                                                             ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                                                                                                 ");
            Console.WriteLine($"|  {mapt2[9, 0]}  |  {mapt2[9, 1]}  |  {mapt2[9, 2]}  |  {mapt2[9, 3]}  |  {mapt2[9, 4]}  |  {mapt2[9, 5]}  |  {mapt2[9, 6]}  |  {mapt2[9, 7]}  |  {mapt2[9, 8]}  |  {mapt2[9, 9]}  |  {mapt2[9, 10]}  |  {mapt2[9, 11]}  |  {mapt2[9, 12]}  |  {mapt2[9, 13]}  |  {mapt2[9, 14]}  |");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |       'S' = Sbire du Boss : Le plus vicieux monstre.                                                            ");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|       'B' = Boss alias 'L'Elfe de Sang' : Il est le GOAT des monstres, ni plus ni moins                         ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                            ");
            Console.WriteLine($"|  {mapt2[10, 0]}  |  {mapt2[10, 1]}  |  {mapt2[10, 2]}  |  {mapt2[10, 3]}  |  {mapt2[10, 4]}  |  {mapt2[10, 5]}  |  {mapt2[10, 6]}  |  {mapt2[10, 7]}  |  {mapt2[10, 8]}  |  {mapt2[10, 9]}  |  {mapt2[10, 10]}  |  {mapt2[10, 11]}  |  {mapt2[10, 12]}  |  {mapt2[10, 13]}  |  {mapt2[10, 14]}  |                                ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |       'D' = Hero : Demi Portion                                                                                 ");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|       'T' = Hero : TotoBlox                                                                                     ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |       'P' = Hero : TuK_Personne                                                                                 ");
            Console.WriteLine($"|  {mapt2[11, 0]}  |  {mapt2[11, 1]}  |  {mapt2[11, 2]}  |  {mapt2[11, 3]}  |  {mapt2[11, 4]}  |  {mapt2[11, 5]}  |  {mapt2[11, 6]}  |  {mapt2[11, 7]}  |  {mapt2[11, 8]}  |  {mapt2[11, 9]}  |  {mapt2[11, 10]}  |  {mapt2[11, 11]}  |  {mapt2[11, 12]}  |  {mapt2[11, 13]}  |  {mapt2[11, 14]}  |       'G' = Hero : Geek'Oh                                                                                      ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |       'V' = Hero : Vous, le Vagabond                                                                            ");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|                                                                                                                 ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |       Astuce n1° : Privilégiez les faibles monstres pour évoluer votre personnage                               ");
            Console.WriteLine($"|  {mapt2[12, 0]}  |  {mapt2[12, 1]}  |  {mapt2[12, 2]}  |  {mapt2[12, 3]}  |  {mapt2[12, 4]}  |  {mapt2[12, 5]}  |  {mapt2[12, 6]}  |  {mapt2[12, 7]}  |  {mapt2[12, 8]}  |  {mapt2[12, 9]}  |  {mapt2[12, 10]}  |  {mapt2[12, 11]}  |  {mapt2[12, 12]}  |  {mapt2[12, 13]}  |  {mapt2[12, 14]}  |       Astuce n°2 : Il y a des coffres par étage et peuvent être plus gros par chance                            ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |       Astuce n°3 : Le Boss sera toujours à votre opposé et toujours accessible contrairement à tout le reste    ");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|       Astuce n°4 : Tuez un maximum de monstre vous permettra d'achetez diverses avantages dans la boutique      ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |       Astuce n°5 : Appuyez sur Enter pour accédez au menu de pause et à la boutique                             ");
            Console.WriteLine($"|  {mapt2[13, 0]}  |  {mapt2[13, 1]}  |  {mapt2[13, 2]}  |  {mapt2[13, 3]}  |  {mapt2[13, 4]}  |  {mapt2[13, 5]}  |  {mapt2[13, 6]}  |  {mapt2[13, 7]}  |  {mapt2[13, 8]}  |  {mapt2[13, 9]}  |  {mapt2[13, 10]}  |  {mapt2[13, 11]}  |  {mapt2[13, 12]}  |  {mapt2[13, 13]}  |  {mapt2[13, 14]}  |       Astuce n°6 : Nulle besoin de 'Alt' + 'F4' pour fuir, prenez vos jambes à votre coups ou appuyer sur 'Esc' ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                                                                                                 ");
            Console.WriteLine("|-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----|                                                                                                                 ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                                                                                                 ");
            Console.WriteLine($"|  {mapt2[14, 0]}  |  {mapt2[14, 1]}  |  {mapt2[14, 2]}  |  {mapt2[14, 3]}  |  {mapt2[14, 4]}  |  {mapt2[14, 5]}  |  {mapt2[14, 6]}  |  {mapt2[14, 7]}  |  {mapt2[14, 8]}  |  {mapt2[14, 9]}  |  {mapt2[14, 10]}  |  {mapt2[14, 11]}  |  {mapt2[14, 12]}  |  {mapt2[14, 13]}  |  {mapt2[14, 14]}  |                                                                                                                 ");
            Console.WriteLine("|     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |                                                                                                                 ");
            Console.WriteLine("-------------------------------------------------------------------------------------------                                                                                                                 ");

            Console.ResetColor();
        }
    }
}
