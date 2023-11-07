using CarParking.CORE;
using System;
using System.Diagnostics;
using System.Globalization;

namespace CarParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Green;
            text_writer(ReturnTypes.welcome);
            text_writer(ReturnTypes.pleaseSelect);
            Console.ForegroundColor = ConsoleColor.White;
            text_writer(ReturnTypes.input1); //car
            text_writer(ReturnTypes.input2); //truck
            text_writer(ReturnTypes.input3); //working machine
            text_writer(ReturnTypes.input4); //exit 

            Console.Write(ReturnTypes.yourSelection + string.Empty);
            string input = Console.ReadLine() ?? "5".ToString();
            input = input.Trim();

            int selection_id = input == null || input == "" || input.Any(char.IsLetter) ? 5 : int.Parse(input);
            selection_id = int.TryParse(input, out selection_id) ? selection_id : 5;
            selection_id = selection_id > 5 ? 5 : selection_id;

            create_model(selection_id);
        }

        private static void text_writer(string text)
        {
            Console.WriteLine(text);
        }
        private static void create_model(int selection)
        {
            Parking Parking = new Parking();
            Parking.prices = new Pricing();

            switch (selection)
            {
                case 1:
                    text_writer(ReturnTypes.selected1); //car
                    Parking.type = VehicleType.Car;
                    break;
                case 2:
                    text_writer(ReturnTypes.selected2); //truck
                    Parking.type = VehicleType.Truck;
                    Parking.prices = new Pricing()
                    { Price = 8, EveryNextHourPrice = 2, DailyFixedFee = 8 };
                    break;
                case 3:
                    text_writer(ReturnTypes.selected3); //working machine
                    Parking.type = VehicleType.WorkingMachine;
                    Parking.prices = new Pricing()
                    { Price = 12, EveryNextHourPrice = 3, DailyFixedFee = 8 };
                    break;
                case 4:
                    text_writer(ReturnTypes.exit);
                    Environment.Exit(1);
                    break;
                case 5:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    text_writer(ReturnTypes.incorrectOperation);

                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;

                    Process.Start(Process.GetCurrentProcess().MainModule.FileName);
                    Environment.Exit(1);
                    Environment.Exit(0);
                    break;
                default:
                    text_writer(ReturnTypes.error);
                    Environment.Exit(1);
                    break;

            }
            calculate_price(Parking);
        }

        private static void calculate_price(Parking parking)
        {
            int price = parking.prices.Price;
            int everyNextHourPrice = parking.prices.EveryNextHourPrice;
            int dailyFixedFee = parking.prices.DailyFixedFee;

            int total = 0;
            int hours = 0;
            int days = 0;

            Console.WriteLine(ReturnTypes.inputParkTime);
            string input = Console.ReadLine() ?? "0".ToString();
            input = input.Trim();

            int input_hour = input == null || input == "" || input.Any(char.IsLetter) ? 0 : int.Parse(input);
            input_hour = int.TryParse(input, out input_hour) ? input_hour : 0;
            if (input_hour < 2) text_writer(ReturnTypes.lessThanMinimumTime);
            input_hour = input_hour > 2 ? input_hour : 2;

            hours = input_hour;
            days = (hours / 24) + 1;

            for (int i = 0; i < days; i++)
            {
                int remainingTime = (hours - (i * 24)) == hours ? 24 : (hours - (i * 24));
                remainingTime = remainingTime > 24 ? remainingTime = 24 : remainingTime;
                remainingTime = remainingTime == 1 ? 2 : remainingTime;
      

                if (remainingTime >= 2)
                {
                    remainingTime = remainingTime - (2 * (i + 1));
                    total += parking.prices.Price;
                
                }
                //test
               
                    if (remainingTime >= parking.prices.DailyFixedFee)
                        total += (parking.prices.DailyFixedFee * parking.prices.EveryNextHourPrice) - 2;
              
      
            }

            Console.WriteLine(ReturnTypes.totalPrice + total.ToString("C", new CultureInfo("tr-TR")));
        }


    }
}
