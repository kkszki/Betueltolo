using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betueltolo
{
    internal class Program
    {
        static string kod = "4567";
        static string abc = "aábcdeéfghiíjklmnoóöőpqrstuúüűvwxyzaábcdeéfghiíjklmnoóöőpqrstuúüűvwxyz";
 

        static char Eltolva(char betu, int szam)
        {

            int mostani_index = abc.IndexOf(betu);


            return abc[mostani_index + szam];
        }

        static char Visszatolva(char betu, int szam)
        {

            int mostani_index = abc.IndexOf(betu);
            mostani_index += (abc.Length / 2);
           
            return abc[mostani_index - szam];
        }


        static void Main(string[] args)
        {
            Console.WriteLine("adja meg a szót: ");
            string szo = Console.ReadLine();
            int index = 0;
            string uj = "";
            for (int i = 0; i < szo.Length; i++)
            {
                if (szo[i] == ' ')
                {
                    uj += ' ';
                    continue;
                }
                else
                {
                    int szam = int.Parse(kod[index].ToString());

                    uj += Eltolva(szo[i], szam);
                }
                index++;
                if (index == kod.Length)
                {
                    index = 0;
                }

            }
            Console.WriteLine(uj);
            Console.ReadLine();
            index = 0;

            for (int i = 0; i < uj.Length; i++)
            {

                int szam = int.Parse(kod[index].ToString());
                if (szam > abc.Length)
                {
                    szam += (abc.Length / 2);
                }
               
                Console.WriteLine(Visszatolva(uj[i], szam));
                

                index++;
                if (index == kod.Length)
                {
                    index = 0;
                }


            }



        }
    }
}

