using System;

namespace task4
{
    public class DekoratorowaFabryka : IWentylatornaFabryka
    {
        public DekoratorowaFabryka() : base()
        {
        }

        public override ITurnable utworzWentylator()
        {
            return new WentylatorDekorator(new WentylatorFacade(++this.idWentylatora));
        }
    }
}

