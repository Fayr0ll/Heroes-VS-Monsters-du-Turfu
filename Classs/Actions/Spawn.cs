using Heroes_VS_Monsters_du_Turfu.Classs.Personnages;
using Heroes_VS_Monsters_du_Turfu.Classs.PicturesAndSounds;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;

namespace Heroes_VS_Monsters_du_Turfu.Classs.Actions
{
    public static class Spawn
    {

        public static void StartGame()
        {
            Console.ResetColor();
            Console.Clear();
            Pictures pictures = new Pictures();
            pictures.RenderboardTitle();
            pictures.RenderboardPressEnter();
            Hero h = NewHero();
            Pnj pn = new Pnj();
            Arbre a = new Arbre();
            Coffre c = new Coffre();
            Monstre m = new Monstre();
            Buisson b = new Buisson();
            Mur m1 = new Mur();
            Mur m2 = new Mur();
            string[,] mapt = new string[15, 45]
            {
                {$"{h.Skin}", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "}
            };
            List<Coffre> coffres = c.InitCoffre();
            List<Monstre> monsters = m.InitMonstre();
            List<Buisson> buissons1 = b.InitBuisson2();
            List<Arbre> arbres1 = a.InitArbre2();
            List<Pnj> pnjs = pn.InitPnj();
            //List<Mur> murs1 = m1.InitMur();
            //List<Mur> murs2 = m2.InitMur2();
            //SpawnMur1(mapt, murs1);
            //SpawnMur2(mapt, murs2);
            SpawnPnj(mapt, pnjs);
            SpawnBuisson2(mapt, buissons1);
            SpawnArbre2(mapt, arbres1);
            SpawnCoffre(mapt, coffres);
            SpawnMonstre(mapt, monsters);
            Deplacement.Move(h, mapt, monsters, buissons1, coffres, arbres1, pnjs);//, murs1, murs2);
            string[,] mapt2 = new string[15, 15]
            {
                { $"{h.Skin}", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "}
            };
            List<Arbre> arbres = a.InitArbre();
            List<Buisson> buissons = b.InitBuisson();
            List<Monstre> monstersB = m.InitMonstreBoss2();
            SpawnMonstreBoss(mapt2, monstersB);
            SpawnArbre(mapt2, arbres);
            SpawnBuisson(mapt2, buissons);
            DeplacementBoss.Move(h, mapt2, monstersB, buissons, arbres);
            Etage(h);
        }
        public static void Etage(Hero h)
        {
            Console.ResetColor();
            Console.Clear();
            Pnj pn = new Pnj();
            Arbre a = new Arbre();
            Coffre c = new Coffre();
            Monstre m = new Monstre();
            Buisson b = new Buisson();
            //Mur m1 = new Mur();
            //Mur m2 = new Mur();
            string[,] mapt = new string[15, 45]
            {
                {$"{h.Skin}", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "}
            };
            List<Coffre> coffres = c.InitCoffre();
            List<Monstre> monsters = m.InitMonstre();
            List<Buisson> buissons1 = b.InitBuisson2();
            List<Arbre> arbres1 = a.InitArbre2();
            List<Pnj> pnjs = pn.InitPnj();
            //List<Mur> murs1 = m1.InitMur();
            //List<Mur> murs2 = m2.InitMur2();
            //SpawnMur1(mapt, murs1);
            //SpawnMur2(mapt, murs2);
            SpawnPnj(mapt, pnjs);
            SpawnBuisson2(mapt, buissons1);
            SpawnArbre2(mapt, arbres1);
            SpawnCoffre(mapt, coffres);
            SpawnMonstre(mapt, monsters);
            Deplacement.Move(h, mapt, monsters, buissons1, coffres, arbres1, pnjs);//, murs1, murs2);
            string[,] mapt2 = new string[15, 15]
            {
                { $"{h.Skin}", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "},
                { " ", " ", " ", " ", " " , " ", " ", " ", " " , " ", " ", " ", " " , " ", " "}
            };
            List<Arbre> arbres = a.InitArbre();
            List<Buisson> buissons = b.InitBuisson();
            List<Monstre> monstersB = m.InitMonstreBoss(h);
            SpawnMonstreBoss(mapt2, monstersB);
            SpawnArbre(mapt2, arbres);
            SpawnBuisson(mapt2, buissons);
            DeplacementBoss.Move(h, mapt2, monstersB, buissons, arbres);
            if (h.VictoireTotale == 100) Victorius(h);
            else Etage(h);
        }
        public static Hero NewHero()
        {
            Pictures pic = new Pictures();
            Hero h = new Hero();
            ConsoleKeyInfo ckii;
            ckii = Console.ReadKey();
            Console.Clear();
            pic.RenderboardMJ();
            Thread.Sleep(1000);
            SoundManager.Instance.Play("Bonjour.wav");
            Console.WriteLine("                                                                                                       Bonjour et bienvenue !");
            Thread.Sleep(1000);
            Console.WriteLine("                                                                                                    Veuillez entrer votre Pseudo:");
            h.Pseudo = Console.ReadLine();
            Thread.Sleep(1000);
            Console.WriteLine($"                                                                                                         Enchanté {h.Pseudo} !");
            Thread.Sleep(1000);
            SoundManager.Instance.Play("SelectionH.wav");
            Scriptt.Règles();
            Thread.Sleep(2000);
            Console.Clear();
            bool choice = false;
            do
            {
                pic.RenderBoardSelectionH();
                ckii = Console.ReadKey();
                switch (ckii.Key)
                {
                    case ConsoleKey.NumPad1:
                        SoundManager.Instance.Play("DescriptionH1.wav");
                        pic.RenderboardToto();
                        Thread.Sleep(1000);
                        Console.WriteLine("                                      TotoBlox est un constructeur dans l'âme, il a un taux de réussite bien à lui. Son arme principale est le Baton et possède des statistiques équilibrées.");
                        Thread.Sleep(15000);
                        Console.WriteLine("                                                                                       Es-tu sure de vouloir TotoBlox ? ? Si oui, appuyes sur 1");
                        ckii = Console.ReadKey();
                        if (ckii.Key == ConsoleKey.NumPad1) 
                        { 
                            choice = true;
                            h.Race = "Blox";
                            h.Description = "TotoBlox est un constructeur dans l'âme, il a un taux de réussite bien à lui. Son arme principale est le Baton et possède des statistiques équilibrées.";
                            h.Weapon = "Baton";
                            h.Endu = 3;
                            h.Force = 8;
                            h.Def = 5 + (h.Endu * 2);
                            h.Hp = 25 + (h.Endu * 3);
                            h.Spec = 2;
                            h.Agi = 3;
                            h.Chance = 3;
                            h.Poss = 0;
                            h.Puss = 0;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            h.Skin = "T";
                            Console.ResetColor();
                            Thread.Sleep(1500);
                            Console.WriteLine($"                                                                                            Vous êtes {h.Pseudo} le {h.Race} ! Félicition");
                            Thread.Sleep(1500);
                        }
                        break;
                    case ConsoleKey.NumPad2:
                        SoundManager.Instance.Play("DescriptionH2.wav");
                        pic.RenderBoardCoco();
                        Thread.Sleep(1000);
                        Console.WriteLine("                              TuK_Personne Grand joueur de FPS, il a une justesse d'attaque élevée. Son arme principale est la souris filaire et possède une forte précision mais une faible endurance.");
                        Thread.Sleep(19000);
                        Console.WriteLine("                                                                                       Es-tu sure de vouloir TuK_Personne ? Si oui, appuyes sur 2");
                        ckii = Console.ReadKey();
                        if (ckii.Key == ConsoleKey.NumPad2)
                        {
                            choice = true;
                            h.Race = "TuK";
                            h.Description = "Grand joueur de FPS, il a une justesse d'attaque élevée. Son arme principale est la souris filaire et possède une forte précision mais une faible endurance.";
                            h.Weapon = "Baton";
                            h.Endu = 6;
                            h.Force = 6;
                            h.Def = 4 + (h.Endu * 2);
                            h.Hp = 27 + (h.Endu * 3);
                            h.Spec = 3;
                            h.Agi = 2;
                            h.Chance = 2;
                            h.Poss = 0;
                            h.Puss = 0;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            h.Skin = "P";
                            Console.ResetColor();
                            Thread.Sleep(1500);
                            Console.WriteLine($"                                                                                               Vous êtes {h.Pseudo} le {h.Race} ! Félicition");
                            Thread.Sleep(1500);
                        }
                        break;
                    case ConsoleKey.NumPad3:
                        SoundManager.Instance.Play("DescriptionH3.wav");
                        pic.RenderBoardGeekOh();
                        Thread.Sleep(1000);
                        Console.WriteLine("                Un lezard avec les yeux plus gros que le ventre, il ramasse plus de récompenses que les autres. Son arme est un Sabre sur un manche en corne de Licorne et possède pas mal d'endurance mais peu de force.  ");
                        Thread.Sleep(18000);
                        Console.WriteLine("                                                                                       Es-tu sure de vouloir TuK_Personne ? Si oui, appuyes sur 3");
                        ckii = Console.ReadKey();
                        if (ckii.Key == ConsoleKey.NumPad3)
                        {
                            choice = true;
                            h.Race = "Lezard Humanoïde";
                            h.Description = "Un lezard avec les yeux plus gros que le ventre, il ramasse plus de récompenses que les autres. Son arme est un Sabre sur un manche en corne de Licorne et possède pas mal d'endurance mais peu de force.";
                            h.Weapon = "Baton";
                            h.Endu = 4;
                            h.Force = 5;
                            h.Def = 4 + (h.Endu * 2);
                            h.Hp = 25 + (h.Endu * 3);
                            h.Spec = 1;
                            h.Agi = 6;
                            h.Chance = 2;
                            h.Poss = 0;
                            h.Puss = 0;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            h.Skin = "G";
                            Console.ResetColor();
                            Thread.Sleep(1500);
                            Console.WriteLine($"                                                                                            Vous êtes {h.Pseudo} le {h.Race} ! Félicition");
                            Thread.Sleep(1500);
                        }
                        break;
                    case ConsoleKey.NumPad0:
                        SoundManager.Instance.Play("DescriptionH0.wav");
                        pic.RenderBoardDP();
                        Thread.Sleep(1000);
                        Console.WriteLine("                                              Malgré qu'il est petit en apparance, *Tousse* Désolée... Il offre force et robustesse à son échelle... Attention que la marche est plus haute !");
                        Thread.Sleep(11000);
                        Console.WriteLine("                                                                                      Es-tu sure de vouloir être une Demi Portion ? Si oui, appuyes sur 0");
                        ckii = Console.ReadKey();
                        if (ckii.Key == ConsoleKey.NumPad0)
                        {
                            choice = true;
                            h.Race = "Demi Portion";
                            h.Description = "Malgré qu'il est petit en apparance, *Tousse* Désolée... Il offre force et robustesse à son échelle... Attention que la marche est plus haute !";
                            h.Weapon = "Hache";
                            h.Endu = 5;
                            h.Force = 7;
                            h.Def = 4 + (h.Endu * 2);
                            h.Hp = 30 + (h.Endu * 3);
                            h.Spec = 1;
                            h.Agi = 0;
                            h.Chance = 3;
                            h.Poss = 0;
                            h.Puss = 0;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            h.Skin = "D";
                            Console.ResetColor();
                            Thread.Sleep(1500);
                            Console.WriteLine($"                                                                                            Vous êtes {h.Pseudo} la {h.Race} ! Félicition");
                            Thread.Sleep(1500);
                        }
                        break;
                    case ConsoleKey.NumPad4:
                        SoundManager.Instance.Play("DescriptionH4.wav");
                        pic.RenderBoardVous();
                        Thread.Sleep(1000);
                        Console.WriteLine("                                           Toi qui cherche à te distraire, tu es comme tu es. Ta meilleure arme sera ton adaptation et tu possèdes les statistiques aléatoire... Bonne chance !");
                        Thread.Sleep(11000);
                        Console.WriteLine("                                                                                          Es-tu sure de vouloir être toi ? Si oui, appuyes sur 4");
                        ckii = Console.ReadKey();
                        if (ckii.Key == ConsoleKey.NumPad4)
                        {
                            choice = true;
                            h.Race = "Vagabond";
                            h.Description = "Toi qui cherche à te distraire, tu es comme tu es. Ta meilleure arme sera ton adaptation et tu possèdes les statistiques aléatoire... Bonne chance !";
                            h.Weapon = "Baton";
                            h.Endu = Radomizer.DeSix();
                            h.Force = Radomizer.DeQuatre() + Radomizer.DeSix();
                            h.Def = Radomizer.DeSix() + (h.Endu * 2);
                            h.Hp = (3 * Radomizer.DeSix()) + (h.Endu * 3);
                            h.Spec = Radomizer.DeSix();
                            h.Agi = Radomizer.DeSix();
                            h.Chance = Radomizer.DeSix();
                            h.Poss = 0;
                            h.Puss = 0;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            h.Skin = "V";
                            Console.ResetColor();
                            Thread.Sleep(1500);
                            Console.WriteLine($"                                                                                     Vous êtes {h.Pseudo} le {h.Race} ! Félicition");
                            Thread.Sleep(1500);
                        }
                        break;
                    default:
                        Console.WriteLine("Je pensais que 4 touches n'étaient pas un si grand nombre... Même un troll arriverait à choisir son héro...");
                        break;
                }
                Console.Clear();
            } while ( !choice );
            return h;
        }
        public static string[,] SpawnMonstre(string[,] mapt, List<Monstre> monsters)
        {
            Random random = new Random();
            bool NotFree = false;

            foreach (Monstre m in monsters)
            {
                do
                {
                    switch (m.Race)
                    {
                        case "Loup":

                            NotFree = false;
                            int poss = random.Next(7, 15);
                            int puss = random.Next(1, 15);

                            if (mapt[poss, puss] != " ")
                            {
                                NotFree = true;
                            }
                            if (!NotFree)
                            {
                                mapt[poss, puss] = m.Skin;
                                m.Poss = poss;
                                m.Puss = puss;
                            }
                            break;
                        case "Orc":

                            NotFree = false;
                            poss = random.Next(1, 15);
                            puss = random.Next(15, 32);

                            if (mapt[poss, puss] != " ")
                            {
                                NotFree = true;
                            }
                            if (!NotFree)
                            {
                                mapt[poss, puss] = m.Skin;
                                m.Poss = poss;
                                m.Puss = puss;
                            }
                            break;
                        case "Cyclope":

                            NotFree = false;
                            poss = random.Next(1, 15);
                            puss = random.Next(31, 45);

                            if (mapt[poss, puss] != " ")
                            {
                                NotFree = true;
                            }
                            if (!NotFree)
                            {
                                mapt[poss, puss] = m.Skin;
                                m.Poss = poss;
                                m.Puss = puss;
                            }
                            break;
                    }
                } while (NotFree);
            }
            return mapt;
        }
        public static string[,] SpawnMonstreBoss(string[,] mapt2, List<Monstre> monstersB)
        {
            Random random = new Random();
            bool NotFree;

            foreach (Monstre m in monstersB)
            {
                do
                {
                    if (m.Boss == true)
                    {
                        NotFree = false;
                        m.Poss = 14;
                        m.Puss = 14;
                        mapt2[14, 14] = m.Skin;
                    }
                    else
                    {
                        NotFree = false;
                        int poss = random.Next(2, 13);
                        int puss = random.Next(2, 13);

                        if (mapt2[poss, puss] != " ")
                        {
                            NotFree = true;
                        }
                        if (!NotFree)
                        {
                            mapt2[poss, puss] = m.Skin;
                            m.Poss = poss;
                            m.Puss = puss;
                        }
                    }
                } while (NotFree);
            }
            return mapt2;
        }
        public static string[,] SpawnBuisson(string[,] mapt, List<Buisson> buissons)
        {
            Random random = new Random();
            bool NotFree;

            foreach (Buisson b in buissons)
            {
                do
                {

                    NotFree = false;
                    int poss = random.Next(2, 14);
                    int puss = random.Next(2, 14);

                    if (mapt[poss, puss] != " ")
                    {
                        NotFree = true;
                    }
                    if (!NotFree)
                    {
                        mapt[poss, puss] = b.Skin;
                        b.Poss = poss;
                        b.Puss = puss;
                    }
                } while (NotFree);
            }
            return mapt;
        }
        public static void Victorius(Hero h)
        {
            Pictures p = new Pictures();
            p.RenderboardWin();
            Thread.Sleep(5000);
            p.RenderboardGenerique();
            Thread.Sleep(1000);
            Console.WriteLine("                                                                                           T'as Vaincu l'Elfe de Sang !");
            Thread.Sleep(1000);
            Console.WriteLine("                                                                                   Tu as donc gagner... Le droit de recommencer");
            Thread.Sleep(5000);
            StartGame();
        }
        public static string[,] SpawnCoffre(string[,] mapt, List<Coffre> coffres)
        {
            Random random = new Random();
            bool NotFree;

            foreach (Coffre cc in coffres)
            {
                do
                {
                    NotFree = false;
                    int poss = random.Next(1, 15);
                    if (poss < 5)
                    {
                        int puss = random.Next(7, 44);
                        if (mapt[poss, puss] != " ")
                        {
                            NotFree = true;
                        }
                        if (!NotFree)
                        {
                            mapt[poss, puss] = cc.Skin;
                            cc.Poss = poss;
                            cc.Puss = puss;
                        }
                    }
                    if (poss > 6)
                    {
                        int puss = random.Next(1, 44);
                        if (mapt[poss, puss] != " ")
                        {
                            NotFree = true;
                        }
                        if (!NotFree)
                        {
                            mapt[poss, puss] = cc.Skin;
                            cc.Poss = poss;
                            cc.Puss = puss;
                        }
                    }
                } while (NotFree);
            }
            return mapt;
        }
        public static string[,] SpawnArbre(string[,] mapt, List<Arbre> arbres)
        {
            Random random = new Random();
            bool NotFree;

            foreach (Arbre aa in arbres)
            {
                do
                {

                    NotFree = false;
                    int poss = random.Next(2, 14);
                    int puss = random.Next(2, 14);

                    if (mapt[poss, puss] != " ")
                    {
                        NotFree = true;
                    }
                    if (!NotFree)
                    {
                        mapt[poss, puss] = aa.Skin;
                        aa.Poss = poss;
                        aa.Puss = puss;
                    }
                } while (NotFree);
            }
            return mapt;
        }
        public static string[,] SpawnArbre2(string[,] mapt, List<Arbre> arbres)
        {
            Random random = new Random();
            bool NotFree;

            foreach (Arbre aa in arbres)
            {
                do
                {

                    NotFree = false;
                    int poss = random.Next(1, 15);
                    if (poss < 5)
                    {
                        int puss = random.Next(7, 44);
                        if (mapt[poss, puss] != " ")
                        {
                            NotFree = true;
                        }
                        if (!NotFree)
                        {
                            mapt[poss, puss] = aa.Skin;
                            aa.Poss = poss;
                            aa.Puss = puss;
                        }
                    }
                    if (poss > 6)
                    {
                        int puss = random.Next(1, 44);
                        if (mapt[poss, puss] != " ")
                        {
                            NotFree = true;
                        }
                        if (!NotFree)
                        {
                            mapt[poss, puss] = aa.Skin;
                            aa.Poss = poss;
                            aa.Puss = puss;
                        }
                    }
                } while (NotFree);
            }
            return mapt;
        }
        public static string[,] SpawnBuisson2(string[,] mapt, List<Buisson> buissons)
        {
            Random random = new Random();
            bool NotFree;

            foreach (Buisson buisson in buissons)
            {
                do
                {

                    NotFree = false;
                    int poss = random.Next(1, 15);
                    if (poss < 5)
                    {
                        int puss = random.Next(7, 44);
                        if (mapt[poss, puss] != " ")
                        {
                            NotFree = true;
                        }
                        if (!NotFree)
                        {
                            mapt[poss, puss] = buisson.Skin;
                            buisson.Poss = poss;
                            buisson.Puss = puss;
                        }
                    }
                    if (poss > 6)
                    {
                        int puss = random.Next(1, 44);
                        if (mapt[poss, puss] != " ")
                        {
                            NotFree = true;
                        }
                        if (!NotFree)
                        {
                            mapt[poss, puss] = buisson.Skin;
                            buisson.Poss = poss;
                            buisson.Puss = puss;
                        }
                    }
                } while (NotFree);
            }
            return mapt;
        }
        public static string[,] SpawnPnj(string[,] mapt, List<Pnj> pn)
        {
            Random random = new Random();
            bool NotFree;

            foreach (Pnj p in pn)
            {
                do
                {

                    NotFree = false;
                    int poss = random.Next(1, 4);
                    int puss = random.Next(1, 4);

                    if (mapt[poss, puss] != " ")
                    {
                        NotFree = true;
                    }
                    if (!NotFree)
                    {
                        mapt[poss, puss] = p.Skin;
                        p.Poss = poss;
                        p.Puss = puss;
                    }
                } while (NotFree);
            }
            return mapt;
        }
        public static string[,] SpawnMur1(string[,] mapt, List<Mur> murs)
        {
            Random random = new Random();
            bool NotFree;

            foreach (Mur mu in murs)
            {
                do
                {

                    NotFree = false;
                    int poss = random.Next(1, 5);
                    int puss = 6;

                    if (mapt[poss, puss] != " ")
                    {
                        NotFree = true;
                    }
                    if (!NotFree)
                    {
                        mapt[poss, puss] = mu.Skin;
                        mu.Poss = poss;
                        mu.Puss = puss;
                    }
                } while (NotFree);
            }
            return mapt;
        }
        public static string[,] SpawnMur2(string[,] mapt, List<Mur> murs)
        {
            Random random = new Random();
            bool NotFree;

            foreach (Mur mu in murs)
            {
                do
                {

                    NotFree = false;
                    int puss = random.Next(1, 5);
                    int poss = 6;

                    if (mapt[poss, puss] != " ")
                    {
                        NotFree = true;
                    }
                    if (!NotFree)
                    {
                        mapt[poss, puss] = mu.Skin;
                        mu.Poss = poss;
                        mu.Puss = puss;
                    }
                } while (NotFree);
            }
            return mapt;
        }
    }
}
