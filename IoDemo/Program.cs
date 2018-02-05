using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoGame videoGame;


            videoGame = InitializeVideoGame();
            WriteCsvFile(videoGame);
            videoGame = ReadCsvFile();
        }

        public static VideoGame InitializeVideoGame()
        {
            VideoGame videoGame = new VideoGame()
            {
                Id = 1,
                Name = "Mario",
                Platform = VideoGame.PlatformName.NINTENDO,
                
            };

            return videoGame;
        }

        public static void WriteCsvFile(VideoGame videoGame)
        {
            StreamWriter sWriter = new StreamWriter("Data.csv");

            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append(videoGame.Id + ",");
            sb.Append(videoGame.Name + ",");
            sb.Append(videoGame.Platform + ",");
            sb.ToString();

            using (sWriter)
            {
                sWriter.Write(sb);
            }

        }

        public static VideoGame ReadCsvFile()
        {
            VideoGame videoGame = new VideoGame();

            StreamReader sReader = new StreamReader("Data.csv");

            string videoGameString;

            using (sReader)
            {
                videoGameString = sReader.ReadLine();
            }

            string[] videoGameArray = videoGameString.Split(',');
            videoGame.Id = int.Parse(videoGameArray[0]);
            videoGame.Name = videoGameArray[1];
            videoGame.Platform = (VideoGame.PlatformName)Enum.Parse(typeof(VideoGame.PlatformName), videoGameArray[2]);


            return videoGame;
        }
    }
}
