namespace ConsoleApp1
{
    using System;
    class Student
    {
        private int age;
        private int IQ;
        private string name;
        private double height;






        public Student(string n, int age, double height)
        {
            IQ = 100;
            name = n;
            this.age = age;
            this.height = height;

        }

        public Student(string n)
        {
            name = n;
            age = 11;
            height = 1.1;

        }



        public double getHeight()
        {
            return height;
        }


        public void setHeight(double h)
        {
            height = h;

        }


        public void educate()
        {
            IQ = IQ + 10;
        }

        public void lateNight()
        {
            if (IQ > 5)
            {
                IQ = IQ - 5;
            }
        }

        public void print()
        {
            Console.WriteLine(name);
            Console.WriteLine(height);
            Console.WriteLine(age);
            Console.WriteLine(IQ);

        }
    }
}