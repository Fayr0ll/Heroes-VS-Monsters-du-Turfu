using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Heroes_VS_Monsters_du_Turfu.Classs.Actions
{
    public static class Radomizer
    {
        public static int DeTrois()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }
        public static int DeQuatre()
        {
            Random random = new Random();
            return random.Next(1,5);
        }
        public static int DeSix()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
    /*En Cas QUE*/
    /*do
            {
                Console.WriteLine("                                                                                                   Voici donc les 4 Héros disponibles:");
                Thread.Sleep(1000);
                SoundManager.Instance.Play("DescriptionH1.wav");
                pic.RenderboardToto();
                Thread.Sleep(1000);
                Console.WriteLine("                                      TotoBlox est un constructeur dans l'âme, il a un taux de réussite bien à lui. Son arme principale est le Baton et possède des statistiques équilibrées.");
                Thread.Sleep(8000);
                Console.Clear();
                SoundManager.Instance.Play("DescriptionH2.wav");
                pic.RenderBoardCoco();
                Thread.Sleep(1000);
                Console.WriteLine("                              TuK_Personne Grand joueur de FPS, il a une justesse d'attaque élevée. Son arme principale est la souris filaire et possède une forte précision mais une faible endurance.");
                Thread.Sleep(8000);
                Console.Clear();
                SoundManager.Instance.Play("DescriptionH3.wav");
                pic.RenderBoardGeekOh();
                Thread.Sleep(1000);
                Console.WriteLine("                Un lezard avec les yeux plus gros que le ventre, il ramasse plus de récompenses que les autres. Son arme est un Sabre sur un manche en corne de Licorne et possède pas mal d'endurance mais peu de force.  ");
                Thread.Sleep(8000);
                Console.Clear();
                SoundManager.Instance.Play("DescriptionH4.wav");
                pic.RenderBoardVous();
                Thread.Sleep(1000);
                Console.WriteLine("                                           Toi qui cherche à te distraire, tu es comme tu es. Ta meilleure arme sera ton adaptation et tu possèdes les statistiques aléatoire... Bonne chance !");
                Thread.Sleep(8000);
                Console.Clear();
                Console.WriteLine("                                                                                   Veuillez utiliser le pavé numérique pour définir votre choix");
                ckii = Console.ReadKey();
            }while (ckii.Key == ConsoleKey.D1 || ckii.Key == ConsoleKey.D2 || ckii.Key == ConsoleKey.D3 || ckii.Key == ConsoleKey.D4);*/
}
