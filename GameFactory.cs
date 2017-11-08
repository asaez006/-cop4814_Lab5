using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Lab_2
{
    public class GameFactory
    {
        StreamWriter sw;
        XmlSerializer serial;
        List<Game> gameList;

        const string FilePath = @"..\..\games.xml";
        public void CreateGameList()
        {
            gameList = new List<Game>();
            Game G = new Game("Hornets", "50", "Bulldogs", "73");
            gameList.Add(G);
            G = new Game("Heat", "100", "Wizards", "94");
            gameList.Add(G);
            G = new Game("Warriors", "122", "Cavaliers", "121");
            gameList.Add(G);
            G = new Game("Bucks", "88", "Celtics", "94");
            gameList.Add(G);
            G = new Game("Rockets", "98", "Thunder", "101");
            gameList.Add(G);
            G = new Game("Spurs", "109", "Wizards", "107");
            gameList.Add(G);
        }
        public Boolean SerializeGameList()
        { 
            serial = new XmlSerializer(gameList.GetType());
            sw = new StreamWriter(FilePath);
            serial.Serialize(sw, gameList);
            sw.Close();
            return true;
        }

        public List<Game> DeserializeGameList(out string resultMessage)
        {
            try
            { 
                gameList = new List<Game>();
                StreamReader sr = new StreamReader(FilePath);
                serial = new XmlSerializer(gameList.GetType());
                gameList = (List<Game>)serial.Deserialize(sr);
                sr.Close();
                resultMessage = "It Worked!";
                return gameList;
            }
            catch(Exception ex)
            {
                resultMessage = "Exception: " + ex.Message;
                return null;
            }
        }
    }
}
