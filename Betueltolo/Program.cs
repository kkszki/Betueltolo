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
         
            int mostani_index=abc.IndexOf(betu);
            
         
            return abc[mostani_index+szam];
        }
        static void Main(string[] args)
        {
            
            string szo = "python";
            int index = 0;
            for (int i = 0; i < szo.Length; i++) {

                int szam = int.Parse(kod[index].ToString());
                Console.WriteLine(Eltolva(szo[i],szam));
             
                index++;
                if (index == kod.Length)
                {
                    index=0;
                }
           
            }
            Console.ReadLine();
        }
    }
}
