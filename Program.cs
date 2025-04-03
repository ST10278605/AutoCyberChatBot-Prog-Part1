using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace AutoCyberChatBot //ST10278605 //Siphesihle Mavuso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Greetings
            VoiceGreeting();

            //Display
            LogoDisplay();

            //Users Name
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"\nHello {userName} welcome to the Cybersecurity Awareness Chatbot!");



            //Chatbot Menu
            while (true)
            {
                Console.WriteLine("\nAsk me about CyberSecurity Topics (type 'exit' to quit):");
                Console.WriteLine("1. Password Safety\n2. Phishing\n3. Safe Browsing");
                Console.Write("Your Choice: ");
                string userChoice = Console.ReadLine().Trim();


                if (userChoice.ToLower() == "exit")
                {
                    Console.WriteLine("\nStay safe online! Goodbye!");
                    break;
                }

                //Respond to User
                ProcessUserInput(userChoice);
            }

        }

        //Greetings
        public static void VoiceGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Error playing sound: " + ex.Message + "]");
            }
        }

        //Display
        public static void LogoDisplay()
        {
            Console.WriteLine(@"\n

                                       .----. 
                                      ( o  o ) 
                                      |  --  |
                                      |______|
                                    /|        |\
                                   / |        | \
                                  *  *        *  *
  
                               CYBERSECURITY CHATBOT 
         ""Ensuring your safety by protecting our conversations one message at a Time");

        }

        //Users Name
        static void ProcessUserInput(string input)
        {
            switch (input)
            {
                case "1":
                    Console.WriteLine("\n[Password Safety]: Use long, unique passwords with a mixture of letters, numbers, and symbols.");
                    break;
                case "2":
                    Console.WriteLine("\n[Phishing]: Beware of any emails or messages asking for personal information.");
                    break;
                case "3":
                    Console.WriteLine("\n[Safe Browsing]: Only visit secure websites with (https://.co.za) and avoid any clicking unsafe links.");
                    break;
                default:
                    Console.WriteLine("\nI didn't quite understand that. Could you rephrase?");
                    break;
            }
        }

    }
}
