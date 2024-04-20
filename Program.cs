namespace Week_8_Classes_and_objects_part_4__last_part_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region VARIABLES AND CASE INSENSITVE
            // VARIABLES
            string answer = "", name, type = "", bic,pinAnswer="", pin="", depositAnswer = "", answerMenu = "";
            int choice = ' ';
            decimal amount = ' ';
            int i = ' ';

            // CASE INSENSITIVE
            answer.ToLower();
            type.ToLower();
            depositAnswer.ToLower();
            pinAnswer.ToLower();
            #endregion

            #region Beginning Inputs
            // BEGIN INPUTS
            Console.Write("--------------------------------------------\nWould you like to create a bank account(Y/N): ");
            answer = Console.ReadLine();

            // HOW MANY BANK ACCOUNTS TO BE CREATED
            BankAccount[] account = new BankAccount[10000]; // MAX AMOUNT OF ACCOUNTS IS 10000
                                                            // LOOP TO MAKE ACCOUNTS
            #endregion

            #region BEGINNING LOOP
            while (answer != "N")
            {
                #region NAME + ACCOUNT TYPE
                // ENTERING IN NAME DATA
                Console.Write("--------------------------------------------\nPlease enter in your name: ");
                name = Console.ReadLine();

                // ADDING LINES FOR STYLE
                Console.Write("--------------------------------------------\nPlease enter in the type of account you are looking to open: ");
                type = Console.ReadLine();
                #endregion
                // MAKES SURE THE TYPE IS 1 OF THE THREE
                #region CHECKS TO MAKE SURE INPUT IS OKAY
                while (type != "Current" && type != "Deposit" && type != "Savings")
                {
                    Console.WriteLine("Invalid Account Type (Current, Savings, Deposit). Please enter a new type: ");
                    type = Console.ReadLine();
                }
                #endregion

                // CREATION COMPLETE
                #region COMPLETION
                Console.WriteLine("--------------------------------------------\nAccount Creation Process is Complete");
                account[i] = new BankAccount(name, type);
                // SETS BANK ACCOUNT DATA
                #endregion
                // CREATING PIN PROCESS
                #region CREATE PIN
                Console.Write("--------------------------------------------\nWould you like to create a PIN for your account? (Y/N): ");
                pinAnswer = Console.ReadLine();                                           // DECIDES WHETHER

                if (pinAnswer == "Y")
                {
                    account[i].PinChanger();
                }
                #endregion
                // ASK IF WANTS TO LODGE MONEY
                #region LODGE MONEY
                
                Console.Write("--------------------------------------------\nWould you like to lodge money? (Y/N): ");
                depositAnswer = Console.ReadLine();

                if (depositAnswer == "Y")
                {
                    Console.Write("--------------------------------------------\nPlease enter the amount to deposit: ");
                    amount = decimal.Parse(Console.ReadLine());
                    account[i].LodgeMoney(amount);                              // GETS ADDED TO the account[i].Balance
                    Console.WriteLine($"--------------------------------------------\nDeposit of {amount} was succesfull");
                }
                #endregion
                #region ACCOUNT NUMBER AND OPTION TO MAKE NEW ACCOUNT
                Console.WriteLine($"--------------------------------------------\nYour Bank ID: {account[i].AccountNumber}"); // DISPLAYS BANK ACCOUNT NUMBER

                Console.Write("--------------------------------------------\nWould you like to make another account? (Y/N): "); // OPTION TO MAKE NEW ACCOUNT
                answer = Console.ReadLine();
                i++;
                #endregion
            }
            #endregion

            #region Access the Menu
            Console.Write("--------------------------------------------\nWould you like to access your account? (Y/N): ");            // ACCESS POINT TO THE MENU
            answerMenu = Console.ReadLine();
            #endregion
            #region Menu
            while (answerMenu != "N")
            {
                
                Console.Write("What is your account ID: ");
                i = int.Parse(Console.ReadLine());

                Console.WriteLine(account[i].AccountViewer()); // DISPLAYS ACCOUNT INFORMATION FROM BankAccount.cs FILE

                #region Menu Choices + Selections
                Console.WriteLine($"--------------------------------------------\nPlease Select An Option:\n1. Lodge Money: \n2. Withdraw Money: \n3. Check Balance: \n4. Change Pin: \n5. Exit.");
                switch (choice)
                {
                        case 1:
                        {
                            Console.Write("--------------------------------------------\nPlease enter the amount to deposit: ");
                            amount = decimal.Parse(Console.ReadLine());
                            account[i].LodgeMoney(amount);                              // GETS ADDED TO the account[i].Balance
                            Console.WriteLine($"--------------------------------------------\nDeposit of €{amount} was succesfull");
                            break;
                        }
                        case 2:
                        {
                            Console.Write("--------------------------------------------\nPlease enter the amount to Withdraw: ");
                            amount = decimal.Parse(Console.ReadLine());
                            account[i].WithdrawMoney(amount);                              // GETS DEDUCED FROM the account[i].Balance
                            Console.WriteLine($"--------------------------------------------\nDeposit of €{amount} was succesfull");
                            break;
                        }
                        case 3:
                        {
                            account[i].CheckBalance();          // CHECKS THE BALANCE
                            break;
                        }
                        case 4:
                        {
                            account[i].PinChanger();            // CHANGES BANK PIN
                            break;
                        }
                        case 5:
                        {   
                            Environment.Exit(0);                // EXITS THE PROGRAMME
                            break;  
                        }
                        
                }
                #endregion



            }
            #endregion

        }
   
    }
}