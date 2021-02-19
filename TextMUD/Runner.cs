using System;

namespace TextMUD
{
    public class Runner
    {
        private int Dave { get; }
        private string Name { get; }

        public Runner(int dave, string name)
        {
            Dave = dave;
            Name = name;
        }
        
        public void Diving()
        {
            Console.WriteLine($"{Dave} Dave's, called {Name.ToUpper()}");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}