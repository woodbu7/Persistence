using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
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
    }
}
