using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamGames;
using System.IO;
using System.Xml.Serialization;

namespace GameFactory1

{
    public class GameFactory

    {
        StreamWriter sw;
        XmlSerializer serial;
        List<Game> gameList;
        public string FilePath = @"..\..\games.xml";

        public void CreateGameList()
        {
            gameList = new List<Game>();
            Game G = new Game("Falcons", 25, "Rangers", 14);
            gameList.Add(G);
            G = new Game("Hawks", 40, "Snipers", 7);
            gameList.Add(G);
            G = new Game("Devils", 50, "Angels", 30);
            gameList.Add(G);
            G = new Game("Paladins", 60, "Warlocks", 70);
            gameList.Add(G);
            G = new Game("Wizards", 80, "Demons", 34);
            gameList.Add(G);
            G = new Game("Blackguards", 20, "Forgers", 67);
            gameList.Add(G);

           
        }

        public void SerializeGameList()
        {
            serial = new XmlSerializer(gameList.GetType());
            sw = new StreamWriter(FilePath);
            serial.Serialize(sw, gameList);
            sw.Close();

        }
    }
   
}
