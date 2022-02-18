using LibReFinder;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            main(args);
            Console.ReadLine();
        }

        static void main(string[] args)
        {

            //string[] array_ = new string[] { "A", "B", "ASD" };
            //Console.WriteLine("-" + str_.GetStringIndex(0,20) + "-");    
            //Console.WriteLine( string.Join("-" , array_)) ;

            string str_ = @"C:\Users\UnderKo\Downloads\android-studio-2021.1.1.21-windows.zip";
            string[] array_ = RegEx.GetValuesToArray(str_, "[0-9.]").ToArray();
            int count_ = 0;
            foreach (InString item in str_.FindIndex(array_.ToArray()))
            {
                Console.WriteLine($"[{count_}]: {item} ");
                count_++;
            }
        }
       

    }
}
