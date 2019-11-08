using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student s1;
            s1 = new Student("Benan", 16, 1.80);
            Student s2;
            s2= new Student("Nathan", 16, 1.7);

            s1.educate();
            s1.educate();

            for(int x=0; x<365; x++)
            {
                s2.lateNight();


            }
            
            s1.print();

            s2.print();

            s2 = null;
      
        }
    }

   
}
