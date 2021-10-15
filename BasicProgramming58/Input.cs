using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming58
{
    class Input
    {
        //inisialisasi semua variabel dan menampung nilai yang di inputkan
        private string[] nama = new string[20];
        public double[] nim = new double[50];
        public string[] mtPelajaran = new string[20];
        public double[] nTugas = new double[20];
        public double[] nQuiz = new double[20];
        public double[] nUts = new double[20];
        public double[] nUas = new double[20];
        public double[] nAkhir = new double[20];
        public string[] grade = new string[20];
        public string[] keterangan = new string[30];
        public int i, n = 0;
        public int pilih;
        public string[] Nama
        {
            //melakukan proses enkapsulasi variable nama
            get
            {
                return nama;
            }
            set
            {
                this.nama = value;
            }
        }
    }
    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }

        public User()
        {

        }
        public User(string uName, string pass)
        {
            this.userName = uName;
            this.password = pass;
        }

    }

}
