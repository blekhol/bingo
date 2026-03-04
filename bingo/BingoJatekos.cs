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


	}
}
