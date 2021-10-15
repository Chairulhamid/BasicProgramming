using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming58
{
    class Program3
    {
		public string fakulty;
		private string namaUniversitas; //data private untuk encapsulation
		protected string namaKelas;

		//ini adalah method void serta encapsulation data nama Universitas
		public void setnamaUniveristas(string n)
		{
			namaUniversitas = n;
		}

		// ini adalah method non void encapsulation untuk get nama universitas
		public string getnamaUniversitas()
		{
			return namaUniversitas;
		}
	}
}
