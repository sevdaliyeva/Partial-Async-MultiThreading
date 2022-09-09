// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//1.Write 2 methods which both accept int n as parameter, iterates from 1 to n and just write
//"Method1 - i" or "Method2 - i" to console. Then write 2 seperate Threads to run them
//using System;
//using System.Threading;
//public class Threadd
//{ 
//    public static void ThreadProc()

//    { int n=100;
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(i);
//            Thread.Sleep(20);
//        }
//    }
//    public static void Main()
//    {
//        Console.WriteLine("Start a second thread.");
//        Thread t = new Thread(new ThreadStart(ThreadProc));
//        t.Start();
//        int n=100;

//        for (int i = 0; i <n ; i++)
//        {
//            Console.WriteLine(i);
//            Thread.Sleep(20);
//        }
//    }
//}
//2.Try to get the cat facts  https://catfact.ninja/fact asynchronously
//static async Task Main(string[]args)
//{
//    string url = "https://catfact.ninja/fact";
//    HttpClient client = new HttpClient();
//    Console.WriteLine("Show me some facts:");
//    do
//    {
//        var stringResult = await client.GetStringAsync(url);    
//        Console.WriteLine(stringResult);    
//    }
//    while (Convert.ToBoolean(Console.ReadLine()));
//}
//3. Sum digits in string
//using System;
//class SumDigits
//{
//    public static void Main()
//    {
//        string str;
//        Console.WriteLine("Enter a string ");
//        str = Console.ReadLine();
//        int sum = 0;
//        int s = str.Length;

//        for (int c = 0; c < s; c++)
//        {

//            if ((str[c] >= '0') && (str[c] <= '9'))
//            {
//                sum += (str[c] - '0');
//            }
//        }

//        Console.WriteLine("Sum = " + sum);
//    }
//}
//4.Write a query that returns top 5 numbers from the list of integers in descending order.
//Expected input and output [78, -9, 0, 23, 54, 21, 7, 86] → 86 78 54 23 21

//List<int> numbers = new List<int>() { 78, -9, 0, 23, 54, 21, 7, 86 };
//numbers.Sort();
//numbers.Reverse();
//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}
//5. Write a query that returns only uppercase words from string.
//using System;
//using System.Linq;
//using System.Collections.Generic;
//class UpperCase
//{
//    static void Main(string[] args)
//    {

//        string str1;
//        Console.Write("Input the string : ");
//        str1 = Console.ReadLine();

//        var strNew =WordFilt (str1);
//        Console.WriteLine(" ");
//        foreach (string str2 in strNew)
//        {
//            Console.WriteLine(str2);
//        }
//        if(str1==" ")
//            Console.WriteLine("Please enter the string:");
      
//    }

//    static IEnumerable<string> WordFilt(string mystr)
//    {
//        var upperWord = mystr.Split(' ')
//                    .Where(x => String.Equals(x, x.ToUpper(),
//                    StringComparison.Ordinal));

//        return upperWord;

//    }
//}
//6.Given a year as integer, write a method that checks if year is leap
//using System;
//namespace Year
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Year : ");
//            int Year = int.Parse(Console.ReadLine());
//            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
//                Console.WriteLine("{0} is a Leap Year.",Year);
//            else Console.WriteLine("{0} is not a Leap Year.", Year);

//    }
//    }
//}





