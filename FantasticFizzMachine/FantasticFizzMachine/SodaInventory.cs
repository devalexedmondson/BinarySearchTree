using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticFizzMachine
{
    public class SodaInventory
    {
        public List<List<Soda>> soda;
        public List<List<Money>> money;
        public List<Soda> grapeSoda;
        public List<Soda> orangeSoda;
        public List<Soda> lemonSoda;
        public List<Money> quarter;
        public List<Money> dime;
        public List<Money> nickel;
        public List<Money> penny;
        public SodaInventory()
        {
            soda = new List<List<Soda>>();
            money = new List<List<Money>>();
            grapeSoda = new List<Soda>();
            orangeSoda = new List<Soda>();
            lemonSoda = new List<Soda>();
            quarter = new List<Money>();
            dime = new List<Money>();
            nickel = new List<Money>();
            penny = new List<Money>();
            soda.Add(grapeSoda);
            soda.Add(orangeSoda);
            soda.Add(lemonSoda);
            money.Add(quarter);
            money.Add(dime);
            money.Add(nickel);
            money.Add(penny); 
        
        }
        public void AddGrapeSoda(GrapeSoda grapeSoda)
        {
            soda[0].Add(grapeSoda);
        }
        public void AddOrangeSoda(OrangeSoda orangeSoda)
        {
            soda[1].Add(orangeSoda);
        }
        public void AddLemonSoda(LemonSoda lemonSoda)
        {
            soda[2].Add(lemonSoda);
        }
        public void AddQuarter(Quarter quarter)
        {
            money[0].Add(quarter);
        }
        public void AddDime(Dime dime)
        {
            money[1].Add(dime);
        }
        public void AddNickel(Nickel nickel)
        {
            money[2].Add(nickel);
        }
        public void AddPenny(Penny penny)
        {
            money[3].Add(penny);
        }
        public void DisplayInventory()
        {
            Console.WriteLine($"Fantastic Fizz Machine Inventory:\n\n Gross Grape: {soda[0].Count}\n Ouch Orange: {soda[1].Count}\n Lame Lemon: {soda[2].Count} \nQuarters: {money[0].Count}\nDimes: {money[1].Count}\nNickel: {money[2].Count}\nPenny: {money[3].Count}\n");
            Console.ReadKey();
        }
    }
}
