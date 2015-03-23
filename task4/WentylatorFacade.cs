using System;
using System.Threading;

namespace task4
{
    public class WentylatorFacade : ITurnable
    {
        private GlownyWlacznik glownyWlacznik;
        private Hamulec hamulec;
        private Pompa pompa;
        private Prad prad;
        private Wentylator wentylator;
        private Wzbudzac wzbudzac;
        private int idWentylatora;
        private bool isOn;

        public WentylatorFacade(int id)
        {
            this.idWentylatora = id;
            this.glownyWlacznik = new GlownyWlacznik();
            this.hamulec = new Hamulec();
            this.pompa = new Pompa();
            this.prad = new Prad();
            this.wentylator = new Wentylator();
            this.wzbudzac = new Wzbudzac();
            this.isOn = false;
        }

        public void wlacz()
        {
            Console.WriteLine(String.Format("Włączamy wentylator #{0}", this.idWentylatora));

            this.glownyWlacznik.wlacz();
            this.pompa.wlacz();
            this.hamulec.wylacz();
            this.prad.wlacz();
            this.wzbudzac.wlacz();
            this.wentylator.wlacz();
            this.wzbudzac.wylacz();

            this.isOn = true;

            Console.WriteLine(String.Format("Wszystkie systemy wentylatora #{0} on-line", this.idWentylatora));
        }

        public void wylacz()
        {
            Console.WriteLine(String.Format("Wyłączamy wentylator #{0}", this.idWentylatora));

            this.glownyWlacznik.wylacz();
            this.hamulec.wlacz();
            this.wentylator.wylacz();
            this.prad.wylacz();
            this.pompa.wylacz();

            this.isOn = false;

            Console.WriteLine(String.Format("Wszystkie systemy wentylatora #{0} off-line", this.idWentylatora));
        }

        public String status()
        {
            return String.Format("Wentylator #{0} {1}", this.idWentylatora, (this.isOn ? "włączono" : "wyłączono"));
        }
    }
}

