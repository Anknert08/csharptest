// See https://aka.ms/new-console-template for more information
using System.Text.Unicode;
using csharptest;

Person[] p = new Person[10];
int registered = 0;
string promt;

do
{
   Console.Write("skriv promt (exit för att avsluta): ");
    promt = Console.ReadLine();
    promt = promt.ToLower();
    
    if (promt == "edit info" || promt == "Edit info")
    {
        
    }
    
    if (promt == "show info")
    {
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Name: " + p[id].Name);
        Console.WriteLine("Lastname: " + p[id].Lastname);
        Console.WriteLine("Age: " + p[id].Age);
    }
    
    if (promt == "reg person")
    {
        Console.Write("Enter name: ");
        p[registered] = new Person(Console.ReadLine(), Console.ReadLine());
        Console.Write("Enter age: ");
        p[registered].Age = int.Parse(Console.ReadLine());
        registered++; 
    }

    if (promt != "reg person" && promt != "show info" && promt != "edit info" && promt != "exit")
    {
        Console.WriteLine("Invalid promt");
    }

    
    

} while (promt != "exit");









