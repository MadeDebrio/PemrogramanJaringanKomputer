using System;
using System.Text.Json;
using System.IO;

namespace LoginClient
{
    class USER
    {
        public int userLengthCounter { get; set; }
        public int passLengthCounter { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }

    class Client
    {
        static void Main()
        {
            //creating object user
            USER user = new USER();

            // input
            Console.WriteLine("Username : ");
            user.username = Console.ReadLine();
            Console.WriteLine("Password : ");
            user.password = Console.ReadLine();

            user.userLengthCounter = user.username.Length;
            user.passLengthCounter = user.password.Length;

            //creating file
            string fileName = "UserData.json";
            //converts the text format into json string
            string jsonString = JsonSerializer.Serialize(user);

            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(File.ReadAllText(fileName));
        }
    }

    
}