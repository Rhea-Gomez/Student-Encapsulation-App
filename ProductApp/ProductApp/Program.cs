namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(101, "Fan", 1400, 0.23);
            Console.Write(product1.ToString());
            Console.WriteLine("\nFinal cost after discount: Rs " + product1.CostAfterDiscount());
            Console.WriteLine();

            Product product2 = new Product(102, "Tubelight", 950, 0.15);
            Console.Write(product2.ToString());
            Console.WriteLine("\nFinal cost after discount: Rs " + product2.CostAfterDiscount());
        }
    }
}
