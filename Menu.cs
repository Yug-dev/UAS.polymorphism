using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BangunRuang
{
    class Menu
    {
        public int pilih;

        public void menu()
        {
            Console.WriteLine("PROGRAM MENGHITUNG LUAS BANGUN RUANG");
            Console.WriteLine("====================================");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Segiempat");
            Console.WriteLine("2. Segpanjang");
            Console.WriteLine("3. Segitiga");
            Console.WriteLine("4. Lingkaran");
            Console.Write("Masukkan Pilihan : ");
            pilih = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (pilih)
            {
                case 1:
                    {
                        Segiempat a = new Segiempat();

                        Console.WriteLine("Menghitung Luas Segiempat");
                        Console.WriteLine("-------------------------");
                        Console.Write("Sisi : ");
                        a.sisi = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas = {0} cm", a.luas_segiempat());

                        break;
                    }
                case 2:
                    {
                        Segipanjang b = new Segipanjang();

                        Console.WriteLine("Menghitung Luas Segipanjang");
                        Console.WriteLine("---------------------------");
                        Console.Write("Panjang : ");
                        b.panjang = (int.Parse(Console.ReadLine()));
                        Console.Write("Lebar   : ");
                        b.lebar = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas    = {0} cm", b.luas_segipanjang());

                        break;
                    }

                case 3:
                    {
                        Segitiga c = new Segitiga();

                        Console.WriteLine("Menghitung Luas Segitiga");
                        Console.WriteLine("------------------------");
                        Console.Write("Alas   : ");
                        c.alas = (int.Parse(Console.ReadLine()));
                        Console.Write("Tinggi : ");
                        c.tinggi = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas   = {0} cm", c.luas_segitiga());

                        break;
                    }
                case 4:
                    {
                        Lingkaran d = new Lingkaran();

                        Console.WriteLine("Menghitung Luas Lingkaran");
                        Console.WriteLine("-------------------------");
                        Console.Write("Jari-Jari : ");
                        d.jarijari = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas       = {0} cm", d.luas_lingkaran());

                        break;
                    }
            }

        }

    }
}