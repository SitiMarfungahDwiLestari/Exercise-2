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
    class MergeSort
    {
        static public void MainMerge(int[] nomor, int kiri, int tengah, int kanan)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (tengah - 1);
            pos = kiri;
            num = (kanan - kiri + 1);

            while ((kiri <= eol) && (tengah <= kanan))
            {
                if (nomor[kiri] <= nomor[tengah])
                    temp[pos++] = nomor[kiri++];
                else 
                    temp[pos++] = nomor[tengah++];
            }
            while (kiri <= eol)
                temp[pos++] = nomor[kiri++];
            while (tengah <= kanan)
                temp[pos++] = nomor[tengah++];
            for (i = 0; i < num; i++)
            {
                nomor[kanan] = temp[kanan];
                kanan--;
            }
        }
        static public void SortMerge (int[] nomor, int kiri, int kanan)
        {
            int tengah;
            if (kanan > kiri)
            {
                tengah = ( (kanan + kiri) / 2);
                SortMerge (nomor, kiri, tengah);
                SortMerge(nomor, (tengah + 1 ), kanan);
                MainMerge( nomor,kiri,(tengah +1), kanan);
            }
        }
        static void Main (string[]args)
        {
            Console.Write("\nProgram untuk mengurutkan data Array menggunakan Merge Sort");
            Console.Write("\n\n Masukkan Jumlah Elemen: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] nomor = new int[max];
            for (int i = 0; i < max; i++)
            {
                Console.Write("\nMasukkan elemen ke-[" + (i + 1).ToString() + "]");
                nomor[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Masukkan array: ");
            Console.Write("\n");
            for (int k = 0; k < max; k++)
            {
                Console.Write(nomor[k] + " ");
                Console.Write("\n");
            }
            Console.WriteLine("MergeSort By Recursive Method");
            SortMerge(nomor, 0, max - 1);
            for (int i = 0; i < max; i++)
                Console.WriteLine(nomor[i]);
            Console.ReadLine();

        }
    }
}
