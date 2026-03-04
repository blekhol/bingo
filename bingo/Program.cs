namespace bingo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BingoJatekos> jatekosok = [];

            var sr = new StreamReader("./kartyak/nevek.text");
            foreach (var sor in sr.ReadToEnd().Split("\n"))
            {
                if (sor != "")
                {
                    jatekosok.Add(BingoJatekos.JatekosFilebol(sor.Trim()));
                }
            }

			//4.feladat
			Console.WriteLine("4. feladat: Játékosok száma: " + jatekosok.Count);
		}
    }
}
