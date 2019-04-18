using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR7HW
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName=null;
            string causeVisit=null;
            string indetityNumber=null;
            Console.WriteLine("Нажмите два раза пробел чтобы зафиксировать время входа");
            ConsoleKeyInfo pressed;
            DateTime now = DateTime.Today;
            pressed = Console.ReadKey();
            if(Console.ReadKey(true).Key==ConsoleKey.Spacebar)
            {
                now = DateTime.Now;
            }
          
            bool fullInfo = true;

            Console.WriteLine("Введите Имя посетителя");
            fullName = Console.ReadLine();
            while (fullInfo)
            {
                if (String.IsNullOrEmpty(fullName) || fullName == "\n")
                {
                    Console.WriteLine("ОШИБКА! Введите Имя");
                    fullName = Console.ReadLine();

                }
                else
                    fullInfo = false;
            }
            //-------------------------------------------------------------------------
            Console.WriteLine("Введите причину посещения ");
           causeVisit = Console.ReadLine();
            while (!fullInfo)
            {
                if (String.IsNullOrEmpty(causeVisit) || causeVisit == "\n")
                {
                    Console.WriteLine("ОШИБКА! Введите Причину посещения");
                    causeVisit = Console.ReadLine();
                   
                }
                else
                fullInfo = true;
            }
            //-----------------------------------------------------------------------
            Console.WriteLine("Введите номер удостоверения ");
               indetityNumber = Console.ReadLine();
            while (fullInfo)
            {
                if (String.IsNullOrEmpty(indetityNumber) || indetityNumber == "\n")
                {
                    Console.WriteLine("ОШИБКА! Введите номер удостоверения личности");
                    indetityNumber = Console.ReadLine();

                }
                else
                    fullInfo = false;
            }
            Console.WriteLine("Нажмите два раза пробел чтобы зафиксировать время вЫхода");
            ConsoleKeyInfo pressedSecond;
            DateTime endVisit = DateTime.Today;
            pressedSecond = Console.ReadKey();

            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                endVisit = DateTime.Now;
            }

            var persons = new VisitProperties
            {
                EntryTime = now,
                ExitTime = endVisit,
                Name = fullName,
                VisitCause = causeVisit,
                NumberIdentity = indetityNumber,
            };
            using (var context = new Persons())
            {
                context.VisitProperties.Add(persons);
                context.SaveChanges();
            }
        }
    }
}

