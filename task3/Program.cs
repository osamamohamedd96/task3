using System.Reflection;

namespace task3
{
    internal class Program
    {
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);

        }
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        static void AddBonusPagesByRef(ref int pages)
        { 
            pages += 50; 
        }
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Pages: " + pages);
        }
        static void PrintAllTitles(params string[] titles)
        {
            for (int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine(titles[i]);
            }
        }
        static void Main(string[] args)
        {
            #region Q1
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            #endregion
            #region Q2
            int[,] shelfCopies = {{ 3, 5 },
                                  { 1, 4} };
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion
            #region Q3
            PrintWelcomeMessage();
            #endregion
            #region Q4
            PrintBookTitle("Clean Code");
            #endregion
            #region Q5
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
            #endregion
            #region Q6
            double[] prices2 = { 25.5, 40.0 };
            Console.WriteLine(prices2[0]);
            #endregion
            #region Q7
            AddBonusPagesByRef(ref pages);
            Console.WriteLine(pages);
            #endregion
            #region Q8
            ReplaceArray(ref prices);
            Console.WriteLine(prices.Length);
            #endregion
            #region Q9
            double price;

            if (TryGetPrice("Clean Code", out price))
            {
                Console.WriteLine(price);
            }
            #endregion
            #region Q10
            PrintBookInfo("Clean Code");
            PrintBookInfo("C# Basics", 450);
            #endregion
            #region Q11
            PrintBookInfo(pages: 500, title: "C#");

            #endregion
            #region Q12
            PrintAllTitles("Clean Code", "Atomic Habits", "The Pragmatic Programmer");
            #endregion

        }
    }
}
