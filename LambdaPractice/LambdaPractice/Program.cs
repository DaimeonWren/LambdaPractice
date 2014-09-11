using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            var products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles", "shoes1", "shoes2"};
            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            List<string> KayakProducts = products.Where(x => x.Contains("Kayak")).ToList();
            //print the kayakProducts to the console using a foreach loop.
            foreach (var item in KayakProducts)
            {
                Console.WriteLine(item);
            }
            List<string> shoeProducts = products.Where(x => x.Contains("Shoes")).ToList();
            foreach (var item in shoeProducts)
            {
                Console.WriteLine(item);
            }
            List<string> ballBall = products.Where(x => x.Contains("Balls")).ToList();
            foreach (var item in ballBall)
            {
                Console.WriteLine(item);
            } Console.WriteLine(string.Join(", ", ballBall.OrderBy(x => x)));

            products.Add("Futbol");
            Console.WriteLine(products.OrderByDescending(x => x.Length).First());
            Console.WriteLine(products.OrderByDescending(x => x.Length).Last());
            Console.WriteLine(products.OrderBy(x => x.Length).ToList()[3]);
          

            //onsole.WriteLine(products.OrderBy(x => x.Length).Skip(3).Take(1));
            //onsole.WriteLine(ballBall.OrderByDescending(x => x.Length).Skip(1).First());
            List<string> Reverse = products.OrderByDescending(x => x.Length)
                foreach (var item in Reverse)
	{
		 Console.WriteLine(item);
	}
            foreach (var item in Reverse);
	{
		  
	}
            
            Console.ReadKey();
        } 
    } 
    // List<string>products.Where(x => x.Tolower().Contains("ball")).ToList();
    // Console.WriteLine(string.Join(", ", ballBall));
}
