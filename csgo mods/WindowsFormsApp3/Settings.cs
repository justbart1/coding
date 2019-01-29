using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Settings
    {
        public class Glow
        {
            public static bool enabled = false;
        }

        public class Glowteam
        {
            public static bool enabled = false;
        }

        public class Glowenemy
    {
            public static bool enabled = false;
        }

        public class Radar
        {
            public static bool enabled = false;
        }

        public class Flash
        {
            public static bool enabled = false;
        }

        public class Triggerbot
        {
            public static bool enabled = false;
            public static int delay = 0;
            public static Keys key = Keys.Menu; //if you want to use alt use must use keys.menu not keys.alt
        }

        public class Bunnyhop
        {
            public static bool enabled = false;
            public static int delay = 0;
            public static Keys key = Keys.Space;
        }
    }
}
