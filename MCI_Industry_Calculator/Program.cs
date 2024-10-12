using System;
using System.Threading;

namespace MCI_Industry_Calculator
{
    internal class Program
    {
        public static long totalAluminum = 0;
        public static long totalSteel = 0;
        public static long totalSpecialSteel = 0;


        public static long totalWire1 = 0;
        public static long totalWire2 = 0;
        public static long totalWire3 = 0;
        public static long totalWire4 = 0;

        public static long totalChip1 = 0;
        public static long totalChip2 = 0;
        public static long totalChip3 = 0;
        public static long totalChip4 = 0;
        public static long totalChip5 = 0;
        public static long totalChip6 = 0;

        public static long totalBattery1 = 0;
        public static long totalBattery2 = 0;
        public static long totalBattery3 = 0;



        public static long toCraftWire1 = 0;
        public static long toCraftWire2 = 0;
        public static long toCraftWire3 = 0;
        public static long toCraftWire4 = 0;

        public static long toCraftChip1 = 0;
        public static long toCraftChip2 = 0;
        public static long toCraftChip3 = 0;
        public static long toCraftChip4 = 0;
        public static long toCraftChip5 = 0;
        public static long toCraftChip6 = 0;

        public static long toCraftBattery1 = 0;
        public static long toCraftBattery2 = 0;
        public static long toCraftBattery3 = 0;

        public static string toCraft = "";
        public static long toCraftQuantity = 0;

        public static string doRestart = "";

        static void Main(string[] args)
        {
            Console.Write("Give me an item to craft: ");
            toCraft = Console.ReadLine();

            bool wrongItem = false;

            Console.Write($"Give me how much you want of {toCraft}: ");
            toCraftQuantity = Convert.ToInt64(Console.ReadLine());

            if (toCraft == "wire1")
            {
                toCraftWire1 = toCraftQuantity;
                calcWire1(toCraftWire1);
            }

            else if (toCraft == "wire2")
            {
                toCraftWire2 = toCraftQuantity;
                calcWire2(toCraftWire2);
            }

            else if (toCraft == "wire3")
            {
                toCraftWire3 = toCraftQuantity;
                calcWire3(toCraftWire3);
            }

            else if (toCraft == "wire4")
            {
                toCraftWire4 = toCraftQuantity;
                calcWire4(toCraftWire4);
            }


            else if (toCraft == "chip1")
            {
                toCraftChip1 = toCraftQuantity;
                calcChip1(toCraftChip1);
            }

            else if (toCraft == "chip2")
            {
                toCraftChip2 = toCraftQuantity;
                calcChip2(toCraftChip2);
            }

            else if (toCraft == "chip3")
            {
                toCraftChip3 = toCraftQuantity;
                calcChip3(toCraftChip3);
            }

            else if (toCraft == "chip4")
            {
                toCraftChip4 = toCraftQuantity;
                calcChip4(toCraftChip4);
            }

            else if (toCraft == "chip5")
            {
                toCraftChip5 = toCraftQuantity;
                calcChip5(toCraftChip5);
            }

            else if (toCraft == "chip6")
            {
                toCraftChip6 = toCraftQuantity;
                calcChip6(toCraftChip6);
            }


            else if (toCraft == "battery1")
            {
                toCraftBattery1 = toCraftQuantity;
                calcBattery1(toCraftBattery1);
            }

            else if (toCraft == "battery2")
            {
                toCraftBattery2 = toCraftQuantity;
                calcBattery2(toCraftBattery2);
            }

            else if (toCraft == "battery3")
            {
                toCraftBattery3 = toCraftQuantity;
                calcBattery3(toCraftBattery3);
            }


            else if (toCraft == "computer1")
            {
                calcComputer1(toCraftQuantity);
            }

            else if (toCraft == "computer2")
            {
                calcComputer2(toCraftQuantity);
            }

            else if (toCraft == "computer3")
            {
                calcComputer3(toCraftQuantity);
            }

            else if (toCraft == "computer4")
            {
                calcComputer4(toCraftQuantity);
            }

            else if (toCraft == "computer5")
            {
                calcComputer5(toCraftQuantity);
            }

            else if (toCraft == "computer6")
            {
                calcComputer6(toCraftQuantity);
            }

            else
            {
                Console.WriteLine("\nItem not recognized, valid items:\n");
                Console.WriteLine("wire1, wire2, wire3, wire4");
                Console.WriteLine("chip1, chip2, chip3, chip4, chip5, chip6");
                Console.WriteLine("battery1, battery2, battery3");
                Console.WriteLine("computer1, computer2, computer3, computer4, computer5, computer6");

                wrongItem = true;
            }

            if (!wrongItem)
            {
                printCost();
            }
            
            else
            {
                Console.WriteLine("\nDo you want to restart the program? [Y/N]");
                doRestart = Console.ReadLine();

                if (doRestart.ToLower() == "y")
                {
                    restart();
                }

                else if (doRestart.ToLower() == "n")
                {
                    exit();
                }
            }

            Console.ReadKey();
        }

