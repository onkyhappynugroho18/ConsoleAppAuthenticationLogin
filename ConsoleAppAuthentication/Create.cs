using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAuthentication;

internal class Create
{
    /*public static int[] id = new int[5];
    public static string[] firstName = new string[5];
    public static string[] lastName = new string[5];
    public static string[] username = new string[5];
    public static string[] password = new string[5];*/

    public static void Buat(List<DataUser> dataUsers)
    {
        //Create User
        Console.Clear();

        Console.WriteLine("== CREATE USER ==");
        DataUser user = new DataUser();

        //Looping Inputan untuk Create User
        if (user.id == 0)
        {
            Console.Write("First Name : ");
            string inpfirstName = Console.ReadLine();

            Console.Write("Last Name : ");
            string inplastName = Console.ReadLine();

            //Generate Username
            string username = inpfirstName[..2] + inplastName[..2];
            
            user.firstName = inpfirstName;
            user.lastName = inplastName;
            user.username = username;

            bool cek = true;
            do
            {
                //Check Password
                Console.Write("Password : ");
                string checkPass = Console.ReadLine();

                //Check Panjang Password
                if (checkPass.Length >= 8 && checkPass.Length <= 16)
                {
                    //Check Huruf Kapital Pada Password
                    if (checkPass.Any(char.IsUpper))
                    {
                        //Check Huruf Kecil Pada Password
                        if (checkPass.Any(char.IsLower))
                        {
                            //Check Angka Pada Password
                            if (checkPass.Any(char.IsNumber))
                            {
                                user.password = checkPass;
                                cek = false;
                                dataUsers.Add(user);
                                break;
                            }
                        }
                    }

                }
                //Alert Untuk Password Required
                Console.WriteLine("\nPassword must have at least 8 characters and max 16 characters\r\nwith at least one Capital letter, at least one lower case letter and at least one number.\n");
            } while (cek);
        }
    }
}
