using System;
using System.Text.Json;//includes serializing objects to JSON text and deserializing JSON text to objects
using System.IO;// Contains types that allow reading and writing to files and data streams, and types that provide basic file and directory support.

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
            //converts the text format into json string (Marshall)
            string jsonString = JsonSerializer.Serialize(user);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(File.ReadAllText(fileName));

            //converts the json string into text format (Unmarshall)
            USER player1 = JsonSerializer.Deserialize<USER>(jsonString)!;

            Console.WriteLine($"Username: {player1.username}");
            Console.WriteLine($"Password: {player1.password}");

        }
    }


}