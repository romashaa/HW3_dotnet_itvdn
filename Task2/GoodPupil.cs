using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil is studying regularly");
        }

        public override void Read()
        {
            Console.WriteLine("Good pupil reads enough");
        }

        public override void Write()
        {
            Console.WriteLine("Good pupil writes decently");
        }

        public override void Relax()
        {
            Console.WriteLine("Good pupil relaxes adequately");
        }
    }
}
