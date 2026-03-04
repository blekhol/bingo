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
		int[] talalatok;

		public BingoJatekos(string nev, string[] kartya)
		{
			this.nev = nev;
			this.kartya = kartya;
			this.talalatok = new int[25];
			for (int i = 0;	i < talalatok.Length; i++)
			{
				talalatok[i] = 0;
			}
			talalatok[12] = 1;
		}

		public string Nev { get => nev; }
		public string[] Kartya { get => kartya; }
		public int[] Talalatok { get => talalatok; set => talalatok = value; }

		public void SorsoltSzamotJelol(int szam)
		{
			for (int i = 0; i < kartya.Length; i++)
			{
				if (int.TryParse(kartya[i], out int kartyaSzam) && kartyaSzam == szam)
				{
					talalatok[i] = 1;
				}
			}
		}

		public bool BingoEll()
		{
			//sorok
			for (int y = 0; y < 5; y++)
			{
				int sor = 0;
				for (int x = 0; x < 5; x++)
				{
					sor += talalatok[(y * 5) + x];
				}

				if (sor == 5)
				{
					return true;
				}
			}

			//oszlopok
			for (int x = 0; x < 5; x++)
			{
				int oszlop = 0;
				for (int y = 0; y < 5; y++)
				{
					oszlop += talalatok[(y * 5) + x];
				}

				if (oszlop == 5)
				{
					return true;
				}
			}

			//átlók
			int atlo = 0;
			for (int i = 0; i < 5; i++)
			{
				atlo += talalatok[(i * 5) + i];
			}

			if (atlo == 5)
			{
				return true;
			}

			atlo = 0;
			int atloy = 0;
			int atlox = 4;
			while (atloy < 5)
			{
				atlo += talalatok[(atloy * 5) + atlox];
				atloy++;
				atlox--;
			}

			if (atlo == 5)
			{
				return true;
			}

			return false;
		}

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
