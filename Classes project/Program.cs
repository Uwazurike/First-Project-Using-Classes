using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Accessories;
using Classes.Apparels;
using Classes.FootWear;




namespace Classes_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Apparels inStock = new Apparels();
            inStock.NumPants = 15;
            inStock.NumTshirts = 10;
            inStock.HasJackets = true; ;
            inStock.HasPants = true; 
            inStock.HasTshirts = true;

            FootWear inShop = new FootWear();
            inShop.HasLoafers = true;
            inShop.NumSandals = 20;
            inShop.HasSandals = true;
            inShop.HasSlippers = true;
            inShop.NumLoafers = 17;

            Accessories atShop = new Accessories();
            atShop.WatchTypes = ("Rolex, Movado & G- Shock,");
            atShop.HasHats = false;
            atShop.HasBags = false;
            atShop.NumWatches = 30;
            atShop.HasWatches = true;

            Console.Title = ("Clothing store Inventory app v1\n");
            Console.WriteLine("Welcome To Iyke's Clothing Store\n");
            Console.WriteLine("This is what we have in our inventory so far\n");
            Console.WriteLine(string.Format("We have {0} Pants, {1} Sandals, {2} T-Shirts, as well as {3} Watches",
            inStock.NumPants, inShop.NumSandals, inStock.NumTshirts, atShop.WatchTypes));

            Console.WriteLine("\n");
            Console.WriteLine(string.Format("Some Facts\n"));
            Console.WriteLine(string.Format("(1) Our store sells pants: {0}", inStock.HasPants));
            Console.WriteLine("\n");
            Console.WriteLine(string.Format("(2) We sell shirts: {0}", inStock.HasTshirts));
            Console.WriteLine("\n");
            Console.WriteLine(string.Format("(3) We have Loafes in stock: {0}", inShop.HasLoafers));
            Console.WriteLine("\n");
            Console.WriteLine(string.Format("(4) our store sells Sandals: {0}", inShop.HasSandals));
            Console.WriteLine("\n");
            Console.WriteLine(string.Format("(5) We carry velvet Slippers {0}", inShop.HasSlippers));
            Console.WriteLine("\n");
            Console.WriteLine(string.Format("(6) We sell hats: {0}", atShop.HasHats));
            Console.WriteLine("\n");
            Console.WriteLine(string.Format("(7) We sell bags: {0}", atShop.HasBags));
            Console.WriteLine("\n");
            Console.WriteLine(string.Format("(8) We always have watches: {0}", atShop.HasWatches));
            Console.WriteLine("\n");

            Console.WriteLine(string.Format("(10) We currently {0} Hats, {1} Watches in stock ", atShop.NumHats, atShop.NumWatches));

            Console.ReadLine();
        }
    }

}

