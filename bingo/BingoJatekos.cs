using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingo
{
	internal class BingoJatekos
	{
		string nev;
		string[] kartya;
		List<int> talalatok; //indexek

		public BingoJatekos(string nev, string[] kartya)
		{
			this.nev = nev;
			this.kartya = kartya;
			this.talalatok = [13];
		}

		public string Nev { get => nev; }
		public string[] Kartya { get => kartya; }
		public List<int> Talalatok { get => talalatok; }

		public static BingoJatekos JatekosFilebol(string filenev)
		{
			var sr = new StreamReader("./kartyak/" + filenev);
			string[] sorok = sr.ReadToEnd().Split("\n");

			string[] kartya = new string[5];

			for (int i = 0; i < kartya.Length; i++)
			{
				kartya[i] = sorok[i];
			}

			string nev = filenev.Split(".")[0];

			return new BingoJatekos(nev, kartya);
		}
	}
}
