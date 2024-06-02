using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Diagnostics.CodeAnalysis;

namespace Heroes_VS_Monsters_du_Turfu.Classs.PicturesAndSounds
{
    [SuppressMessage("Interoperability", "CA1416:Valider la compatibilité de la plateforme", Justification = "<En attente>")]
    class SoundManager
    {
        public static readonly SoundManager Instance = new SoundManager();

        private readonly SoundPlayer _player;
        private bool _playing;

        private SoundManager()
        {
            _player = new SoundPlayer();
        }

        public void Play(string soundName)
        {
            if (_playing)
            {
                _player.Stop();
                _playing = false;
            }

            _player.SoundLocation = $@".\Sounds\{soundName}";
            _player.Play();
            _playing = true;
        }
    }
}
