using BasicProgramming58;
using System;
using System.Collections.Generic;

namespace BasicProgramming58
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Mengambil object dari void tampilan
            Tampilan tampilan = new Tampilan();
            tampilan.Tampil();

            //menampilkan encapsulation untuk menampilkan tipe data yang di private
            Program3 program3 = new Program3();
            program3.setnamaUniveristas("\t\t\t\t---------UNIVERSITAS PUTRA INDONESIA---------\n");
            Console.WriteLine(program3.getnamaUniversitas());

            // untuk polymerism overide
            Judul obj;
            obj = new Judul2();
            obj.Title();

            //Untuk Abstract menampilkan nama penulis dan bulan
            Abstract1 abst = new Abstract1();
            abst.penulis();

            // untuk polymerism overloading
            PembuatanOverloading obj2 = new PembuatanOverloading();
            Console.Write(obj2.Buat("Created "));
            Console.Write(obj2.Buat(2021));
            Console.Write("\n");

            //nampung data List data
            List<User> ListUser = new List<User>();
            ListUser.Add(new User() { userName = "hamid", password = "123" });
            Console.WriteLine("==========================");
            Console.Write("\n");

            Console.WriteLine("\t\t======= Login User =======");
            Console.WriteLine("\t\t==========================\n");
            Console.WriteLine("\nUsername = hamid");
            Console.WriteLine("Password = 123\n\n");
            Console.Write("Input Username   : ");
            string user = Console.ReadLine();

            Console.Write("Input Password : ");
            string pass = Console.ReadLine();
            if (ListUser.Exists(item => item.userName == user && item.password == pass))
            {
                Console.WriteLine("\n\t\t====Login Berhasil!!====\n");
                Console.ReadKey();
                Console.Clear();
                Menu prosesMenu = new Menu();
                prosesMenu.MenuU();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Username Tidak Ditemukan");
            }
        }
    }
}

    public class Menu{
        public void MenuU()
        {
        // Mengambil object dari void tampilan
        Tampilan tampilan = new Tampilan();
        tampilan.Tampil();

        //menampilkan encapsulation untuk menampilkan tipe data yang di private
        Program3 program3 = new Program3();
        program3.setnamaUniveristas("\t\t\t\t---------UNIVERSITAS PUTRA INDONESIA---------\n");
        Console.WriteLine(program3.getnamaUniversitas());

        Console.WriteLine("========= MENU PILIHAN =========");
        Console.WriteLine("1. Hitung Nilai Mahasiswa");
        Console.WriteLine("2. Hitung Skor IPK Mahasiswa");
        Console.WriteLine("3. Exit ?");
        Console.WriteLine("Pilih MENU PILIHAN ? 1/2/3");
        Console.WriteLine("================================");
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
            Console.WriteLine("\t==================================================");
            Console.WriteLine("\t\tAPLIKASI PERHITUNGAN NILAI MAHASISWA");
            Console.WriteLine("\t==================================================");
            Console.Write("\n");
            Console.Write("\n\t\t\tAnda Exit !! \n");
            Console.Write("\tTerima Kasih Telah menggunakan Program Ini!!! \n");
            Console.Write("\t============================================== \n");
            Console.WriteLine("\t\t\tTekan Enter!!!");
            Console.WriteLine("\n");
        }
    }

            
        }


    //POLYMORISM OVERRIDE
    public class Judul
    {
        public virtual void Title()
        {
            Console.WriteLine("Judul\n");
        }
    }
    // child dari judul  dikasih overide agar mengubah data yang diwariskan
    public class Judul1 : Judul
    {
        public override void Title()
        {
            Console.WriteLine("aplikasi\n");
        }
    }
    public class Judul2 : Judul1
    {
        public override void Title()
        {
            Console.WriteLine("-----APLIKASI Perhitungan Nilai Mahasiswa-----");
        }
    }
    //POLYMORISM OVERLOADING
    public class PembuatanOverloading
    {

        public string Buat(string created)
        {
            return created;
        }

        public int Buat(int tahun)
        {
            return (tahun);
        }
    }
    // Abstract class
    abstract class Abstract
    {
        // Abstract method 
        public abstract void penulis();
       
    }
    //inheritance dari class Abstract
    class Abstract1 : Abstract
    {
        public override void penulis()
        {
            Console.WriteLine("\nChairul Hamid");
        }
    }


