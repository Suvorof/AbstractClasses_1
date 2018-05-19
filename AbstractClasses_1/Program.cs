using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses_1
{
    class Program
    {
        abstract class AbstractHandler
        {
            public abstract void Open();
            public abstract void Create();
            public abstract void Change();
            public abstract void Save();
        }

        class XMLHandler : AbstractHandler
        {
            public override void Change()
            {
                Console.WriteLine("Документ XML - изменён.");
            }

            public override void Create()
            {
                Console.WriteLine("Документ XML - создан.");
            }

            public override void Open()
            {
                Console.WriteLine("Документ XML - открыт.");
            }

            public override void Save()
            {
                Console.WriteLine("Документ XML - сохранён.");
            }
        }

        class TXTHandler : AbstractHandler
        {
            public override void Change()
            {
                Console.WriteLine("Документ TXT - изменён.");
            }

            public override void Create()
            {
                Console.WriteLine("Документ TXT - создан.");
            }

            public override void Open()
            {
                Console.WriteLine("Документ TXT - открыт.");
            }

            public override void Save()
            {
                Console.WriteLine("Документ TXT - сохранён.");
            }
        }

        class DOCHandler : AbstractHandler
        {
            public override void Change()
            {
                Console.WriteLine("Документ DOC - изменён.");
            }

            public override void Create()
            {
                Console.WriteLine("Документ DOC - создан.");
            }

            public override void Open()
            {
                Console.WriteLine("Документ DOC - открыт.");
            }

            public override void Save()
            {
                Console.WriteLine("Документ DOC - сохранён.");
            }
        }
        static void Main()
        {
            AbstractHandler xmlDocument = new XMLHandler();
            Console.WriteLine("Вы выбрали работу с документом типа XML:");
            xmlDocument.Create();
            xmlDocument.Open();
            xmlDocument.Change();
            xmlDocument.Save();
            Console.WriteLine("\n");

            AbstractHandler txtDocument = new TXTHandler();
            Console.WriteLine("Вы выбрали работу с документом типа TXT:");
            txtDocument.Create();
            txtDocument.Open();
            txtDocument.Change();
            txtDocument.Save();
            Console.WriteLine("\n");

            AbstractHandler docDocument = new DOCHandler();
            Console.WriteLine("Вы выбрали работу с документом типа DOC:");
            docDocument.Create();
            txtDocument.Open();
            docDocument.Change();
            docDocument.Save();

            // Delay
            Console.ReadKey();
        }
    }
}
