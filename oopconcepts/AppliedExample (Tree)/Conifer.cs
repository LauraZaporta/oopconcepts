using System;

namespace oopconcepts
{
    public class Conifer : Tree
    {
        public string TypeCone { get; set; }

        public Conifer(string type, double height, double humidity, string typeCone) : base (type, height, humidity)
        {
            Type = type;
            Height = height;
            Humidity = humidity;
            TypeCone = typeCone;
        }

        public Conifer() { }

        //Override example
        public override void Photosyntesis()
        {
            Console.WriteLine("Does photosyntesis in a crazy way I love conifers :D");
        }
        //Overload example
        public void Calculations(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Calculations(double a, double b)
        {
            Console.WriteLine(a+b);
        }
    }
}
