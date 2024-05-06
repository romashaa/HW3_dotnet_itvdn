using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ відкритий");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документа доступно тільки у версії Pro");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа доступно тільки у версії Pro");
        }
    }
}
