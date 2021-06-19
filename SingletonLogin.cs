using System;

namespace SingletonLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginWithSingleTon Login = LoginWithSingleTon.GetInstance;
        }
    }
    public sealed class LoginWithSingleTon
    {
        private static String Username;
        private static String Password;
        private static LoginWithSingleTon Instance = null;
        public static LoginWithSingleTon GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new LoginWithSingleTon();
                }
                return Instance;
            }
        }
        private LoginWithSingleTon()
        {
            String name, pass;
            Console.Write("Please Input Username: ");
            name = Console.ReadLine().ToString();
            Console.Write("Please Input Password: ");
            pass = Console.ReadLine().ToString();
            LoginWithSingleTon.Username = name;
            LoginWithSingleTon.Password = pass;
            if(LoginWithSingleTon.Username == "Admin" && LoginWithSingleTon.Password == "1")
            {
                Console.WriteLine("Welcome " + LoginWithSingleTon.Username + ". Sucessfully Login !!!");
            }
            else
            {
                Console.WriteLine("Invalid User");
            }
            
        }
    }
}

