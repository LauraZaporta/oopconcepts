using System;

namespace oopconcepts
{
    public class Tree
    {
        public string Type { get; set; }
        public double Height { get; set; }
        public double Humidity { get; set; }

        public Tree(string type, double height, double humidity) {
            Type = type;
            Height = height;
            Humidity = humidity;
        }
        public Tree() { }
        
        public void Photosyntesis()
        {
            Console.WriteLine("Does photosyntesis");
        }
    }
}