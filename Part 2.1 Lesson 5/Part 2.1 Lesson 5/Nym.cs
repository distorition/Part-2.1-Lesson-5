using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_5
{
    class Nym
    {
        public int FristNum { get; set; }
        public int SecondNum { get; set; }
        public Nym(int fnum,int snum)
        {
            FristNum = fnum;
            SecondNum = snum;
        }

        public static Nym operator +(Nym v1,Nym v2)
        {
            return new Nym(v1.FristNum + v2.FristNum, v1.SecondNum + v2.SecondNum);
        }
        public static Nym operator -(Nym v1, Nym v2)
        {
            return new Nym(v1.FristNum - v2.FristNum, v1.SecondNum - v2.SecondNum);
        }
        public static Nym operator *(Nym v1, Nym v2)
        {
            return new Nym(v1.FristNum * v2.FristNum, v1.SecondNum * v2.SecondNum);
        }
        public static Nym operator *(Nym v1, int num)
        {
            return new Nym(v1.FristNum * num, v1.SecondNum * num);
        }
        public static Nym operator *(int num,Nym v1)
        {
            return new Nym(v1.FristNum * num, v1.SecondNum * num);
        }
        public static Nym operator ++(Nym v1)
        {
            v1.FristNum++;
            v1.SecondNum++;
            return v1;
        }
        public static Nym operator --(Nym v1)
        {
            v1.FristNum--;
            v1.SecondNum--;
            return v1;
        }
        public static bool operator ==( Nym v1,Nym v2)
        {
            return (v1.FristNum==v2.FristNum && v1.SecondNum ==v2.SecondNum);
        }
        public static bool operator !=(Nym v1, Nym v2)
        {
            return (v1.FristNum == v2.FristNum || v1.SecondNum == v2.SecondNum);
        }
        public static bool operator >(Nym v1, Nym v2)
        {
            return (v1.FristNum > v2.FristNum || v1.SecondNum > v2.SecondNum);
        }
        public static bool operator <(Nym v1, Nym v2)
        {
            return (v1.FristNum < v2.FristNum || v1.SecondNum < v2.SecondNum);
        }
        public static implicit operator float(Nym v1)
        {
            return v1.SecondNum;
        }
        public static implicit operator int(Nym v1)
        {
            return (int)v1.SecondNum;
        }
    }
}
