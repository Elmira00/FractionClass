using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    //=========P O I NT   C L A S S    T A S K 1==============

    //class Point
    //{
    //    private double X;
    //    private double Y;
    //    public Point()
    //    {

    //    }
    //    public Point(double x, double y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public  void ShowData()
    //    {
    //        Console.WriteLine($"X-->{X}");
    //        Console.WriteLine($"Y-->{Y}");
    //    }
    //}
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Point myPoint = new Point(100, -1);
    //        myPoint.ShowData();
    //    }
    //}

    // ===============C O U N T E R   T A S K 2=================

    //class Counter
    //{

    //    public int min { get; set; }
    //    public int max { get; set; }
    //    private int currentData { get; set; }

    //    public Counter(int min,  int max)
    //    {
    //        this.min = min;
    //        this.max = max;
    //        currentData = min;
    //    }

    //    public void Increement()
    //    {
    //        if (currentData == max)
    //        {
    //            currentData = min;
    //        }
    //        else
    //        {

    //        currentData++;
    //        }
    //    }  
    //    public int GetCurrentData()
    //    {
    //        return currentData;
    //    }
    //}
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Counter myCounter = new Counter(1,3);
    //        Console.WriteLine(myCounter.GetCurrentData());
    //        myCounter.Increement();
    //        Console.WriteLine(myCounter.GetCurrentData());
    //        myCounter.Increement();
    //        Console.WriteLine(myCounter.GetCurrentData());
    //        myCounter.Increement();
    //        Console.WriteLine(myCounter.GetCurrentData());
    //        myCounter.Increement();
    //        Console.WriteLine(myCounter.GetCurrentData());
    //        myCounter.Increement();
    //        Console.WriteLine(myCounter.GetCurrentData());

    //    }
    //}

    //================ F R A C T I O N    T A S K 3========================
    class Fraction
    {
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public int  numerator{ get; set; }
        public int  denominator{ get; set; }

        public Fraction Plus(Fraction fraction)
        {
            int newNumerator = fraction.denominator * numerator+fraction.numerator*denominator;
            int newDenominator = fraction.denominator * denominator;
            return  new Fraction (newNumerator, newDenominator);
        }

        public Fraction Minus(Fraction fraction)
        {
            int newNumerator = fraction.denominator * numerator-fraction.numerator*denominator;
            int newDenominator = fraction.denominator * denominator;
            return  new Fraction (newNumerator, newDenominator);
        }

        public Fraction Mult(Fraction fraction)
        {
            int newNumerator = numerator*fraction.numerator;
            int newDenominator = fraction.denominator * denominator;
            return  new Fraction (newNumerator, newDenominator);
        }
       
        public Fraction Div(Fraction fraction)
        {
            int newNumerator = numerator*fraction.denominator;
            int newDenominator = fraction.numerator * denominator;
            return  new Fraction (newNumerator, newDenominator);
        }
        public  void Show()
        {
            Console.WriteLine($"result :  {numerator}/{denominator} ");
        }
      
    }

    public class Program
    {
        static void Main(string[] args)
        {
           Fraction a=new Fraction(1,3);
           Fraction b=new Fraction(2,5);
           Fraction c = a.Mult(b);
            c.Show();
        }
    }

}
