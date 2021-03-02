using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR_02_13___Liczby__nie_pierwsze
{
    class Program
    {
        public static bool czy_pierwsza(int a)//sprawdzenie czy jest liczba pierwsza
        {
            int dzielniki = 0;//liczy dzielniki
            for(int i = 1; i <= a; i++)//pętla sprawdzająca liczbę dzielników dla podanej liczby a
            {
                if (a % i == 0)
                {
                    dzielniki++;
                }
            }
            if (dzielniki > 2)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string dane = Console.ReadLine();
                string[] daneStr = dane.Split(' ');
                int a = int.Parse(daneStr[0]);
                int b = int.Parse(daneStr[1]);
                int podciag = 0;// podciag obecnej iteracji
                int najdluzszy = 0;//najdluzszy mozliwy podciag
                for(int j = a; j <= b; j++)
                {
                    bool wynik = czy_pierwsza(j);// sprawdzenie czy liczba jest liczba pierwsza
                   // Console.WriteLine("Liczba " + j + " " + wynik);
                    if (wynik)
                    {//wykonuje sie gdy liczba jest pierwsza
                        if (podciag > najdluzszy)//sprawdza czy obecny podciag jest dluzszy od najdluzszego
                        {
                            najdluzszy = podciag;
                            podciag = 0;// zeruje podciag
                        }
                        else
                        {
                            podciag = 0;//zeruje podciag
                        }
                    }
                    else
                    {//wykona sie gdy liczba nie jest pierwsza
                        podciag++;//zwieksza podciag o 1
                        if (j == b)// newralgiczny punkt :wykona sie tylko dla ostatniej wartosci
                        {
                            if (podciag > najdluzszy)// sprawdza czy dodanie ostatniej wartosci ktora jest liczba niepierwsza spowoduje ze bedzie to najdluzszy podciag
                            {
                                najdluzszy = podciag;
                               // podciag = 0;
                            }
                        }
                    }
                   // Console.WriteLine("Podciag = " + podciag +"Najdluzszy"+najdluzszy);
                }
                Console.WriteLine(najdluzszy);

            }

            Console.ReadKey();
        }
    }
}
