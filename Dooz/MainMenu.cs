using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using WebSocketSharp;

namespace Dooz
{
    internal class MainMenu
    {
        public static MainMenu _instance;
        public static MainMenu instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainMenu();
                return _instance;
            }
        }

        public void StartMenu()
        {
            Console.WriteLine("write yout usernamev : ");
            string username = Console.ReadLine();
            Console.WriteLine("connecting...");

            var ws = new WebSocket("ws://localhost:1381/main");
            ws.Connect();
            
           var m = new MessageBase();
            m.action = "register";
            m.data = username;
            var json = JsonConvert.SerializeObject(m);
            Console.WriteLine(json);
            ws.Send(json);

            //Console.Clear();

            while (true)
            {
                //clear

                //show manitor 
                ShowMainMenu();

                //write command
                string command = Console.ReadLine();
                //do
                switch (command)
                {
                    case "1":
                        m.action = "findGame";
                        m.data = "";
                        ws.Send(JsonConvert.SerializeObject(m));
                        break;
                    default:
                        break;
                }
                if (command == "0")
                {
                    break;
                }
            }
        }

        void ShowMainMenu()
        {
            Console.WriteLine("Welcom to game\n1 : find a game\n2 : help\n0 : exit");
        }

    }
}
