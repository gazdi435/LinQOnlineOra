using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace feladatsorok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> napiCsapadek = new List<int>();

            List<string> versenyzok = new List<string>();

            List<double> maxHofok = new List<double>();

            List<string> diakok = new List<string>();

            //1
            int elsoFeladat = maxHofok.Count(x => x > 20);
            Console.WriteLine(elsoFeladat);

            //2
            List<double> maxHofokRendezett = maxHofok.OrderBy(x => x).ToList();

            //3
            int ketKeresztnevesDiakok = diakok.Count(x => x.Split(' ').Length == 3);

            //4
            diakok.Where(x => x.Length > 15).OrderBy(x => x.Length).ToList().ForEach(x => { Console.WriteLine(x); });

            //diakok.OrderBy(x => x.Length).Where(x => x.Length > 15).ToList().ForEach(x => { Console.WriteLine(x); });

            //5
            napiCsapadek.Count(x => x == 20);

            //6
            napiCsapadek = napiCsapadek.OrderByDescending(x => x).ToList();

            //7
            List<int> aligesett = napiCsapadek.Where(x => x < 3).ToList();

            //8
            versenyzok.OrderBy(x => x.Length).ThenBy(x => x);

            //9
            napiCsapadek.Count(x => x == 0);

            //10
            List<int> sokeso = napiCsapadek.Where(x => x > 5).ToList();

            //11
            versenyzok.Where(x => x.Split(' ')[1] == "Dávid").ToList().ForEach(x => Console.WriteLine(x));

            //12
            double valtozo = maxHofok.Max(x => x) - maxHofok.Min(x => x);

            //13
            int masodikLegmagasabb = napiCsapadek.OrderBy(x => x).ToList()[1];

            //14
            double atlagCsapadek = napiCsapadek.Average(x => x);

            //15
            versenyzok.Contains("Szuper-Béla");

            //16
            double asdas = napiCsapadek.FindLastIndex(x => x > 30);

            //17
            diakok.Select(x => x.Split(' ')[0]).Distinct().Count();

            //18
            string nev = versenyzok.Find(x => x.Contains("Vajk"));

            //19
            List<string> nevek = diakok.Select(x => x.Split(' ')[1]).ToList();

            //20
            List<string> angolul = versenyzok
.Where(nev => nev.Contains("Béla"))
.Select(x => x.Split('-')[1] + " " + x.Split('-')[0])
.ToList();
        }
    }
}
