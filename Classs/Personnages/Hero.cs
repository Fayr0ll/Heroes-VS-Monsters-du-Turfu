using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Heroes_VS_Monsters_du_Turfu.Classs.Personnages
{
    public class Hero : Personnage
    {
        public string Pseudo {  get; set; }
        public int VictoireEtage = 0;
        public int Victoire = 0;
        public int VictoireTotale = 0;
        public int VicLoup = 0;
        public int VicCyc = 0;
        public int VicOrc = 0;
        public int QuestComplete = 0;
    }
}
