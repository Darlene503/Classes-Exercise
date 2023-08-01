namespace Classes
{

    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();

            myCar.Make = "Volkwagon";
            myCar.Model = "Golf TDI";
            myCar.Year = 2015;

            Console.WriteLine($"Make: {myCar.Make} Model: {myCar.Model} Year: {myCar.Year}");


        }

    }

}










