using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static int InsertionSort()
        {
            Console.Write("\n=============== Program untuk mengurutkan Array menggunakan Insertion Sort ===============");
            Console.Write("\n\n Masukkan Jumlah Elemen: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] siti = new int[max];
            for (int i = 0; i < max; i++)
            {
                Console.Write("\n Masukkan Elemen ke-[" + ( i + 1 ) + "]: ");
                siti[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Masukkan Array: ");
            for (int k = 0; k < siti.Length; k++)
                Console.Write(siti[k] + " ");
            Console.Write("\n");
            for (int i = 1; i < siti.Length; i++)
            {
                int SL = i;
                while (SL > 0)
                {
                    if (siti[SL - 1] > siti[SL])
                    {
                        int temp = siti[siti[SL - 1] - 1];
                        siti[SL - 1] = siti[SL];
                        siti[SL] = temp;
                        SL--;
                    }
                    else
                        break;
                }
                Console.Write("Perulangan " + i.ToString() + ": ");
                for (int k = 0; k < max; k++)
                    Console.Write(siti[k] + " ");
                Console.Write("\n");
            }
            Console.Write("\n\n Urutan Angka adalah sebagai berikut: \n\n");
            for (int i = 0; i < max; i++)
            {
                Console.Write("Urutan Elemen ke-[" + (i + 1).ToString() + "]");
                Console.Write(siti[i]);
                Console.Write("\n");
            }
            return 0;
        }

    }
    
    }
}
