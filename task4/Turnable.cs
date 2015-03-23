using System;

namespace task4
{
    public abstract class Turnable : ITurnable
    {
        private String name;
        private bool isOn;

        public Turnable(String name)
        {
            this.name = name;
            this.isOn = false;
        }

        public void wlacz()
        {
            this.isOn = true;
            Console.WriteLine(String.Format("{0} włączono", this.name));
        }

        public void wylacz()
        {
            this.isOn = false;
            Console.WriteLine(String.Format("{0} wyłączono", this.name));
        }

        public String status()
        {
            return String.Format("{0} {1}", this.name, (this.isOn ? "włączono" : "wyłączono"));
        }
    }
}

