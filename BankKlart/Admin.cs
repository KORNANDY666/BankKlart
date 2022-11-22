using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKlart
{
    internal partial class MyBank
    {
        void adminInlogg()
        {
            bool gameOver = false;
            int num = 0;
            while (gameOver == false)
            {
                Console.Write("Användarnamn Admin : ");  //användarnamn: admin och lösen: admin
                Inlogg = Console.ReadLine().ToLower(); // ToLower = code that allows one to use lowercase and uppercase letters
                Console.Write("Lösenord Admin : ");
                Pass = Console.ReadLine().ToLower();
                num++;
                if (Inlogg == "admin" && Pass == "admin")
                {
                    admin();
                    return;
                }
                else
                {
                    if (num < 2)
                    {
                        Console.WriteLine("Fel inmatning, försök igen!");

                    }
                    else if (num == 2)
                    {

                        Console.WriteLine("Nu har du ett försök kvar!!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Va fan, jag sa ju till dig!!. Nu loggas du ut!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }
            }
        }
        void admin()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till inloggningen för Admin !!");
                Console.WriteLine("1. Lägga till användare");
                Console.WriteLine("2. Användare ");
                Console.WriteLine("3. Logga ut");
                int adminInput = checkNr();
                if (adminInput == 1)
                {
                    addUser();
                }
                else if (adminInput == 2)
                {
                    checkUser();
                }
                else if (adminInput == 3)
                {
                    Console.Clear();

                    break;
                }
            }

        }
        void addUser()
        {
            Console.Clear();
            Console.WriteLine("");
            try
            {
                Console.Write("Skriv användarnamn : ");
                string userAdd = Console.ReadLine();
                userList.Add(userAdd);
                Console.WriteLine("-------------------------------");

                Console.Write("Skriv in lösenord: ");
                string userPass = Console.ReadLine();
                passList.Add(userPass);
                Console.WriteLine("-------------------------------");

            }
            catch
            {
                Console.WriteLine("Fel typ av inmatning använd siffror\nTryck enter");
                Console.ReadKey();
            }
            

        }
        void checkUser()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("Här kommer alla användare");
            Console.WriteLine("------------------");
            foreach (var item in userList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Tryck Enter för att återvända till start");
            Console.ReadKey();

        }

    }
}

