using System;
using System.IO;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
           string input = Console.ReadLine();
           int year = Int32.Parse(input);
           Program program = new Program();
           if(program.isLeapYear(year) == true){
               Console.WriteLine("yay");
           } else {
               Console.WriteLine("nay");
           }
        }

        public bool isLeapYear(int year){
            if(year%4 == 0){
                if(year%100 == 0){
                    if(year%400 == 0){
                        return true;
                    }
                    return false;
                }
                return true;
            } else {
                return false;
            }
        }
    }
}
