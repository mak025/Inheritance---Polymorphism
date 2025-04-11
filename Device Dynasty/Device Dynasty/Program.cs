namespace Device_Dynasty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LaptopDevices DellLaptop = new LaptopDevices
            (
                "Dell",
                "Dell Inc.",
                "XPS 13",
                "Laptop",
                "Windows 10",
                "10.0",
                13
            );

            LaptopDevices MacBook = new LaptopDevices
            (
                "Apple",
                "Apple Inc.",
                "MacBook Pro",
                "Laptop",
                "macOS",
                "11.0",
                16
            );

            LaptopDevices HP = new LaptopDevices
            (
                "HP",
                "Hewlett-Packard",
                "Spectre x360",
                "Laptop",
                "Windows 10",
                "10.0",
                15
            );

            MobileDevices iPhone = new MobileDevices
            (
                "Apple",
                "Apple Inc.",
                "iPhone 14",
                "Mobile",
                "iOS",
                "16.0"
            );

            MobileDevices Samsung = new MobileDevices
            (
                "Samsung",
                "Samsung Electronics",
                "Galaxy S21",
                "Mobile",
                "Android",
                "12.0"
            );

            MobileDevices OnePlus = new MobileDevices
            (
                "OnePlus",
                "OnePlus Technology",
                "OnePlus 9",
                "Mobile",
                "Android",
                "12.0"
            );
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Here are the current laptop products we have in store:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Laptop 1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(DellLaptop.getLaptopDetails());
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Laptop 2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(MacBook.getLaptopDetails());
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Laptop 3");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(HP.getLaptopDetails());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Here are the current mobile products we have in store:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Mobile 1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(iPhone.getMobileDetails());
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Mobile 2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Samsung.getMobileDetails());
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Mobile 3");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(OnePlus.getMobileDetails());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
