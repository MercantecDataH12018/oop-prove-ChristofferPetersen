using System;
using System.Collections.Generic;

#pragma warning disable 
namespace OOPH1Eksamen
{
    /*
     * I alle de følgende opgaver er der en tilstødende klasse. Det er
     * den der skal arbejdes med i den givne opgave.
     * Navnene på klasserne er irrelevante for jer og må IKKE ændres
     * 
    */


    class Program {
        public static void Main() {
            //Denne funktion kan du bruge til at teste din kode
            Console.WriteLine("Hello World!");
            D d = new D();

        }
    }

    //OPG Tilføj en property for Alder kaldet "age" til den følgende class
    class B
    {
        public string name = "";
        public int legs = 2;
        public int age;
    }

    //OPG Tilføj en string property kaldet 'brand' til følgende class
    class E
    {
        string brand;
    }

    //OPG Tilføj en metode der kan forstørre 'a' med 1 hver gang den kaldes
    class C
    {
        public int a;
        public int AEnlargement()
        {
            a += 1;
            return a;
        }
    }

    //OPG Tilføj en metode kaldet "getA" der kan returnere værdien i a
    class G
    {
        string a = "Hello!";
        public string getA()
        {
            return a;
        }
    }

    //OPG Tilføj en metode der kan tilføje et tal til numbers. Numbers skal
    //forblive private.
    class F
    {
        List<int> numbers = new List<int>();
        string input = Console.ReadLine();
        public void AddNumberToNumbers()
        {
            numbers.Add(Int32.Parse(input));
        }
    }

    //OPG Implementer encapsulation i denne klasse, men gør således det stadig 
    //er muligt at læse værdierne 'a' og 'b'
    class D
    {   //Her mangler jeg virkelig bedre forståelse for har ikke nogen ide om hvordan det skal gøres bliver forvirret over alle de ting jeg læser på nettet.
        public int a;
        public string b;        
    }

    //OPG Lav en constructor der sætter alle properties af følgende klasse
    class A
    {
        public int a;
        public string b;
        public double c;

        public A(int a = 0, string b = "default", double c = 0.0)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }

    //OPG klassen H skal have en reference til klasse A, kaldet 'a'. Lav en constructor der
    //sætter denne til reference til et objekt af A
    class H
    {
        A a = new A();

        public H(A a)
        {
            this.a = a;
        }
    }

    //OPG Ændre funktionen PrintM, således at den ikke crasher programmet hvis den køres.
    class I 
    {   //Denne opgave drev mig ud på et sidespor til jeg opdagede hvor retarderet min hjerne er.
        public string text;

        public void PrintM(){
            text = "default";
            Console.WriteLine("Text is " + text.Length + " long");
        }
    }

    //OPG Invoke kan faile hvis der gives en null værdi til dens constructor.
    //sørg for at dette ikke kan forekomme ved kun at ændre på Invoke
    class J
    {   //Her mangler jeg virkelig bedre forståelse for har ikke nogen ide om hvordan det skal gøres bliver forvirret over alle de ting jeg læser på nettet.
        public I i;

        public void Invoke() {
            i.PrintM();
        }

        public J(I i) {
            this.i = i;
        }
    }

    //OPG Herunder skal du selv implementere en class kaldet MyClass der
    //er subclass til C. Tilføj et public string felt kaldet 'myString'.

    class MyClass : C {
        public string myString;
    }



}
