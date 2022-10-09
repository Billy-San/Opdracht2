using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Dieren
    {
        public int Gewicht { get; set; }

        private string Geluid { get; set; }
        private string Uitspraak { get; set; }


        protected Dieren()
        {
            this.Gewicht = 0;
            Uitspraak = "";
        }

        public string Zegt(string uitspraak)
        {
            this.Uitspraak = uitspraak;
            return uitspraak;

        }
    }
    internal class Snake : Dieren
    {
        public SoundPlayer SnakeSound;

        public Snake(int gewicht)
        {
            base.Gewicht = gewicht;
        }

        public string SoundMaker()
        {
            SnakeSound = new SoundPlayer(@"C:\Users\user\Downloads\snake.wav");
            SnakeSound.Play();
            return base.Zegt("SSSSS");
        }
        public override string ToString()
        {
            return SoundMaker();
        }
    }

    internal class Cow : Dieren
    {
        public SoundPlayer CowSound;

        public Cow(int gewicht)
        {
            base.Gewicht = gewicht;
        }

        public string SoundMaker()
        {
            CowSound = new SoundPlayer(@"C:\Users\user\Downloads\cow-moo1.wav");
            CowSound.Play();
            return base.Zegt("Meeuuuuuuh");
        }
        public override string ToString()
        {
            return SoundMaker();
        }
    }

    internal class Pig : Dieren
    {
        public SoundPlayer PigSound;

        public Pig(int gewicht)
        {
            base.Gewicht = gewicht;
        }

        public string SoundMaker()
        {
            PigSound = new SoundPlayer(@"C:\Users\user\Downloads\piggie.wav");
            PigSound.Play();
            return base.Zegt("ProigProig");
        }
        public override string ToString()
        {
            return SoundMaker();
        }

    }
}
