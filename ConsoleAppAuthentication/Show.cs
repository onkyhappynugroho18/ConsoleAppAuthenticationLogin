using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAuthentication;

class Show : Create
{
    public static void Tampil(List<DataUser> dataUsers)
    {
        //Tampil User
        bool kunci = true;
        do
        {
            Console.Clear();

            Console.WriteLine("== USER ==");
            foreach (DataUser user in dataUsers)
            {
                /*Console.Write("ID : {0}\nName : {1}\nUsername : {2}\nPassword : {3}", user.id, user.firstName+user.lastName, user.username, user.password);

                Console.WriteLine("");*/
                if (user.id != 0)
                {
                    Console.WriteLine("========================");
                    Console.WriteLine($"ID\t: {user.id}");
                    Console.WriteLine($"Name\t: {user.firstName} {user.lastName}");
                    Console.WriteLine($"Username: {user.username}");
                    Console.WriteLine($"Password: {user.password}");
                    Console.WriteLine("========================");

                }
            }

            //Menu Pada Pilihan Create User
            Console.WriteLine("\nMenu");
            string[] menuEdit = { "Edit User", "Delete User", "Back" };
            for (int n = 0; n < menuEdit.Length; n++)
            {
                Console.WriteLine($"{n + 1}. {menuEdit[i]}");
            }

            //Inputan untuk pilihan menu
            Console.Write("Input : ");
            int pilihEdit = Convert.ToInt16(Console.ReadLine());

            switch (pilihEdit)
            {
                case 1:
                    EditUser(dataUsers);
                    Console.Write("\nData user berhasil diedit");
                    Console.ReadKey();
                    break;
                case 2:
                    DeleteUser(dataUsers);
                    Console.Write("\nData user berhasil dihapus");
                    Console.ReadKey();
                    break;
                case 3:
                    kunci = false;
                    break;
                default:
                    Console.Write("\nTidak ada pilihan");
                    Console.ReadKey();
                    break;
            }
        } while (kunci);
    }

    static void EditUser(List<DataUser> dataUsers)
    {
        DataUser user = new DataUser();
        //Edit Uaser
        Console.Write("\nID yang ingin diubah: ");
        user.id = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < user.id; i++)
        {
            if (user.id != 0)
            {
                Console.Write("First Name : ");
                string ubahFirst = Console.ReadLine();
                user.firstName = ubahFirst;

                Console.Write("Last Name : ");
                string ubahLast = Console.ReadLine();
                user.lastName = ubahLast;

                string ubahUser = ubahFirst[..2] + ubahLast[..2];
                user.username = ubahUser;

                Console.Write("Password : ");
                string ubahPass = Console.ReadLine();
                user.password = ubahPass;
                break;
            }
        }
    }

    static void DeleteUser(List<DataUser> dataUsers)
    {
        DataUser user = new DataUser();
        //Delete User
        Console.Write("\nID yang ingin dihapus: ");
        user.id = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < user.id; i++)
        {
            if (user.id != 0)
            {
                user.id = user.id - user.id;
                user.firstName = "";
                user.lastName = "";
                user.username = "";
                user.password = "";
                break;
            }
        }
    }

}
