using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Controllers
{
    // menu controller classi program.cs de olan kodlari aradan qaldirir
    internal static class MenuController
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("1 - E kasssa yarat");
            Console.WriteLine("2 - E kasssa bagli hesab yarat");


            AccountController accountController = new AccountController();
            accountController.GetAccountByNo();
        }

        public static void ShowAccountMenu ()
        {
            Console.WriteLine("1 - Hesaba pul yatir");
            Console.WriteLine("2 - Hesabdan pul cek");
        }

    }
}
