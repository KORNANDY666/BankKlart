using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKlart
{
    internal partial class MyBank
    {

        string inlogg; //incapsulation
        string pass;

        Random randomAc = new Random(); // randomizes bank account number in method addAccount()
        public int number3;

        public List<string> userList = new List<string>();
        public List<string> passList = new List<string>();
        public List<int> bankList = new List<int>();

        public string Pass
        {
            get => pass;
            set => pass = value;
        }
        public string Inlogg
        {
            get => inlogg;
            set => inlogg = value;
        }

        public void customerinlog()
        {
            bool check = false;
            int num = 0;
            while (check == false)
            {
                Console.Write("Användarnamn privatperson : ");
                Inlogg = Console.ReadLine();
                Console.Write("Password privatkund : ");
                Pass = Console.ReadLine();
                num++;

                var userfound = userList.Find(i => i.Equals(Inlogg)); // checks if usernames and passwords match each other. 
                var userfound1 = passList.Find(i => i.Equals(Pass));

                if (userfound == Inlogg && userfound1 == Pass)
                {
                    usermeny();
                    return;
                }
                else if (userfound != Inlogg && userfound1 != Pass)
                {
                    Console.WriteLine("Fel inmatning, försök igen!");
                    Console.Clear();
                }

                if (num < 2)
                {
                    Console.WriteLine("Fel inmatning igen, skärp dig!");
                }
                else if (num == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Nu har du ett försök kvar!!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Hur svårt ska det vara!!!, Hej då :)");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                    check = true;
                }
            }
        }
        public void usermeny()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till din användarmenyn");
                Console.WriteLine("1. Skapa nytt bankkonto");
                Console.WriteLine("2. Valuta ");
                Console.WriteLine("3. Se mina bankkonton");
                Console.WriteLine("4. Logga ut");
                int adminInput = checkNr();
                if (adminInput == 1)
                {
                    addAccount();
                }
                else if (adminInput == 2)
                {
                    valuta();
                }
                else if (adminInput == 3)
                {
                    banksaldo();
                }
                else if (adminInput == 4)
                {
                    Console.Clear();
                    break;
                }
            }

        }
        public void banksaldo()
        {
            Random random = new Random();

            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Lista över dina kontonummer");
            Console.WriteLine("-----------------------------------------------");
            foreach (var item1 in bankList)
            {

                Console.WriteLine("Kontonummer:" + item1 + ",  Banksaldo:" + (random.Next(0, 1000000)) + "kr");
                Console.WriteLine("-----------------------------------------------");
            }

            Console.ReadKey();
            return;
        }
        public void valuta()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Euro : 10.82 skr\n" +
                              "USD : 10.43 skr\n" +
                              "GBP : 12.41 skr\n" +
                              "NOK : 1.05 skr\n" +
                              "JPY : 7.49 skr");
            Console.WriteLine("----------------------------");

            Console.ReadKey();

        }

        public void addAccount()
        {
            Console.Clear();
            number3 = randomAc.Next(1111111, 9999999);

            Console.WriteLine("Vill du skapa ett nytt bankkonto tryck enter.");
            Console.WriteLine("--------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("Ditt nya kontonummer är : " + number3);
            bankList.Add(number3);

            Console.ReadKey();
        }
    }
}

