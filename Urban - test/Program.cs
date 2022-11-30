using System.Security.Cryptography;
namespace Test___1
{
    internal class Program
    {

        public static void Main(string[] args)
        {

            while (false == false)
            {
                Uloha1();
                Uloha2();
            }
           
        }

        public static void Uloha1()
        {
            Console.Clear();
            
            cw("Zadej objem vody");
            double OV = Convert.ToDouble(Console.ReadLine());
            cw("Zadej přikon konvice");
            double PK = Convert.ToDouble(Console.ReadLine());
            cw("Zadej účinnost");
            double UC = Convert.ToDouble(Console.ReadLine());

            double COK_FR1 =(4180 * OV * 80);
            double COK_FR2 = (PK * UC);
            double COK = COK_FR1 / COK_FR2;
            cw(COK.ToString());
            Console.ReadKey();
        }

        public static void Uloha2()
        {
            Console.Clear();
 
            cw("Zadej koeficient A[x^2]");
            double KA = Convert.ToDouble(Console.ReadLine());
            cw("Zadej koeficient B[x]");
            double KB = Convert.ToDouble(Console.ReadLine());
            cw("Zadej koeficient C");
            double KC = Convert.ToDouble(Console.ReadLine());

            double RES=-KB+Math.Sqrt(Math.Pow(KB,2)-4*KA*KC);
            RES=RES/2*KA;
            cw(RES.ToString());
            RES = -KB - Math.Sqrt(Math.Pow(KB, 2) - 4 * KA * KC);
            RES = RES / 2 * KA;
            cw(RES.ToString());
            Console.ReadKey();
        }


        public static void cw(string txt)
        {
            Console.WriteLine(txt);
        }
    }
}