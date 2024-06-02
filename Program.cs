using Heroes_VS_Monsters_du_Turfu.Classs.Actions;
using Heroes_VS_Monsters_du_Turfu.Classs.PicturesAndSounds;
using System.Media;
using System.Collections;
using System.Windows.Input;
using System.Text;

namespace Heroes_VS_Monsters_du_Turfu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Spawn.StartGame();
        }
    }
}