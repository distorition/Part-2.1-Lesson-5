using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_5._2
{
    class ComplexNum
    {

        public string w { get; set; }
       public int Firstnum { get; set; }
        public int SecondNum { get; set; }

        public ComplexNum(int x, int y)
        {
            Firstnum = x;
            SecondNum = y;
        }

        public static ComplexNum operator +(ComplexNum v1,ComplexNum v2)
        {
            return new ComplexNum(v1.Firstnum + v2.Firstnum, v1.SecondNum + v2.SecondNum);
        }

        public static ComplexNum operator *(ComplexNum v1, ComplexNum v2)
        {
            return new ComplexNum(v1.Firstnum * v2.Firstnum, v1.SecondNum * v2.SecondNum);
        }
        public static ComplexNum operator -(ComplexNum v1, ComplexNum v2)
        {
            return new ComplexNum(v1.Firstnum - v2.Firstnum, v1.SecondNum - v2.SecondNum);
        }
        public static bool operator ==(ComplexNum v1, ComplexNum v2)
        {
            return (v1.Firstnum == v2.Firstnum && v1.SecondNum == v2.SecondNum);
        }
        public static bool operator !=(ComplexNum v1, ComplexNum v2)
        {
            return (v1.Firstnum == v2.Firstnum || v1.SecondNum == v2.SecondNum);
        }
        public string Print()
        {
            string s = "";
          
            if (Firstnum == 0 & SecondNum == 0)
            {
                s = "0";
            }
            else if (Firstnum < 0 & SecondNum < 0)
            {
                s = Firstnum.ToString() + "-" + "I" + SecondNum.ToString();
            }
            else if (Firstnum > 0 & SecondNum > 0)
            {
                s = Firstnum.ToString() + "+" + "i" + SecondNum.ToString();
            }
            else if (Firstnum != 0 & SecondNum != 0)
            {
                s = Firstnum.ToString();
            }
            
            return s;
        }
        //public ComplexNum(int fnum,int snum,string words)
        //{
        //    Num = fnum;
        //    SecondNum = snum;
        //    FMnimNum = words;
        //}
        //public ComplexNum(int fnum, string words, int snum)
        //{
        //    Num = fnum;
        //    SecondNum = snum;
        //    FMnimNum = words;
        //}
        //public ComplexNum(int fnum, string words, int snum,string secondWords)
        //{
        //    Num = fnum;
        //    SecondNum = snum;
        //    FMnimNum = words;
        //    SMnimNum = secondWords;
        //}
        //public int Num { get; set; }
        //public int SecondNum { get; set; }
        //public string FMnimNum { get; set; }
        //public string SMnimNum { get; set; }

        //public static ComplexNum operator +(ComplexNum v1,  ComplexNum v2)
        //{
            
        //    return new ComplexNum(v1.Num + v2.Num, v1.SecondNum + v2.SecondNum,v2.FMnimNum);
        //}
        //public static ComplexNum operator *(ComplexNum v1,  ComplexNum v2)
        //{
        //    //var sum= new ComplexNum(v1.Num * v2.Num, v2.FMnimNum, v1.SecondNum * v2.SecondNum);
        //    //var sum1=new ComplexNum (v1.Num * v2.Num, v1.SecondNum * v2.SecondNum, v2.FMnimNum);
        //    //var sum2 = new ComplexNum(v1.Num, v2.FMnimNum, * v2.Num, v1.SecondNum * v2.SecondNum);
        //    return new ComplexNum(v1.Num * v2.Num,v2.FMnimNum, v1.SecondNum * v2.SecondNum,v2.FMnimNum);
        //}
       

    }
}
