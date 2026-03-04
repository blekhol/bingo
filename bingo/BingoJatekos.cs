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

			List<string> mezok = [];

			foreach (var sor in sorok)
			{
				if (sor != "")
				{
					foreach (var mezo in sor.Split(";"))
					{
						if (mezo != "")
						{
							mezok.Add(mezo);
						}
					}
				}
			}

			string nev = filenev.Split(".")[0];

			return new BingoJatekos(nev, mezok.ToArray());
		}
	}
}
