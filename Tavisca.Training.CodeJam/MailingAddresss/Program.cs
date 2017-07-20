using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingAddresss
{
    class Program
    {
        static void Main(string[] args)
        {
            var userDataImpl = new DataProcessing();
            do
            {
                Console.WriteLine("Hi Enter Your Choice .... \n1) Enter your Informaion \n2) Display your Information.");
                int result;
                var input = Int32.TryParse(Console.ReadLine(), out result);

                if (input)
                {
                    switch (result)
                    {

                        case 1:
                            var user = new UserData();
                            Console.WriteLine("Enter your  name");
                            user.Name = Console.ReadLine();
                            Console.WriteLine("Enter your city name");
                            user.CityName = Console.ReadLine();
                            Console.WriteLine("Enter your  street name");
                            user.Street = Console.ReadLine();
                            Console.WriteLine("Enter  your Pin code");
                            user.PinCode = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter  your House number");
                            user.HouseNo = Convert.ToInt32(Console.ReadLine());
                            userDataImpl.InsertUserData(user);
                            break;

                        case 2:
                            var userData = userDataImpl.DisplayUserData();
                            Console.WriteLine("The detail information of user  are as follow ");

                            foreach (var item in userData)
                            {
                                Console.WriteLine("The Name is   " + item.Name);
                                Console.WriteLine("The city name is   " + item.CityName);
                                Console.WriteLine("The Street name is   " + item.Street);
                                Console.WriteLine("The pincode   " + item.PinCode);
                                Console.WriteLine("The house no " + item.HouseNo);
                                Console.WriteLine("\n");

                            }
                            break;

                        default:
                            Environment.Exit(0);
                            break;

                    }
                }
            }
            while (true);
        }
    }
}
