using System;
using System.IO;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
           string input = Console.ReadLine();
           Program program = new Program();
           if(program.validInput(input)){
               int year = Int32.Parse(input);
               if(program.isLeapYear(year) == true){
               Console.WriteLine("yay");
               } else {
               Console.WriteLine("nay");
               }
           } else {
               Console.WriteLine("Invalid Input - It is only vilid to insert a number from 1582 on so on");
           }
           
        }

        public bool validInput(String input){
            try{
                int val = Int32.Parse(input);
                if(val < 1581){
                return false;
                } else {
                return true;
                }
            } catch (Exception){
                return false;
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
