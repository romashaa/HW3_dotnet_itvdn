using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil avoids studying");
        }

        public override void Read()
        {
            Console.WriteLine("Bad pupil rarely reads");
        }

        public override void Write()
        {
            Console.WriteLine("Bad pupil struggles with writing");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad pupil relaxes excessively");
        }
    }
}
