using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmMachineApp
{
    public class Atm
    {
        private double totalBal = 100;
        private int account;
        private int pin;
        private int drawMenu_selection;
        private int addCash_selection;
        private int withdrawSelection;

        public int useraccount()
        {
            try
            {
                Console.WriteLine("Enter Your Account Number : ");
                account = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return account;
        }

        public int UserPin()
        {
            try
            {
                Console.WriteLine("Enter Your Pin : ");
                pin = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return pin;
        }

        public void drawMainMenu()
        {
            try
            {
                Console.WriteLine("\nATM Main Menu");
                Console.WriteLine("1 - View Account Balance");
                Console.WriteLine("2 - Withdraw Cash");
                Console.WriteLine("3 - Add Cash");
                Console.WriteLine("4 - Terminate transaction");
                Console.WriteLine("Choice : ");
                drawMenu_selection = Convert.ToInt32(Console.ReadLine());
                switch (drawMenu_selection)
                {
                    case 1:
                        viewAccountInfo();
                        break;
                    case 2:
                        Withdraw();
                        break;
                    case 3:
                        addCash();
                        break;
                    case 4:
                        Console.WriteLine("Thank You For Using Our Atm!! Goodbye");
                        break;
                    default:
                        Console.WriteLine("Please Select Above choices");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void viewAccountInfo()
        {
            try
            {
                Console.WriteLine("Account Information:");
                Console.WriteLine($"\t--Total Balance: {totalBal}");
                drawMainMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void deposit(int depamount)
        {
            try
            {
                Console.WriteLine("\n***Your Amount is Deposited Thank you for using Our Service***");
                totalBal = totalBal + depamount;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void checkNsf(int withdrawaount)
        {
            try
            {
                if (totalBal - withdrawaount < 0)
                {
                    Console.WriteLine("\n***ERROR!!! Insuficient Funds");
                }
                else
                {
                    totalBal = totalBal - withdrawaount;

                    Console.WriteLine("\n***Please Take Your Cash");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void addCash()
        {
            try
            {
                Console.WriteLine("Deposit Cash:");
                Console.WriteLine("1 - $20");
                Console.WriteLine("2 - $40");
                Console.WriteLine("3 - $60");
                Console.WriteLine("4 - $80");
                Console.WriteLine("5 - $100");
                Console.WriteLine("6 - Back To Main Menu");
                addCash_selection = Convert.ToInt32(Console.ReadLine());

                switch (addCash_selection)
                {
                    case 1:
                        deposit(20);
                        drawMainMenu();
                        break;
                    case 2:
                        deposit(40);
                        drawMainMenu();
                        break;
                    case 3:
                        deposit(60);
                        drawMainMenu();
                        break;
                    case 4:
                        deposit(80);
                        drawMainMenu();
                        break;
                    case 5:
                        deposit(100);
                        drawMainMenu();
                        break;
                    case 6:
                        drawMainMenu();
                        break;
                    default:
                        Console.WriteLine("Please Select An option");
                        drawMainMenu();
                        break;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Withdraw() 
        {
            try
            {
                Console.WriteLine("Deposit Cash:");
                Console.WriteLine("1 - $20");
                Console.WriteLine("2 - $40");
                Console.WriteLine("3 - $60");
                Console.WriteLine("4 - $80");
                Console.WriteLine("5 - $100");
                Console.WriteLine("6 - Back To Main Menu");
                withdrawSelection = Convert.ToInt32(Console.ReadLine());

                switch (withdrawSelection)
                {
                    case 1:
                        checkNsf(20);
                        drawMainMenu();
                        break;
                    case 2:
                        checkNsf(40);
                        drawMainMenu();
                        break;
                    case 3:
                        checkNsf(60);
                        drawMainMenu();
                        break;
                    case 4:
                        checkNsf(80);
                        drawMainMenu();
                        break;
                    case 5:
                        checkNsf(100);
                        drawMainMenu();
                        break;
                    case 6:
                        drawMainMenu();
                        break;
                    default:
                        Console.WriteLine("Please Select An option");
                        drawMainMenu();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        // this method will start the atm machine
        public void StartAtm()
        {
            useraccount();
            UserPin();
            drawMainMenu();
        }

    }
}
