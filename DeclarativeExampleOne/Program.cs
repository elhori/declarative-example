public class Program
{
    private static List<double> DoubleList = new List<double>() { 7, 4, 5, 6, 3, 8, 10 };

    public static void Main(string[] args)
    {
        #region Imparative

        Console.WriteLine("Imparative Example");

        foreach (double x in DoubleList)
        {
            Console.WriteLine(SubtractTen(Square(AddOne(x))).ToString());
        }

        #endregion


        #region Declarative

        Console.WriteLine("Declarative Example");
        DoubleList.Select(AddOne).Select(Square).Where(x => x < 70).OrderBy(x => x).Take(2).Select(SubtractTen).ToList()
            .ForEach(x => Console.WriteLine(x.ToString()));

        #endregion
    }

    public static double AddOne(double x)
    {
        return ++x;
    }

    public static double Square(double x)
    {
        return x * x;
    }

    public static double SubtractTen(double x)
    {
        return x - 10;
    }
}