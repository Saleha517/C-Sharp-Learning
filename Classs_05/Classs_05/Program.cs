// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");


Console.WriteLine("---\"Nested Loop in C#\"------");
Console.Write("\n");




for (int i = 1; i<=5; i++)
{
    for (int j = 1; j <=i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}


//Console.Write("\n");



for (int i = 5; i <= 1; i--)
{
    for (int j = i; j >= 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}
//5

for (int l = 1; l <= 5; l++)
    //{
    //    Console.Write($"{l}----");

    //    for(int k = 1; k <= 10; k++ )
    //    {
    //        Console.WriteLine(l);
    //        Console.Write("\t");
    //    }
    //}



    Console.ReadKey();

