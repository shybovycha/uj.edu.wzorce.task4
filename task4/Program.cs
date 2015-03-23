using System;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IWentylatornaFabryka fabryka = new DekoratorowaFabryka();
            ITurnable went1 = fabryka.utworzWentylator();
            ITurnable went2 = fabryka.utworzWentylator();

            went1.wlacz();
            went2.wlacz();

            went1.wylacz();

            went1.wlacz();
            went1.wylacz();

            went1.wlacz();
            went1.wylacz();

            Console.WriteLine(String.Format("Wentylator #1: {0}", went1.status()));
            Console.WriteLine(String.Format("Wentylator #2: {0}", went2.status()));
        }
    }
}
