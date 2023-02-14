using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAuthentication;

internal class Login : Create
{
    public static void Masuk(List<DataUser> dataUsers)
    {
        //Login User
        Console.Clear();

        Console.WriteLine("== LOGIN ==");

        //Inputan Username
        Console.Write("USERNAME : ");
        string inputUser = Console.ReadLine();
        //Inputan Password
        Console.Write("PASSWORD : ");
        string inputPass = Console.ReadLine();

        //Check Username dan Password
        foreach (DataUser user in dataUsers)
        {
            bool status = true;
            if (user.username == inputUser && user.password == inputPass)
            {
                status = true;
                break;
            }
            if (status == true)
            {
                Console.Write("Login Berhasil");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Login Gagal");
                Console.ReadKey();
            }
        }
        /*bool status = false;
        for (int i = 0; i < id.Length; i++)
        {
            if (username == inputUser && password == inputPass)
            {
                status = true;
                break;
            }
        }

        if (status == true)
        {
            Console.Write("Login Berhasil");
            Console.ReadKey();
        }
        else
        {
            Console.Write("Login Gagal");
            Console.ReadKey();
        }*/
    }
}
