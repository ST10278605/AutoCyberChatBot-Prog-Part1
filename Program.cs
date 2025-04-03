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


    }
}
