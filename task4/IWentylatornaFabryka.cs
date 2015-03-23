using System;

namespace task4
{
    public abstract class IWentylatornaFabryka
    {
        protected int idWentylatora;

        public IWentylatornaFabryka()
        {
            this.idWentylatora = 0;
        }

        public abstract ITurnable utworzWentylator();
    }
}

