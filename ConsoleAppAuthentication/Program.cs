// See https://aka.ms/new-console-template for more information

using ConsoleAppAuthentication;

class Program : Create
{
    static void Main()
    {
        do
        {
          Menu();
        } 
        while (true);
    }
    static void Menu()
    {
        List<DataUser> dataUsers = new List<DataUser>();
        Console.Clear();

        //Array Menu

        string[] menuTampilan = { "Create User", "Show User", "Login User", "Exit" };
        
        //Menampilkan Array Menu
        Console.WriteLine("== BASIC AUTHENTICATION ==");
        for (int i = 0; i < menuTampilan.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuTampilan[i]}");
        }
        //Inputan Untuk Pilih Menu
        Console.Write("Input : ");
        int pilihMenu = Convert.ToInt32(Console.ReadLine());

        switch (pilihMenu)
        {
            case 1:
                Buat(dataUsers);
                Console.Write("\nData User Berhasil dibuat");
                Console.ReadKey();
                break;
            case 2:
                Show.Tampil(dataUsers);
                break;
            case 3:
                Login.Masuk(dataUsers);
                break;
            case 4: //Exit Program
                System.Environment.Exit(0);
                break;
            default:
                Console.Write("\nTidak ada pilihan");
                break;
        }
    }
}