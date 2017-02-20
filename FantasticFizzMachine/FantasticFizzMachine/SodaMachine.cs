using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticFizzMachine
{
    public class SodaMachine
    {
        double price;
        public SodaInventory sodaInventory;
        public SodaMachine()
        {
            sodaInventory = new SodaInventory();
        }
        public void RunMachine()
        {//all methods that run the machine
            WelcomeCustomer();
            sodaInventory.DisplayInventory();
            string quarterNumber = TakeQuarter();
            string dimeNumber = TakeDime();
            string nickelNumber = TakeNickel();
            string pennyNumber = TakePenny();
            string totalCoins = AddTotalCoins(quarterNumber,dimeNumber,nickelNumber,pennyNumber);
            DisplayTotalCoins(totalCoins);
            string playerSelection = TakeSelection();
            double playerSelectionPrice = GetPrice(playerSelection);
            CheckPayment();

        }
        public void WelcomeCustomer()
        {
            Console.WriteLine("Welcome to the FantasticFizz Machine. We carry three soda's, Gross Grape, Ouch Orange, Lame Lemon.\n");
            Console.WriteLine("Prices: \n\nGross Grape: $.60\nOuch Orange: $.35\nLame Lemon: $.06\n");
            Console.WriteLine("You will only be allowed to buy one soda at a time\n");
            Console.WriteLine("The machines inventory will be displayed after pressing enter");
            Console.ReadKey();
            Console.Clear();
        }
        public void SodaStartingInventory(Quarter quarter, Dime dime, Nickel nickel, Penny penny)
        {
            for (int i = 0; i < 20; i++)
            {
                sodaInventory.money[0].Add(quarter);
            }
            for (int i = 0; i < 10; i++)
            {
                sodaInventory.money[1].Add(quarter);
            }
            for (int i = 0; i < 20; i++)
            {
                sodaInventory.money[2].Add(quarter);
            }
            for (int i = 0; i < 50; i++)
            {
                sodaInventory.money[3].Add(quarter);
            }
        }
        public string TakeQuarter()
        {
            string quarterNumber;
            Console.WriteLine("How many quarters would you like to enter?");
             quarterNumber = Console.ReadLine();
            return quarterNumber;
        }
        public string TakeDime()
        {
            string dimeNumber;
            Console.WriteLine("How many dimes would you like to enter?");
            dimeNumber = Console.ReadLine();
            return dimeNumber;
        }
        public string TakeNickel()
        {
            string nickelNumber;
            Console.WriteLine("How many nickels would you like to enter?");
            nickelNumber = Console.ReadLine();
            return nickelNumber;
        }
        public string TakePenny()
        {
            string pennyNumber;
            Console.WriteLine("How many Quarters would you like to enter?");
            pennyNumber = Console.ReadLine();
            return pennyNumber;
        }
        public string AddTotalCoins(string quarter, string dime, string nickel, string penny)
        {
            string totalcoins = quarter + dime + nickel + penny;
            return totalcoins;
        }
        public void DisplayTotalCoins(string totalCoins)
        {
            Console.WriteLine($"The total amount of coins you have are: {totalCoins}");
        }
        public string TakeSelection()
        {
            Console.WriteLine("What would you like to buy, 'grape', 'orange', or 'lemon'?");
            string playerSelection = Console.ReadLine();
            return playerSelection;
        }
        public double GetPrice(string playerSelection)
        {
             
            if (playerSelection == "grape")
            {
                price = new GrapeSoda().price;
            }
            else if (playerSelection == "orange")
            {
                price = new OrangeSoda().price;
            }
            else if (playerSelection == "lemon")
            {
                price = new LemonSoda().price;
            }
            return price;
        }
        public void CheckPayment()
        {//set to bool

            //if playerPayment < inventory.grapesoda[], tell player return false; set to variable paymentCheck
            //else return true;
        }
        public void CheckInventory()
        {// set to bool 
            //if playerSelection is < than inventory.grapesoda[], tell player return false; set to variable inventoryCheck
            //else return true;
        }
        public void DispenseSelection(/*bool paymentCheck, bool inventoryCheck*/)
        {
            //if ((paymentCheck = true) && (inventoryCheck = true))
                //{
                    //inventory.grapeSoda.Remove;
                //}
        }
        public void DispenseChange(double playerPayment)
        {
            //if (playerpayment == inventory.grapeSoda.price)
                //{
                    //return 0;
                //}
           //else
                //{
                    //change = playerPayment - inventory.grapeSoda.price;
                //}
          //return change

        }

    }
}
