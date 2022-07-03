using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalGameLauncher {
    class Constants : Application {

        /// <summary>
        /// Core game info
        /// </summary>
        public static readonly string GAME_TITLE = "MartaDash3.0";
        public static readonly string LAUNCHER_NAME = "MartaDash Launcher";

        /// <summary>
        /// Paths & urls
        /// </summary>
        public static readonly string DESTINATION_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), GAME_TITLE);
        public static readonly string ZIP_PATH = Path.Combine(DESTINATION_PATH, GAME_TITLE + ".zip");
        public static readonly string GAME_EXECUTABLE_PATH = Path.Combine(DESTINATION_PATH , "MartaDash" + ".exe");

        public static readonly string VERSION_URL = "https://martadash.fr/update/ver.txt";
        public static readonly string APPLICATION_ICON_URL = "https://martadash.fr/favicon.ico"; // Needs to be .ico
        public static readonly string LOGO_URL = "https://martadash.fr/images/launcher.png"; // Ideally around 283x75
        public static readonly string BACKGROUND_URL = "https://martadash.fr/images/beta.png";
        public static readonly string CLIENT_DOWNLOAD_URL = "https://martadash.fr/debug.zip";

        /// <summary>
        /// Navigation bar buttons
        /// </summary>
        public static readonly string NAVBAR_BUTTON_1_TEXT = "Website";
        public static readonly string NAVBAR_BUTTON_1_URL = "https://martadash.fr/";
        public static readonly string NAVBAR_BUTTON_2_TEXT = "News";
        public static readonly string NAVBAR_BUTTON_2_URL = "https://martadash.fr/";
        public static readonly string NAVBAR_BUTTON_3_TEXT = "Community";
        public static readonly string NAVBAR_BUTTON_3_URL = "https://martadash.fr/";
        public static readonly string NAVBAR_BUTTON_4_TEXT = "Support";
        public static readonly string NAVBAR_BUTTON_4_URL = "https://martadash.fr/";
        public static readonly string NAVBAR_BUTTON_5_TEXT = "Discord";
        public static readonly string NAVBAR_BUTTON_5_URL = "https://martadash.fr/";

        // Modify this array if you're adding or removing a button
        public static readonly string[] NAVBAR_BUTTON_TEXT_ARRAY = {NAVBAR_BUTTON_1_TEXT, NAVBAR_BUTTON_2_TEXT, NAVBAR_BUTTON_3_TEXT,
                                                                    NAVBAR_BUTTON_4_TEXT, NAVBAR_BUTTON_5_TEXT };

        /// <summary>
        /// Settings
        /// </summary>
        public static bool SHOW_VERSION_TEXT = true;
        public static bool AUTOMATICALLY_BEGIN_UPDATING = false;
        public static bool AUTOMATICALLY_LAUNCH_GAME_AFTER_UPDATING = false;
   

    }
}
