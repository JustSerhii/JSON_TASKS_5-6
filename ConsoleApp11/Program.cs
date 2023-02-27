using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            River river1 = new River("Buzh");
            river1.GetInfo();


            Console.WriteLine("\n\n");


            river1.PrintDetails();

            Console.WriteLine("\n\n");

            Mountain rock1 = new Mountain("Hoverla");
            rock1.GetInfo();
            rock1.PrintDetails();

        }
    }
    interface IGeoObject
    {
        void GetInfo();
    }

    abstract class GeoObject : IGeoObject
    {
        protected double coX;
        protected double coY;
        protected string name;
        protected string description;

        public GeoObject(string Name)
        {
            this.name = Name;
        }

        public virtual void GetInfo()
        {
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name + "\nX: " + coX + "\nY: " + coY + "\nDescription: " + description);
        }

        abstract public void PrintDetails();
    }

    class River : GeoObject
    {

        protected double flowSpeed;
        protected double length;

        public River(string Name) : base(Name)
        {
            this.name = Name;
        }
        public override void GetInfo()
        {
            Console.Write("CoX: "); coX = Convert.ToDouble(Console.ReadLine());
            Console.Write("CoY: "); coY = Convert.ToDouble(Console.ReadLine());
            Console.Write("Description: "); description = Console.ReadLine();
            Console.Write("The speed of the flow: "); flowSpeed = Convert.ToDouble(Console.ReadLine());
            Console.Write("The length of the river: "); length = Convert.ToDouble(Console.ReadLine());
        }

        public override void PrintDetails()
        {
            PrintInfo();
            Console.WriteLine("Speed of the flow: " + flowSpeed + "\nThe length of the river: " + length);
        }

    }
    class Mountain : GeoObject
    {

        protected double highestPoint;

        public Mountain(string Name) : base(Name)
        {
            this.name = Name;
        }
        public override void GetInfo()
        {
            Console.Write("The highest point: "); highestPoint = Convert.ToDouble(Console.ReadLine());
            Console.Write("CoX: "); coX = Convert.ToDouble(Console.ReadLine());
            Console.Write("CoY: "); coY = Convert.ToDouble(Console.ReadLine());
            Console.Write("Description: "); description = Console.ReadLine();
        }

        public override void PrintDetails()
        {
            PrintInfo();
            Console.WriteLine("The highest point: " + highestPoint);
        }

    }
}