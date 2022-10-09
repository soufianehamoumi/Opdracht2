using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    internal class Koe : Dier

    {
        public SoundPlayer koesoundPlayer;

        public Koe(int Gewicht) : base(Gewicht)
        {

        }

        public string boe()
        {
            koesoundPlayer = new SoundPlayer(@"C:\Users\soufiane hamoumi\OneDrive\Documenten\programmeren 2022-2023\Net_dvanced\Opdracht2\Opdracht2\obj\moo.wav");
            koesoundPlayer.Play();
            return base.Zegt("boeee");
        }

        public override string ToString()
        {
            return boe();
        }


    }
}
