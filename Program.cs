namespace palindrome
{
    public class MAIN
    {
        public static void Main()
        {
            string p = Console.ReadLine();
            int w = int.Parse(p) ;
            int x = w;
            int y = 0;
            while(x != 0) 
            { 
                y = y * 10 + x % 10;
                x = x / 10;
            }
            if (y == w)
            {
                Console.WriteLine("e palindrome");
            }
            else
            {
                Console.WriteLine("não e palindrome");
            }
        }
    }
}