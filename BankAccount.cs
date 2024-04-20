using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Week_8_Classes_and_objects_part_4__last_part_
{
    internal class BankAccount
    {
        
        private int _accountNumber;
        private string _customerName;
        private string _accountType;
        private string _bic;
        private decimal _bankBalance;
        private string _bankPin;

        public static int AccountsRegistered;

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public decimal Balance
        {
            get { return _bankBalance; }
        }
        public string AccountTypeGetter
        {
            get { return _accountType; }
        }
        public string AccountTypeSetter
        {
            set { _accountType = value; }
        }
        public string CustomerNameGetter
        {
            get { return _customerName; }
        }
        private string CustomerNameSetter
        {
            set { _customerName = value; }
        }
        public string BicGetter
        {
            get { return _bic; }
        }
        private string BicSetter
        {
            set { _bic = value; }
        }
        private string BankPin
        {
            get { return _bankPin; }
            set { _bankPin = value; }
        }
        public BankAccount()
        {
            AccountsRegistered++;

            AccountNumber = AccountsRegistered;
        }
        public BankAccount(string Name, string Type)
        {
            string PIN = "";

            #region BankAccount2
            
            while (AccountsRegistered == 2 && BankPin.Length != 4)
            {
                Console.WriteLine("Your account requires a PIN.\nPlease enter a PIN (Must be 4 characters): ");
                PIN = Console.ReadLine();
                while (PIN.Length != 4)
                {
                    if (PIN.Length > 4)
                    {
                        Console.WriteLine("This PIN is too long, please enter a new one (Must be 4 Characters): ");
                    }
                    else if (PIN.Length > 4)
                    {
                        Console.WriteLine("This PIN is too short, please enter a new one (Must be 4  Characters): ");
                    }
                }
            }
            #endregion // PARAMETERS FOR THE 2nd BANK ACCOUNT
            #region BankAccount3
            while (AccountsRegistered == 3 && BankPin.Length != 4)
            {
                Console.WriteLine("Your account requires a PIN.\nPlease enter a PIN (Must be 4 characters): ");
                PIN = Console.ReadLine();
                while (PIN.Length != 4)
                {
                    if (PIN.Length > 4)
                    {
                        Console.WriteLine("This PIN is too long, please enter a new one (Must be 4 Characters): ");
                    }
                    else if (PIN.Length > 4)
                    {
                        Console.WriteLine("This PIN is too short, please enter a new one (Must be 4  Characters): ");
                    }
                }
            }
            #endregion // PARAMETERS FOR THE 3rd Bank Account
            #region BankAccount4
            while (AccountsRegistered == 4 && BankPin.Length != 4)
            {
                Console.WriteLine("Your account requires a PIN.\nPlease enter a PIN (Must be 4 characters): ");
                PIN = Console.ReadLine();
                while (PIN.Length != 4)
                {
                    if (PIN.Length > 4)
                    {
                        Console.WriteLine("This PIN is too long, please enter a new one (Must be 4 Characters): ");
                        PIN = Console.ReadLine();
                    }
                    else if (PIN.Length > 4)
                    {
                        Console.WriteLine("This PIN is too short, please enter a new one (Must be 4  Characters): ");
                        PIN = Console.ReadLine();
                    }
                }
            }
            #endregion // PARAMETERS FOR THE 4th BANK ACCOUNT

            CustomerNameSetter = Name;
            AccountTypeSetter = Type;
            BicSetter = $"IB-123H" + AccountsRegistered;
            BankPin = PIN;
            
            AccountsRegistered++;
            AccountNumber = AccountsRegistered;
            
        }
        public decimal LodgeMoney(decimal y)
        {
            _bankBalance = Balance + y;

            return _bankBalance;

        }
        public decimal WithdrawMoney(decimal x)
        {
            _bankBalance = Balance - x;
            return _bankBalance;
        }
        public decimal CheckBalance()
        {
            Console.WriteLine($"You have {Balance} left in your account.");
            return Balance;
        }
        public void PinChanger()
        {
            string pin = "";     
            
            Console.Write("Please enter in your New Pin (Must be 4 Characters): ");

            pin = Console.ReadLine();

            while (pin.Length != 4)         // CHECKS TO MAKE SURE THE PIN IS 4 CHARACTERS LONG
            {
                if(pin.Length > 4)
                {
                    Console.WriteLine("This PIN is too long, please enter a new one (Must be 4 Characters): ");
                    pin = Console.ReadLine();
                }   

                else if(pin.Length < 4)
                {
                    Console.WriteLine("This PIN is too short, please enter a new one (Must be 4 Characters): ");
                    pin = Console.ReadLine();
                }
            }
            
            BankPin = pin;      // SETS THE PIN
            
        }
        public string AccountViewer()
        {
            Console.WriteLine($"Name: {CustomerNameGetter}");
            Console.WriteLine($"Bank PIN: {BankPin}");
            Console.WriteLine($"Bank BIC: {BicGetter}");
            Console.WriteLine($"Account Type: {AccountTypeGetter}");
            return AccountViewer();

        }
       
    }
}
