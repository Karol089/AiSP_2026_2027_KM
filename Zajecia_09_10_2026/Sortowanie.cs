using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_09_10_2026
{
    internal class Sortowanie
    {
        public static void Babelkowe(int[] tab)
        {
            for(int i = 0; i < tab.Length - 1; i++)
            {
                for(int k = 0; k < tab.Length - 1; k++)
                {
                    if (tab[k] > tab[k + 1])
                    {
                        int temp = tab[k];
                        tab[k] = tab[k + 1];
                        tab[k + 1] = temp;
                    }
                }
            }
        }

        public static void PrzezWybieranie(int[] tab)
        {

        }

        public static int[] Konwertuj(string liczby)
        {
            String[] liczby_s = liczby.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int[] liczby_i = new int[liczby_s.Length];
            for(int i = 0; i < liczby_s.Length; i++)
            {
                liczby_i[i] = int.Parse(liczby_s[i]);
            }
            return liczby_i;
        }
    }

}
