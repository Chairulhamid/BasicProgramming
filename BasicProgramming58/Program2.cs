using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming58
{
    class Program2 
    { //Merupakan Class dari program kedua yaitu program2, menjalankan pilihan kedua.
        public void Jalankan()
        {

            Console.Clear();
            Console.WriteLine("\t==================================================");
            Console.WriteLine("\t\tAPLIKASI PERHITUNGAN NILAI MAHASISWA");
            Console.WriteLine("\t==================================================");
            Console.Write("\n");
            double[] nilaiIpk = new double[5] { 3.00, 2.87, 3.25, 3.65, 4.00 }; //data nilai ditampung dalam bentuk array
            string[] nmMhs = { "CHAIRUL", "HAMID", "CACA", "SALSA", "RAHMA" }; //data nama mahasiswa ditampung dalam bentuk array
            Console.Write("\n");
            Console.Write("Cari Nama Mahasiswa : ");
            string mahasiswa = Console.ReadLine().ToUpper();
            Console.Write("============================\n");

            //Asumsikan Nilai Awal
            bool ada = false;
            int index = 0;

            // Looping for untuk mencari data mahasiswa
            for (int i = 0; i < nmMhs.Length; i++)
            {
                if (mahasiswa == nmMhs[i])
                {
                    index = i;
                    ada = true;
                    break;
                }
            }
            // Logika menentukan predikat mahasiswa dengan logika IF
            if (ada)
            {
                Console.WriteLine("\n Data IPK Mahasiswa");
                Console.Write("=====================\n");
                Console.WriteLine("Nama mahasiswa       : " + nmMhs[index]);
                Console.WriteLine("Nilai Ipk mahasiswa  : " + nilaiIpk[index]);
                if (nilaiIpk[index] < 3.00)
                {
                    Console.WriteLine("Keterangan        :  Memuaskan \n");
                }
                else if (nilaiIpk[index] >= 3.00 && nilaiIpk[index] < 3.30)
                {
                    Console.WriteLine("Keterangan         : Sangat Memuaskan \n");
                }
                else if (nilaiIpk[index] >= 3.30 && nilaiIpk[index] < 3.50)
                {
                    Console.WriteLine("Keterangan        : Pujian \n");
                }
                else if (nilaiIpk[index] >= 3.50)
                {
                    Console.WriteLine("Keterangan          : Cumlaude");
                }
                Console.WriteLine("");
                Console.Write("Press any key to continue . . . \n");
                Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine("\t==================================================");
                Console.WriteLine("\t\tAPLIKASI PERHITUNGAN NILAI MAHASISWA");
                Console.WriteLine("\t==================================================");
                Console.Write("\n");
                Console.WriteLine("========= MENU PILIHAN =====");
                Console.WriteLine("1. Hitung Nilai Mahasiswa");
                Console.WriteLine("2. Hitung Skor IPK Mahasiswa");
                Console.WriteLine("3. Exit ?");
                Console.WriteLine("Pilih MENU PILIHAN ? 1/2/3");
                Console.WriteLine("=============================");
                Console.WriteLine("Masukkan Pilihan Anda! (1/2/3)");
                int pilih = Convert.ToInt16(Console.ReadLine());
                if (pilih == 1)
                {
                    Program1 proses = new Program1();
                    proses.Eksekusi();
                }
                if (pilih == 2)
                {
                    Program2 proses2 = new Program2();
                    proses2.Jalankan();
                }
                else
                {
                    Console.Clear();
                    Console.Write("\n\t\t\tAnda Exit !! \n");
                    Console.Write("\tTerima Kasih Telah menggunakan Program Ini!!! \n");
                    Console.Write("\t============================================== \n");
                    Console.WriteLine("\t\t\tPILIH CLOSE!!!");
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("Data Tidak Ketemu, Coba lagi");
                ada = false;

                Console.Write("Apakah Ingin liat daftar mahasiswa ?(Yes/No)...\n");
                string daftarNama = Console.ReadLine();
                if (daftarNama == "Yes")
                {
                    Console.Clear();
                    Console.WriteLine("\t==================================================");
                    Console.WriteLine("\t\tAPLIKASI PERHITUNGAN NILAI MAHASISWA");
                    Console.WriteLine("\t==================================================");
                    Console.Write("\n");
                    Console.WriteLine("\t\t---DAFTAR MAHASISWA--- \n");
                    for (int b = 0; b <= nmMhs.Length; b++)
                    {
                        Console.WriteLine("Nama Mahasiswa ke-" + b + " atas nama " + nmMhs[b] + "\n");
                    }
                }



            }


        }



    }
}
