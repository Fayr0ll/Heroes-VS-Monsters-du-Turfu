using Heroes_VS_Monsters_du_Turfu.Classs.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Heroes_VS_Monsters_du_Turfu.Classs.Personnages
{
    public class Personnage
    {
        public int Gold;
        public int Cuir;
        public int Plastic;
        public int Id;
        public string Race;
        public string Description;
        public string Skin;
        public int Force;
        public int Def;
        public int Endu;
        public int Hp;
        public int Agi;
        public int Spec;
        public int Chance;
        public string Weapon;
        public int Poss;
        public int Puss;
        public bool Mort = false;
        public bool Boss = false;



        public int Pdvm(int degat)
        {
            int atak = Radomizer.DeTrois();
            if (atak == 2)
            {
                degat = 0;
                Console.WriteLine("Echec Critique");
            }
            if (atak == 3)
            {
                degat += 2;
                Console.WriteLine("Attaque boostée ! Vos dégats sont accrus !");
            }
            if (degat < 0) degat = 0;
            Hp -= degat;
            if (Hp <= 0) Mort = true;
            return degat;
        }

        public int Pdvh(int degat)
        {
            int atak = Radomizer.DeTrois();
            if (atak == 2)
            {
                degat = 0;
                Console.WriteLine("Echec Critique");
            }
            if (atak == 3)
            {
                degat += 2;
                Console.WriteLine("Attaque boostée ! Vos dégats sont accrus !");
            }
            if (degat < 0) degat = 0;
            Hp -= degat;
            if (Hp <= 0) Mort = true;
            return degat;
        }

        public void Drop(Monstre m, Hero h)
        {
            m.Gold = Radomizer.DeSix();
            h.Gold += m.Gold;
            m.Cuir = Radomizer.DeQuatre() / 2;
            h.Cuir += m.Cuir;
            m.Plastic = Radomizer.DeQuatre() / Radomizer.DeQuatre();
            h.Plastic += m.Plastic;
            Thread.Sleep(1000);
            Console.WriteLine($"Félicitation vous ramassez {m.Gold} ors, {m.Cuir} cuir(s) et {m.Plastic} plastique(s)");
            Thread.Sleep(1000);
            Console.WriteLine($"Vous avez grâce à celà {h.Gold} or(s) {h.Cuir} cuir(s) et {h.Plastic} plastique(s)");
            Thread.Sleep(1000);
        }
    }
}
