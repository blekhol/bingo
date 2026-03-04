namespace bingo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BingoJatekos a = BingoJatekos.JatekosFilebol("Andi.txt");
            Console.WriteLine(a.Nev);
            foreach (var item in a.Kartya)
            {
                Console.WriteLine(item);
			}
            foreach (var item in a.Talalatok)
            {
                Console.WriteLine(item);
			}
		}
    }
}