        public static void restart()
        {
            totalAluminum = 0;
            totalSteel = 0;
            totalSpecialSteel = 0;


            totalWire1 = 0;
            totalWire2 = 0;
            totalWire3 = 0;
            totalWire4 = 0;

            totalChip1 = 0;
            totalChip2 = 0;
            totalChip3 = 0;
            totalChip4 = 0;
            totalChip5 = 0;
            totalChip6 = 0;

            totalBattery1 = 0;
            totalBattery2 = 0;
            totalBattery3 = 0;



            toCraftWire1 = 0;
            toCraftWire2 = 0;
            toCraftWire3 = 0;
            toCraftWire4 = 0;

            toCraftChip1 = 0;
            toCraftChip2 = 0;
            toCraftChip3 = 0;
            toCraftChip4 = 0;
            toCraftChip5 = 0;
            toCraftChip6 = 0;

            toCraftBattery1 = 0;
            toCraftBattery2 = 0;
            toCraftBattery3 = 0;

            toCraft = "";
            toCraftQuantity = 0;

            doRestart = "";

            Console.WriteLine("Clearing console and restarting program...");
            Thread.Sleep(1000);
            Console.Clear();
            Main(null);
        }

        public static void exit()
        {
            Console.WriteLine("Exiting program...");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

        public static void calcWire1(long quantity)
        {
            totalAluminum += quantity;

            toCraftWire1 -= quantity;
        }

        public static void calcWire2(long quantity)
        {
            totalSteel += 2 * quantity;

            toCraftWire1 += 5 * quantity;
            totalWire1 += 5 * quantity;

            toCraftWire2 -= quantity;
        }

        public static void calcWire3(long quantity)
        {
            totalSteel += 25 * quantity;

            toCraftWire1 += 10 * quantity;
            totalWire1 += 10 * quantity;

            toCraftWire2 += 4 * quantity;
            totalWire2 += 4 * quantity;

            toCraftWire3 -= quantity;
        }

        public static void calcWire4(long quantity)
        {
            totalSpecialSteel += 50 * quantity;
            totalSteel += 425 * quantity;

            toCraftWire2 += 20 * quantity;
            totalWire2 += 20 * quantity;

            toCraftWire3 += 10 * quantity;
            totalWire3 += 10 * quantity;

            toCraftWire4 -= quantity;
        }


        public static void calcChip1(long quantity)
        {
            totalAluminum += 5 * quantity;

            toCraftWire1 += 5 * quantity;
            totalWire1 += 5 * quantity;

            toCraftChip1 -= quantity;
        }

        public static void calcChip2(long quantity)
        {
            totalAluminum += 50 * quantity;

            toCraftWire2 += 4 * quantity;
            totalWire2 += 4 * quantity;

            toCraftChip2 -= quantity;
        }

        public static void calcChip3(long quantity)
        {
            totalAluminum += 500 * quantity;

            toCraftWire3 += 5 * quantity;
            totalWire3 += 5 * quantity;

            toCraftChip3 -= quantity;
        }

        public static void calcChip4(long quantity)
        {
            totalSteel += 1500 * quantity;

            toCraftWire4 += 2 * quantity;
            totalWire4 += 2 * quantity;

            toCraftChip4 -= quantity;
        }

        public static void calcChip5(long quantity)
        {
            totalSteel += 17500 * quantity;

            toCraftWire4 += 25 * quantity;
            totalWire4 += 25 * quantity;

            toCraftChip5 -= quantity;
        }

        public static void calcChip6(long quantity)
        {
            totalSpecialSteel += 32500 * quantity;

            toCraftWire4 += 500 * quantity;
            totalWire4 += 500 * quantity;

            toCraftChip6 -= quantity;
        }


        public static void calcBattery1(long quantity)
        {
            totalAluminum += 2 * quantity;

            toCraftWire1 += 2 * quantity;
            totalWire1 += 2 * quantity;

            toCraftBattery1 -= quantity;
        }

        public static void calcBattery2(long quantity)
        {
            totalSteel += 100 * quantity;

            toCraftWire3 += 2 * quantity;
            totalWire3 += 2 * quantity;

            toCraftBattery1 += 100 * quantity;
            totalBattery1 += 100 * quantity;

            toCraftBattery2 -= quantity;
        }

        public static void calcBattery3(long quantity)
        {
            totalSpecialSteel += 5000 * quantity;

            toCraftWire4 += 50 * quantity;
            totalWire4 += 50 * quantity;

            toCraftBattery2 += 100 * quantity;
            totalBattery2 += 100 * quantity;

            toCraftBattery3 -= quantity;
        }

        public static void calcComputer1(long quantity)
        {
            toCraftChip1 += 3 * quantity;
            totalChip1 += 3 * quantity;

            toCraftBattery1 += 5 * quantity;
            totalBattery1 += 5 * quantity;
        }

        public static void calcComputer2(long quantity)
        {
            toCraftChip2 += 3 * quantity;
            totalChip2 += 3 * quantity;

            toCraftBattery1 += 25 * quantity;
            totalBattery1 += 25 * quantity;
        }

        public static void calcComputer3(long quantity)
        {
            toCraftChip3 += 3 * quantity;
            totalChip3 += 3 * quantity;

            toCraftBattery2 += 2 * quantity;
            totalBattery2 += 2 * quantity;
        }

        public static void calcComputer4(long quantity)
        {
            toCraftChip4 += 3 * quantity;
            totalChip4 += 3 * quantity;

            toCraftBattery2 += 15 * quantity;
            totalBattery2 += 15 * quantity;
        }

        public static void calcComputer5(long quantity)
        {
            toCraftChip5 += 3 * quantity;
            totalChip5 += 3 * quantity;

            toCraftBattery2 += 100 * quantity;
            totalBattery2 += 100 * quantity;
        }

        public static void calcComputer6(long quantity)
        {
            toCraftChip6 += 3 * quantity;
            totalChip6 += 3 * quantity;

            toCraftBattery3 += 10 * quantity;
            totalBattery3 += 10 * quantity;
        }

        public static void printCost()
        {
            while (toCraftWire1 > 0 || toCraftWire2 > 0 || toCraftWire3 > 0 || toCraftWire4 > 0 || toCraftChip1 > 0 || toCraftChip2 > 0 || toCraftChip3 > 0 || toCraftChip4 > 0 || toCraftChip5 > 0 || toCraftChip6 > 0 || toCraftBattery1 > 0 || toCraftBattery2 > 0 || toCraftBattery3 > 0)
            {
                if (toCraftWire4 > 0)
                {
                    calcWire4(toCraftWire4);
                }

                else if (toCraftWire3 > 0)
                {
                    calcWire3(toCraftWire3);
                }

                else if (toCraftWire2 > 0)
                {
                    calcWire2(toCraftWire2);
                }

                else if (toCraftWire1 > 0)
                {
                    calcWire1(toCraftWire1);
                }


                else if (toCraftChip6 > 0)
                {
                    calcChip6(toCraftChip6);
                }

                else if (toCraftChip5 > 0)
                {
                    calcChip5(toCraftChip5);
                }

                else if (toCraftChip4 > 0)
                {
                    calcChip4(toCraftChip4);
                }

                else if (toCraftChip3 > 0)
                {
                    calcChip3(toCraftChip3);
                }

                else if (toCraftChip2 > 0)
                {
                    calcChip2(toCraftChip2);
                }

                else if (toCraftChip1 > 0)
                {
                    calcChip1(toCraftChip1);
                }


                else if (toCraftBattery3 > 0)
                {
                    calcBattery3(toCraftBattery3);
                }

                else if (toCraftBattery2 > 0)
                {
                    calcBattery2(toCraftBattery2);
                }

                else if (toCraftBattery1 > 0)
                {
                    calcBattery1(toCraftBattery1);
                }
            }

            Console.WriteLine($"\n\nTotal: \n\n" +
                $"Base materials:\nAluminum: {totalAluminum}\nSteel: {totalSteel}\nSpecial Steel: {totalSpecialSteel} \n\n" +
                $"Need to craft:\nWire1: {totalWire1}\nWire2: {totalWire2}\nWire3: {totalWire3}\nWire4: {totalWire4}\n\n" +
                $"Chip1: {totalChip1}\nChip2: {totalChip2}\nChip3: {totalChip3}\nChip4: {totalChip4}\nChip5: {totalChip5}\nChip6: {totalChip6}\n\n" +
                $"Battery1: {totalBattery1}\nBattery2: {totalBattery2}\nBattery3: {totalBattery3}\n");

            Console.WriteLine("\nDo you want to restart the program? [Y/N]");
            doRestart = Console.ReadLine();

            if (doRestart.ToLower() == "y")
            {
                restart();
            }

            else if (doRestart.ToLower() == "n")
            {
                exit();
            }
        }
    }
}
