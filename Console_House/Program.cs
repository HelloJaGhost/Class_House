namespace Street
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House(House1SetAddress());
            House house2 = new House(House2SetAddress());
            while (true)
            {
                string operation = Menu();
                while (true)
                {
                    try
                    {
                        Console.WriteLine();
                        switch (operation)
                        {
                            case "address1":
                                house1 = ChangeAddress(house1);
                                Console.WriteLine();
                                break;
                            case "name1":
                                house1.nickname = HouseSetName();
                                Console.WriteLine();
                                break;
                            case "address2":
                                house2 = ChangeAddress(house2);
                                Console.WriteLine();
                                break;
                            case "name2":
                                house2.nickname = HouseSetName();
                                Console.WriteLine();
                                break;
                            case "compare":
                                bool comparer = house1.adress.Equals(house2.adress);
                                if (comparer == true)
                                    Console.WriteLine("Addresses are equal");
                                else
                                {
                                    Console.WriteLine("Addresses are different");
                                }
                                Console.WriteLine();
                                break;
                            case "print1":
                                house1.Print();
                                break;
                            case "print2":
                                house2.Print();
                                break;
                            default:
                                throw new ArgumentException("Wrong operation");
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Format exception");
                    }
                    break;
                }
            }
        }

        static string House1SetAddress()
        {
            Console.WriteLine("Enter 1 house adress");
            string adress1 = Console.ReadLine();
            return adress1;
        }
        static string House2SetAddress()
        {
            Console.WriteLine("Enter 2 house adress");
            string adress2 = Console.ReadLine();
            return adress2;
        }
        static string HouseSetName()
        {
            Console.WriteLine("Enter a house name");
            string name = Console.ReadLine();
            return name;
        }
        static House ChangeAddress(House house)
        {
            string newadress;
            while (true)
            {
                Console.WriteLine("Enter new adress");
                newadress = Console.ReadLine();
                if (newadress.Length >= 5)
                    break;
                else
                {
                    Console.WriteLine("Adress is too short");
                }
            }    
            House newhouse = new House(newadress);
            return newhouse;
        }
        static string Menu()
        {
            Console.WriteLine("address1 - Change house 1 address");
            Console.WriteLine("address2 - Change house 2 address");
            Console.WriteLine("name1 - Set house 1 name");
            Console.WriteLine("name2 - Set house 2 name");
            Console.WriteLine("compare - Compare addresses");
            Console.WriteLine("print1 - Print data about house 1");
            Console.WriteLine("print2 - Print data about house 2");
            string operation = Console.ReadLine();
            return operation;
        }
    }
}