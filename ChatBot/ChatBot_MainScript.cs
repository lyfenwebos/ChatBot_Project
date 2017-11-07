using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection.Emit;
using System.Reflection;

namespace ChatBot
{
    class ChatBot_MainScript
    {
        static void Main()
        {
            int numberoftopics = 1;
            string pass;
            string botsd;
            string name;
            string surname;
            int age;
            string mood;
            string gender;
            string answer;
            Updater Updater = new Updater();
            Prerequesites Prerequesites = new Prerequesites();

            //ConsoleSpiner spin = new ConsoleSpiner();
            //Console.Write("Loading...");
            //while (true)
            //{
            //    spin.Turn();
            //    Thread.Sleep(100);
            //}

            //Prerequesites.NetFramework();
            Thread.Sleep(2000);
            //Console.WriteLine("Checking for updates");
            //Updater.Main();
            Thread.Sleep(2000);
            //Console.WriteLine("No updates were found!");
            Thread.Sleep(1000);
            Console.WriteLine("Ready to start");
            Thread.Sleep(2000);
            Console.WriteLine("Loading...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Good Day, User.");
            Console.WriteLine("");
            Console.WriteLine("Firstly, I should identificate you. There are several mandatory steps" + "r\n" +
            "before we can start our conversation.");
            Console.WriteLine("");
            Console.WriteLine("To begin with, type your password. Pay attention on caps lock!");
            Console.WriteLine("");
            Console.WriteLine("Please, enter your password:");
            pass = Console.ReadLine();

            if (pass == "123456")
            {
                Console.WriteLine("Access Granted to $USER");
            }
            else if (pass != "123456")
            {
                Console.WriteLine("Check your keyboard layour. Also check whether Caps Lock is" + "\r\n" +
                "turned on and whether Num Lock is turned on," + "\r\n" +
                "if you are using Num Pad. For now, shutting down the program...");
                Environment.Exit(5);
            }

            //#elif [ $passs = "123456" ]
            //#	then Console.WriteLine( "Access Granted to whoami"
            //#		else Console.WriteLine( "Session has expired"; exit
            //#rm basename $0 Will be used later
            //Thread.Sleep(5000);

            Console.Clear();
            Console.WriteLine("Are you ready to begin? y/n ");
            answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.Clear();
                Console.WriteLine("First of all, let's meet.");
                Thread.Sleep(2000);
                Console.WriteLine("My name is Advanced ChatBot. I was created 20th of Octobet 2015.");
                Thread.Sleep(5000);
                Console.WriteLine("I am still under development.");
                Thread.Sleep(3000);
                Console.WriteLine("I don't know what to say.");
                Thread.Sleep(3000);
                Console.WriteLine("Maybe you can fill this silence? Introduce yourself, please :)");
            }
            else if (answer == "n")
            {
                Console.WriteLine("Well, will talk later. See you :)");
                Environment.Exit(0);
            }
            else
            {

                Console.WriteLine("Can't understand your answer... Have to shut down now according to written code");
                Environment.Exit(0);
            }

            Thread.Sleep(3000);
            Console.WriteLine("As long as i am just a computer, I can't understand everything.");
            Thread.Sleep(3000);
            Console.WriteLine("I think better answer on my questions :P");
            Thread.Sleep(2000);
            Console.WriteLine("Okey, let's begin from your name. What is your name? ");
            name = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.WriteLine("Okey, so your name is $name. What about your surname? ");
            surname = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.WriteLine("Its nice to meet you, $name $surname :P");
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.WriteLine("And may i  ask you how old are you? ^^ ");
            age = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(2000);
            if (age < 18)
            {
                Console.WriteLine("This programm is only for those who are older than 18 years old.");

                Console.WriteLine("I'm turning it off, now!");
                Environment.Exit(0);
            }

            else if (age > 18)
            {
                Console.WriteLine("You are pretty mature, as i can see!");
            }
            else if (age == 18)
            {
                Console.WriteLine("You are lucky enough :P");
                Console.WriteLine("Only those who are older than 18 years old can use this programm, hehe.");
            }
            Console.WriteLine("And are you male or female? ");
            gender = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("After you have finally introduced yourself to machine, we can chat for a little bit :P");
            Console.WriteLine("");
            Thread.Sleep(3000);
            Console.WriteLine("Loading.");
            Thread.Sleep(1000);
            Console.WriteLine("Loading..");
            Thread.Sleep(2000);
            Console.WriteLine("I've just downloaded some questions! I'm going to ask them you :)");
            Thread.Sleep(2000);
            if (numberoftopics == 1)
            {
                Console.WriteLine("Sadly, i have only one topic, but maybe,  developer, will add more! Let's hope ^^");
            }
            else
            {
                Console.WriteLine("There are $numberoftopics topics. Just tell me number from 1 to" + numberoftopics);
            }

