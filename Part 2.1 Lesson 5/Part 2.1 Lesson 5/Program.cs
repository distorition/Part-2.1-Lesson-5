using System;

namespace Part_2._1_Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Nym nym = new Nym(2, 3);
            Nym nym1 = new Nym(2, 3);
            Nym nym2 = nym + nym1;
            Console.WriteLine("({0},{1})",nym2.FristNum,nym2.SecondNum);
            Nym nym3 = nym * nym1;
            Console.WriteLine("({0},{1})", nym3.FristNum, nym3.SecondNum);
            Nym nym4 = 4 * nym1;
            Console.WriteLine("({0},{1})", nym4.FristNum, nym4.SecondNum);
            Nym nym5 =nym1*5;
            Console.WriteLine("({0},{1})", nym5.FristNum, nym5.SecondNum);
            Nym nym6 = new Nym(4, 5);
            nym6 *= 7;
            Console.WriteLine("({0},{1})", nym6.FristNum, nym6.SecondNum);
            nym6++;
            Console.WriteLine("({0},{1})", nym6.FristNum, nym6.SecondNum);
            nym5--;
            Console.WriteLine("({0},{1})", nym5.FristNum, nym5.SecondNum);
            Console.WriteLine(nym==nym1);
        }
    }
}
