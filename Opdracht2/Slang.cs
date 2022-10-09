using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    internal class Slang : Dier
    {

        public SoundPlayer SlangsoundPlayer;
        public Slang(int Gewicht) : base(Gewicht)
        {

        }

        public string ssj()
        {
            SlangsoundPlayer = new SoundPlayer(@"C:\Users\soufiane hamoumi\OneDrive\Documenten\programmeren 2022-2023\Net_dvanced\Opdracht2\Opdracht2\obj\sssj.wav");
            SlangsoundPlayer.Play();
            return base.Zegt("sssjj");
        }

        public override string ToString()
        {
            return ssj();
        }


    }
}
