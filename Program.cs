using System;

namespace inheritance_cast_test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Osa uusiOsa = new ValmistettuOsa("Tuontiosa kiinasta", "muovi");
            
            Console.WriteLine(uusiOsa.HaeTiedot());

            Console.ReadKey();
        }
    }

    public abstract class Osa
    {
        public string nimi;

        public Osa(string nimi)
        {
            this.nimi = nimi;
        }

        public abstract string HaeTiedot();
    }

    public class TuontiOsa : Osa
    {
        public string toimittajayritys;

        public TuontiOsa(string nimi, string toimittajayritys) : base(nimi)
        {
            this.toimittajayritys = toimittajayritys;
        }

        public override string HaeTiedot()
        {
            return "Nimi: " + nimi + ", Toimittajayritys: " + toimittajayritys;
        }
    }

    public class ValmistettuOsa : Osa
    {
        public string raakaAine;

        public ValmistettuOsa(string nimi, string raakaAine) : base(nimi)
        {
            this.raakaAine = raakaAine;
        }

        public override string HaeTiedot()
        {
            return "Nimi: " + nimi + ", Raaka-aine: " + raakaAine;
        }
    }
}