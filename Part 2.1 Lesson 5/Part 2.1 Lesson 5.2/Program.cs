using System;

namespace Part_2._1_Lesson_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name="j";
            ComplexNum complex = new ComplexNum(2, 3);
            ComplexNum complex1 = new ComplexNum(4, 5);
            ComplexNum complex2 = complex + complex1;
            complex2.Print();
            Console.WriteLine("({0},{1})", complex.Firstnum, complex.SecondNum);
            Console.WriteLine(complex2.Print());
        }
    }
}
