using System;

namespace Tugas1
{
    class Calculator
    {
        public static int Tambah(int x, int y) => x + y;
        public static int Kurang(int x, int y) => x - y;
        public static int Kali(int x, int y) => x * y;
        public static double Bagi(double x, double y) => (double)x / y;
    }

    class BangunDatar
    {
        public int KelilingPersegi(int sisi) => 4 * sisi;
        public int LuasPersegi(int sisi) => sisi * sisi;
    }

    class BangunRuang
    {
        public int VolumeKubus(int sisi) => sisi * sisi * sisi;
        public int LuasPermukaanKubus(int sisi) => 6 * sisi * sisi;
    }

    class Zodiak
    {
        public void TampilkanZodiak(int bulan, int tanggal)
        {
            string hasilZodiak = "";
            if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18)) hasilZodiak = "Aquarius";
            else if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20)) hasilZodiak = "Pisces";
            else if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19)) hasilZodiak = "Aries";
            else if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20)) hasilZodiak = "Taurus";
            else if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20)) hasilZodiak = "Gemini";
            else if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22)) hasilZodiak = "Cancer";
            else if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22)) hasilZodiak = "Leo";
            else if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22)) hasilZodiak = "Virgo";
            else if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22)) hasilZodiak = "Libra";
            else if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21)) hasilZodiak = "Scorpio";
            else if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21)) hasilZodiak = "Sagittarius";
            else if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19)) hasilZodiak = "Capricorn";
            else hasilZodiak = "Tanggal atau bulan tidak valid!";

            Console.WriteLine($"\nZodiak Anda adalah: {hasilZodiak}");
        }
    }

    class MenuUtama
    {
        // Fungsi pembungkus untuk menjalankan seluruh menu interaktif
        public void JalankanMenu()
        {
            bool berjalan = true;
            BangunDatar persegi = new BangunDatar();
            BangunRuang kubus = new BangunRuang();
            Zodiak zodiak = new Zodiak();

            while (berjalan)
            {
                Console.WriteLine("\n=========================");
                Console.WriteLine("||     MENU UTAMA      ||");
                Console.WriteLine("=========================");
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Bangun Datar (Persegi)");
                Console.WriteLine("3. Bangun Ruang (Kubus)");
                Console.WriteLine("4. Cek Zodiak");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilih menu (1-5): ");

                string pilihan = Console.ReadLine();
                Console.WriteLine("-------------------------");

                switch (pilihan)
                {
                    case "1":
                        Console.Write("Masukkan angka pertama: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan angka kedua: ");
                        int b = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nHasil Tambah : {Calculator.Tambah(a, b)}");
                        Console.WriteLine($"Hasil Kurang : {Calculator.Kurang(a, b)}");
                        Console.WriteLine($"Hasil Kali   : {Calculator.Kali(a, b)}");
                        Console.WriteLine($"Hasil Bagi   : {Calculator.Bagi(a, b)}");
                        break;

                    case "2":
                        Console.Write("Masukkan panjang sisi persegi: ");
                        int sisiPersegi = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nKeliling Persegi = {persegi.KelilingPersegi(sisiPersegi)}");
                        Console.WriteLine($"Luas Persegi     = {persegi.LuasPersegi(sisiPersegi)}");
                        break;

                    case "3":
                        Console.Write("Masukkan panjang sisi kubus: ");
                        int sisiKubus = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nVolume Kubus        = {kubus.VolumeKubus(sisiKubus)}");
                        Console.WriteLine($"Luas Permukaan Kubus = {kubus.LuasPermukaanKubus(sisiKubus)}");
                        break;

                    case "4":
                        Console.Write("Masukkan Bulan (1-12): ");
                        int bulan = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan Tanggal (1-31): ");
                        int tanggal = int.Parse(Console.ReadLine());

                        zodiak.TampilkanZodiak(bulan, tanggal);
                        break;

                    case "5":
                        Console.WriteLine("Terima kasih! Program selesai.");
                        berjalan = false;
                        break;

                    default:
                        Console.WriteLine("Pilihan tidak valid! Silakan pilih 1-5.");
                        break;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Memanggil fungsi utama pembungkus menu
            MenuUtama menu = new MenuUtama();
            menu.JalankanMenu();
        }
    }
}