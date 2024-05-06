using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excellent pupil is studying hard");
        }

        public override void Read()
        {
            Console.WriteLine("Excellent pupil reads a lot");
        }

        public override void Write()
        {
            Console.WriteLine("Excellent pupil writes well");
        }

        public override void Relax()
        {
            Console.WriteLine("Excellent pupil relaxes briefly");
        }
    }
}
