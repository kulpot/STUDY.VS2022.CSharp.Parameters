﻿using System;

//ref link:https://www.youtube.com/watch?v=W3ptOgpUNiE&list=PLF932FF551E0ADD16&index=7
// for loop - rearrange while loop
// C# - called methods
// Java - called methods.
// C++ - called functions

class MyClass
{
    static void SayHello(string myName, string yourName)    // parameters
    {
        Console.WriteLine("Hello, " + yourName + ", my name is " + myName + ".");
    }   // OUTPUT: Hello, Eric, my name is Kulpot.
        //         Hello, Bob, my name is Rebeccar.






    //static void AMethod()
    //{
    //    Console.WriteLine("this is the first line in the method");
    //    Console.WriteLine("this is the second line in the method");
    //    Console.WriteLine("this is the third line in the method");
    //}

    static void Main()  // Main is important - all program starts in main
    {
        SayHello("Kulpot", "Eric");
        SayHello("Rebeccar", "Bob");






        //Console.WriteLine("Kulpot");
        //AMethod(); // calling a method
        //Console.WriteLine("Wahu");
        //AMethod();
        //Console.WriteLine("Coach");
        /*-----OUTPUT-----
         * 
            Kulpot
            this is the first line in the method
            this is the second line in the method
            this is the third line in the method
            Wahu
            this is the first line in the method
            this is the second line in the method
            this is the third line in the method
            Coach
         * 
         */




        //int i = 1;
        //while (i <= 20)
        //{
        //    Console.WriteLine(i);
        //    i = i + 1;
        //}
        //Console.WriteLine("Done"); // output 1 to 20 Done

        //for (int i = 1; i <= 20; i = i + 1)
        //for (int i = 1; i <= 20; i++)   // i = i + 1 same as i++
        //{
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("Done");   // output 1 to 20 Done
    }
}