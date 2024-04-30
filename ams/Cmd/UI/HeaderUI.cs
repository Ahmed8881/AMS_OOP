using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.UI
{
    internal class HeaderUI
    {
        public static void MainHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"             _    ___ ____  _     ___ _   _ _____           __  __    _    _   _    _    ____ __  __ _____ _   _ _____  ");
            Console.WriteLine(@"            / \  |_ _|  _ \| |   |_ _| \ | | ____|         |  \/  |  / \  | \ | |  / \  / ___|  \/  | ____| \ | |_   _| ");
            Console.WriteLine(@"           / _ \  | || |_) | |    | ||  \| |  _|           | |\/| | / _ \ |  \| | / _ \| |  _| |\/| |  _| |  \| | | |   ");
            Console.WriteLine(@"          / ___ \ | ||  _ <| |___ | || |\  | |___          | |  | |/ ___ \| |\  |/ ___ \ |_| | |  | | |___| |\  | | |   ");
            Console.WriteLine(@"         /_/   \_\___|_| \_\_____|___|_| \_|_____          |_|  |_/_/   \_\_| \_/_/   \_\____|_|  |_|_____|_| \_| |_|   ");
            Console.WriteLine(@"                                ______   ______ _____ _____ __  __                                                      ");
            Console.WriteLine(@"                               / ___\ \ / / ___|_   _| ____|  \/  |                                                     ");
            Console.WriteLine(@"                               \___ \\ V /\___ \ | | |  _| | |\/| |                                                     ");
            Console.WriteLine(@"                                ___) || |  ___) || | | |___| |  | |                                                     ");
            Console.WriteLine(@"                               |____/ |_| |____/ |_| |_____|_|  |_|                                                     ");
            Console.ForegroundColor=ConsoleColor.White;
        }
        public static void LoginHeader() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("#########################################################################################################");
            Console.WriteLine("#                                                                                                       #");
            Console.WriteLine("#                       ##   ##  ### ###  ####      ## ##    ## ##   ##   ##  ### ###                   #");
            Console.WriteLine("#                       ##   ##   ##       ##      ##       ##   ##  # ### #   ##                       #");
            Console.WriteLine("#                       ##   ##   ##  ##   ##      ##   ##  ##   ##   ## ##    ##  ##                   #");
            Console.WriteLine("#                       ## # ##   ## ##    ##      ##       ##   ##  ## # ##   ## ##                    #");
            Console.WriteLine("#                       # ### #   ##       ##      ##       ##   ##  ##   ##   ##                       #");
            Console.WriteLine("#                        ## ##    ##  ##   ##  ##  ##   ##  ##   ##  ##   ##   ##  ##                   #");
            Console.WriteLine("#                       ##   ##  ### ###  ### ###   ## ##    ## ##   ##   ##  ### ###                   #");
            Console.WriteLine("#########################################################################################################");
            Console.WriteLine("#                                                                                                       #");
            Console.WriteLine("#              ##              ## ##     ####    ## ##   ###  ##  ##  ###  ### ##                       #");
            Console.WriteLine("#             ###             ##   ##     ##    ##   ##    ## ##  ##   ##   ##  ##                      #");
            Console.WriteLine("#              ##             ####        ##    ##        # ## #  ##   ##   ##  ##                      #");
            Console.WriteLine("#              ##              #####      ##    ##  ###   ## ##   ##   ##   ##  ##                      #");
            Console.WriteLine("#              ##                 ###     ##    ##   ##   ##  ##  ##   ##   ## ##                       #");
            Console.WriteLine("#              ##             ##   ##     ##    ##   ##   ##  ##  ##   ##   ##                          #");
            Console.WriteLine("#             ####             ## ##     ####    ## ##   ###  ##   ## ##   ####                         #");
            Console.WriteLine("#                                                                                                       #");
            Console.WriteLine("#                                                                                                       #");
            Console.WriteLine("#               ##            ####       ## ##    ## ##  ####   ###   ##                                #");
            Console.WriteLine("#             ## ##            ##       ##   ##  ##   ##   ##    ##   ##                                #");
            Console.WriteLine("#            ##  ##            ##       ##   ##  ##   ##   ##     ##  ##                                #");
            Console.WriteLine("#                ##            ##       ##   ##  ##        ##    # ##  #                                #");
            Console.WriteLine("#              ##              ##       ##   ##  ##  ###   ##    ##  ###                                #");
            Console.WriteLine("#            #   ##            ##   ##  ##   ##  ##   ##   ##    ##   ##                                #");
            Console.WriteLine("#            ######            ### ###   ## ##    ## ##  ####   ###   ##                                #");
            Console.WriteLine("#                                                                                                       #");
            Console.WriteLine("#                                                                                                       #");
            Console.WriteLine("#                                                                                                       #");
            Console.WriteLine("#                                                                                                       #");
            Console.WriteLine("#########################################################################################################");
            Console.ResetColor();

        }
        public static void AdminHeader()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("......................ADMIN PANEL........................");

        }
        public static void UserHeader()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("......................USER PANEL........................");
        }


    }
}
