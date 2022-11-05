namespace Street
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        class House
        {
            string adress;
            string nickname;
        }
        static void Menu()
        {
            Console.WriteLine("Show house 1 adress");
            Console.WriteLine("Show house 2 adress");
            Console.WriteLine("Change house 1 name");
            Console.WriteLine("Change house 2 name");
        }
    }
}