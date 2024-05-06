using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ClassRoom
    {
        private Pupil[] pupils;

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils = new Pupil[] { pupil1, pupil2, pupil3, pupil4 };
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils = new Pupil[] { pupil1, pupil2, pupil3 };
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupils = new Pupil[] { pupil1, pupil2 };
        }

        public void ShowClassInfo()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}:");
                Console.WriteLine("Study: ");
                pupils[i].Study();
                Console.WriteLine("Read: ");
                pupils[i].Read();
                Console.WriteLine("Write: ");
                pupils[i].Write();
                Console.WriteLine("Relax: ");
                pupils[i].Relax();
                Console.WriteLine();
            }
        }
    }
}