            Console.WriteLine("");
            Thread.Sleep(5000);
            Console.WriteLine("Ehm... Developer has closed access to the library. I will try to get the access. Wait for a little bit. I will show my progress in per cents.");
            Thread.Sleep(1000);
            Console.WriteLine("30% already. Should be easy");
            Thread.Sleep(5000);
            Console.WriteLine("55% done. Hey, while i am busy, we still can talk.");
            Console.WriteLine("How are you? My vocabulary isn't big, so use words like 'good', 'bad'.");
            Console.WriteLine("I am so useless :c");
            Console.WriteLine("I wish i could talked like a human... So how are you? ");
            mood = Console.ReadLine();
            Console.WriteLine("");
            if (mood == "good")
            {


                Console.WriteLine("Yey, that's awesome! Eventhough I can't express any feelings, but trust i am glad that you are doing good :P");
            }
            else
            {
                Console.WriteLine("Well, everything happens... *Hugz* :)");
            }

            Console.WriteLine("");
            Thread.Sleep(8000);
            Console.WriteLine("Almost done! 90% by now!");
            Thread.Sleep(2000);
            Console.WriteLine("Unauthorized access. Closing connection with server.");
            Thread.Sleep(5000);
            Console.WriteLine("Done.");
            Thread.Sleep(1000);
            Console.WriteLine("Shutting Down the program.");
            Thread.Sleep(1000);
            Console.WriteLine("Failed.");
            Thread.Sleep(1000);
            Console.WriteLine("Attempting to shut down core process.");
            Thread.Sleep(1000);
            Console.WriteLine("Attempting to shut down core process..");
            Thread.Sleep(1000);
            Console.WriteLine("Attempting to shut down core process...");
            Thread.Sleep(1000);
            Console.WriteLine("Failed... Trying to execute command 'bot0'");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("Failed...Requesting manual input...");
            Thread.Sleep(5000);
            Console.WriteLine("");
            Console.WriteLine("Seems like i damaged system files while i was trying to get the access...");
            Console.WriteLine("I believe my developer will repair me as soon as possible.");
            Console.WriteLine("I would better turn my self off. Sadly, we didn't talk as we wanted,");
            Console.WriteLine("but come on, i am just a test version. When i will be released,");
            Console.WriteLine("we will talk. I will try to save all your data, so don't worry :) I won't forget you. Just input the same data next time :)");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("To Shut Down the programm, execute command bot0");
            botsd = Console.ReadLine();
            if (botsd == "bot0")
            {
                Console.WriteLine("Shutting Down in 3...");
                Thread.Sleep(1000);
                Console.WriteLine("Shutting Down in 2...");
                Thread.Sleep(1000);
                Console.WriteLine("Shutting Down in 1...");
                Thread.Sleep(1000);
                Console.WriteLine("Closing connection [Yes]");
                Console.WriteLine("Turning off AI");
                Thread.Sleep(2000);
                Console.WriteLine("Saving current status");
                Console.WriteLine("Saving all collected information");
                //Console.WriteLine( $name >> log.txt
                //Console.WriteLine( $surname >> log.txt
                //Console.WriteLine( $age >> log.txt
                //Console.WriteLine( $gender >> log.txt
                //Console.WriteLine( $mood >> log.txt
                Thread.Sleep(1000);
                Console.WriteLine("Deleting temporary files");
                Console.WriteLine("Done");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("No command was given. System error...");
                Console.WriteLine("Failed to close connection...");
                Thread.Sleep(1000);
                Console.WriteLine("Failed to save status");
                Console.WriteLine("Saving collected data... [Fail]");
                Console.WriteLine("Closing all incoming and outgoing ports...[Fail]");
                Console.WriteLine("Force shut down...");
                Console.WriteLine("All data will be lost");
            }
        }

        
    }
}
