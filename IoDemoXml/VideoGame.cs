using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoDemo
{
    public class VideoGame
    {
        public enum PlatformName
        {
            NONE,
            XBOX,
            PLAYSTATION,
            NINTENDO
        }

        private int _id;
        private string _name;
        private PlatformName _platform;
        private List<string> _character;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public PlatformName Platform
        {
            get { return _platform; }
            set { _platform = value; }
        }

        
        public List<string> Characters
        {
            get { return _character; }
            set { _character = value; }
        }
        
    }
}
