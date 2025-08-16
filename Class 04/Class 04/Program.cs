// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("\"For Loop In C-Sharp\"");

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{i} - For Loop in C#");
}

Console.WriteLine("\n\"While Loop In C-Sharp\"");

int a = 10;

while(a <= 20)
{
    Console.WriteLine($"{a} - While Loop in C#");

    a++;
}

Console.WriteLine("\n\"Do-While Loop In C-Sharp\"");


int n = 10;
do
{
    Console.WriteLine($"{n} - Do-While Loop");
    n++;
}
while(n <= 20);

Console.WriteLine("\n\"Break and Continue\"");

for (int s = 1; s <= 10; s++)
{
    Console.WriteLine($"{s} - C#_Learning");

    if(s == 4)
    {
        break;
    }
}