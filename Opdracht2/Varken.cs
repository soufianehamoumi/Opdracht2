using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    internal class Varken : Dier 
    {


        public SoundPlayer VarkensoundPlayer;
        public Varken(int Gewicht) : base(Gewicht)
        {

        }

        public string groink()
        {
            VarkensoundPlayer = new SoundPlayer(@"C:\Users\soufiane hamoumi\OneDrive\Documenten\programmeren 2022-2023\Net_dvanced\Opdracht2\Opdracht2\obj\pig.wav");
            VarkensoundPlayer.Play();
            return base.Zegt("groink");
        }

        public override string ToString()
        {
            return groink();
        }
    }
}
