using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayWithDuplicateValues = { 23, 56, 78, 23, 56,67, 89 };
            
            
            var size = arrayWithDuplicateValues.Length;
            for (int i = 0; i < size; i++)
            {
                int temp = 0;
                for (int j = i + 1; j < size; j++)
                {
                    if (arrayWithDuplicateValues[i] == arrayWithDuplicateValues[j])
                    {
                        size--;
                        arrayWithDuplicateValues[j] = arrayWithDuplicateValues[size];
                        j--;
                    }
                    if (arrayWithDuplicateValues[j] < arrayWithDuplicateValues[i])
                    {
                        temp = arrayWithDuplicateValues[i];
                        arrayWithDuplicateValues[i] = arrayWithDuplicateValues[j];
                        arrayWithDuplicateValues[j] = temp;
                    }
                }
                Console.WriteLine(arrayWithDuplicateValues[i]);
            }
            
            
            //    int[] arr = { 4, 2, 5, 1, 2 };
            //    HashSet<int> sets = new HashSet<int>(arr);
            //    int[] sortedArray = sets.ToArray();
            //    for (int i = 0; i < sortedArray.Length; i++)
            //    {
            //        int temp = 0;
            //        for (int j = i+1; j < sortedArray.Length; j++)
            //        {
            //            if (sortedArray[j] < sortedArray[i])
            //            {
            //                temp = sortedArray[i];
            //                sortedArray[i] = sortedArray[j];
            //                sortedArray[j] = temp;
            //            }
            //        }
            //    }
            //    for (int i = 0; i < sortedArray.Length; i++)
            //    {
            //        Console.WriteLine(sortedArray[i]);
            //    }


            //public class A
            //{

            //    public A()
            //    {

            //    }
            //}
            //public class B : A
            //{

            //    public B()
            //    {

            //    }
            //}
            //public interface I1
            //{
            //    int m1(int x, string y);
            //}
            //public abstract class A: I1
            //{
            //    public int m1(int x, string y)
            //    {
            //        return x;
            //    }
            //    public abstract void m2();
            //}
            //public class B: A
            //{
            //    public override void m2()
            //    {
            //        Console.WriteLine("Hello");
            //    }
            //}
            //    int number = 16;
            //    int count = 0;
            //    for (int i = 1; i <= number; i++)
            //    {                
            //        if (number % i == 0)
            //        {
            //            count++;
            //        }                
            //    }
            //    if(count == 2)
            //    {
            //        Console.WriteLine("PrimeNumber");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not a Prime Number");
            //    }

            //B b = new B();
            //A a = b;
            //I1 i = a;
            //int x = i.m1(4, "Hi"); 
            //b.m2();
            //Console.WriteLine(x);
            //Square square = new Square(100,120);
            //int result = square.getArea();
            //Console.WriteLine(result);
            
            Console.ReadLine();
        }
        

    }
    //public interface I
    //{
    //    int  getArea();
    //}
    //public class A : I
    //{
    //    public int height;
    //    public int width;
    //    public A(int height, int width)
    //    {
    //        this.height = height;
    //        this.width = width;
    //    }
    //    public int getArea()
    //    {
    //        return width * height;
    //    }
    //}
    //public class Square : A
    //{
    //    public Square(int height, int width):base( width, width)
    //    {

    //    }
    //}
    //public class C { }
   
    
}
