using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace IoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoGame videoGame;

            videoGame = InitializeVideoGame();

            WriteXmlFile(videoGame);
        }

        public static VideoGame InitializeVideoGame()
        {
            VideoGame videoGame = new VideoGame()
            {
                Id = 1,
                Name = "Mario",
                Platform = VideoGame.PlatformName.NINTENDO,
                Characters = new List<string>()
                {
                    "Mario",
                    "Luigi"
                }

            };

            return videoGame;
        }

        public static void WriteXmlFile(VideoGame videoGame)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(VideoGame));

            StreamWriter sWriter = new StreamWriter("Data.xml");

            using (sWriter)
            {
                serializer.Serialize(sWriter, videoGame);
            }
        }

        public static VideoGame ReadXmlFle()
        {
            VideoGame videoGame;

            StreamReader sReader = new StreamReader("Data.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(VideoGame));

            using (sReader)
            {
                //videoGame = serializer.Deserialize(sReader) as VideoGame;

                object xmlObject = serializer.Deserialize(sReader);
                //videoGame = (VideoGame)xmlObject;
                videoGame = xmlObject as VideoGame; //cast xmlObject as Videogame
            }

            return videoGame;
        }
    }
}
