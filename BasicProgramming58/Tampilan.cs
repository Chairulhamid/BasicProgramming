using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming58
{
	class Tampilan : Program3
	{
		//ini merupakan contructor untuk menambahkan ke object
		public Tampilan()
		{
			namaKelas = "Manajemen Informatika-(D3)";
			fakulty = "Ilmu Komputer";
		}
		public void Tampil()
		{
			Console.WriteLine("\n");
			Console.WriteLine("=========================================================================================================");
			Console.WriteLine($" \tPerhitungan Nilai MHS di kelas  {namaKelas}   Fakultas  {fakulty}");
			Console.WriteLine("=========================================================================================================");
		}
	}
}
