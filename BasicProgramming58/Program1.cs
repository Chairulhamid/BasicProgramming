using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming58
{
    class Program1 : Input
    {
        public void Eksekusi()
        {//method untuk melakukan Eksekusi data.
            Console.Clear();
            Console.WriteLine("\t==================================================");
            Console.WriteLine("\t\tAPLIKASI PERHITUNGAN NILAI MAHASISWA");
            Console.WriteLine("\t==================================================");
            Console.Write("\n");
            Input input = new Input();
            Console.Write("Jumlah Mahasiswa akan dinilai =  ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("===================================");
            Console.Write("\n");
            for (i = 1; i <= n; i++)//melakukan perulangan sejumlah berapa banyak data Mahasiswa yang di inputkan dengan perulangan FOR;
            {
                Console.WriteLine("< Mahasiswa ke-" + i + " >\n");
                Console.Write("Nama Mahasiswa = ");
                input.Nama[i] = Console.ReadLine();
                Console.Write("NIM Mahasiswa = ");
                input.nim[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mata Pelajaran = ");
                input.mtPelajaran[i] = Console.ReadLine();
                Console.Write("Nilai Tugas = ");
                input.nTugas[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nilai Quiz = ");
                input.nQuiz[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nilai UTS = ");
                input.nUts[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nilai UAS = ");
                input.nUas[i] = Convert.ToInt32(Console.ReadLine());
                input.nAkhir[i] = (input.nTugas[i] + input.nQuiz[i] + input.nUts[i] + input.nUas[i]) / 4;
                Console.WriteLine();
                if (input.nAkhir[i] <= 40.9)//Decision untuk menentukan Nilai Akhir,grade dan keterangan dari seluruh nilai.
                {
                    input.grade[i] = "E";
                    input.keterangan[i] = "Belum Tuntas";
                }
                else if (input.nAkhir[i] >= 41 && input.nAkhir[i] <= 55.9)
                {
                    input.grade[i] = "D";
                    input.keterangan[i] = "Belum Tuntas";
                }
                else if (input.nAkhir[i] > 56 && input.nAkhir[i] <= 65.9)
                {
                    input.grade[i] = "C";
                    input.keterangan[i] = "Belum Tuntas";
                }
                else if (input.nAkhir[i] > 65 && input.nAkhir[i] <= 79.9)
                {
                    input.grade[i] = "B";
                    input.keterangan[i] = "Tuntas";
                }
                else if (input.nAkhir[i] > 80)
                {
                    input.grade[i] = "A";
                    input.keterangan[i] = "Tuntas";
                }

            }
            Console.Clear();
            Console.WriteLine("\t==================================================");
            Console.WriteLine("\t\tAPLIKASI PERHITUNGAN NILAI MAHASISWA");
            Console.WriteLine("\t==================================================");
            Console.Write("\n");
            for (i = 1; i <= n; i++)//melakukan perulangan sejumlah berapa banyak data Mahasiswa yang di inputkan dengan perulangan FOR;
            {
                Console.WriteLine("Data Mahasiswa ke = " + i);
                Console.WriteLine("\n");
                Console.WriteLine("Nama Mahasiswa = " + input.Nama[i]);
                Console.WriteLine("NIM Mahasiswa = " + input.nim[i]);
                Console.WriteLine("Nama Mata Pelajaran = " + input.mtPelajaran[i]);
                Console.WriteLine("Nulai Tugas = " + input.nTugas[i]);
                Console.WriteLine("Nilai Quiz = " + input.nQuiz[i]);
                Console.WriteLine("NIlai Uts = " + input.nUts[i]);
                Console.WriteLine("Nilai Uas = " + input.nUas[i]);
                Console.WriteLine("Nilai Akhir = " + input.nAkhir[i]);
                Console.WriteLine("Nilai Angka = " + input.grade[i]);
                Console.WriteLine("Keterangan = " + input.keterangan[i]);
                Console.Write("\n");
                Console.WriteLine("");
                Console.Write("Press any key to continue . . . \n");
                Console.ReadKey(true);
            }
            Console.Clear();
            Console.WriteLine("\t==================================================");
            Console.WriteLine("\t\tAPLIKASI PERHITUNGAN NILAI MAHASISWA");
            Console.WriteLine("\t==================================================");
            Console.Write("\n");

            //menampilkan encapsulation untuk menampilkan tipe data yang di private
            Program3 program3 = new Program3();
            program3.setnamaUniveristas("\t------------UNIVERSITAS PUTRA INDONESIA-----------\n");
            Console.WriteLine(program3.getnamaUniversitas());
            Console.Write("\n");

            Console.WriteLine("========= MENU PILIHAN =========");
            Console.WriteLine("1. Hitung Nilai Mahasiswa");
            Console.WriteLine("2. Hitung Skor IPK Mahasiswa");
            Console.WriteLine("3. Exit ?");
            Console.WriteLine("Pilih MENU PILIHAN ? 1/2/3");
            Console.WriteLine("================================");
            Console.WriteLine("Masukkan Pilihan Anda! (1/2/3)");
            pilih = Convert.ToInt16(Console.ReadLine());
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
        }
    }
}
