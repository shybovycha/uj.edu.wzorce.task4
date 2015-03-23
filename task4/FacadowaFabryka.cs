using System;

namespace task4
{
    public class FacadowaFabryka : IWentylatornaFabryka
    {
        public FacadowaFabryka() : base()
        {
        }

        public override ITurnable utworzWentylator()
        {
            return new WentylatorFacade(++this.idWentylatora);
        }
    }
}

