namespace PairImpairBoucle;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes
         * Demandez à l'utilisateur un nombre
         * Dites à l'utilisateur si le nombre fourni est pair ou impair
         * Demandez à l'utilisateur s'il veut proposer un autre nombre
         *  On lui permet de le faire lorsqu'il entre "y". Dans les autres cas, on termine le programme
         */
         Console.WriteLine("choose a number");
         
         int answer = Convert.ToInt32(Console.ReadLine());
         if (answer % 2 == 0) 
         {
             Console. WriteLine ($"{answer} is even");
         }
         else
         {
             Console.WriteLine($"{answer} is odd");
         }
         
    }
}
