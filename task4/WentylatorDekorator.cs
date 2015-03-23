using System;

namespace task4
{
    public class WentylatorDekorator : ITurnable
    {
        private ITurnable wentylator;
        private int wlaczenia;
        private int wylaczenia;

        public WentylatorDekorator(WentylatorFacade wentylator)
        {
            this.wentylator = wentylator;
            this.wlaczenia = 0;
            this.wylaczenia = 0;
        }

        public void wlacz()
        {
            this.wentylator.wlacz();
            this.wlaczenia++;
        }

        public void wylacz()
        {
            this.wentylator.wylacz();
            this.wylaczenia++;
        }

        public String status()
        {
            return String.Format("Włączenia: {0}; Wyłączenia: {1}", this.wlaczenia, this.wylaczenia);
        }
    }
}

