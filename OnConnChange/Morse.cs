using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnConnChange
{
    using System;

    public class Morse
    {
        public static int MorseTimeDit = 80;
        public static int MorseAudioFrequency = 650;
        public static int MorseTimingLetter { get { return 3 * MorseTimeDit; } }
        public static int MorseTimingDot { get { return MorseTimeDit; } }
        public static int MorseTimingDash { get { return 3 * MorseTimeDit; } }
        public static int MorseTimingWord { get { return 7 * MorseTimeDit; } }

        public static void MorseAsString(string s)
        {
            s = s.ToLowerInvariant();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(Character(s[i]));
            }
            MorseCodeString(sb.ToString());
        }

        public static String Character(char c)
        {
            switch (c.ToString().ToLowerInvariant())
            {
                case "a": return ".- "; 
                case "b": return"-... "; 
                case "c": return "-.-. " ; 
                case "d": return "-.. " ; 
                case "e": return ". " ; 
                case "f": return "..-. " ; 
                case "g": return "--. " ; 
                case "h": return ".... " ; 
                case "i": return ".. " ; 
                case "j": return ".--- " ; 
                case "k": return "-.- " ; 
                case "l": return ".-.. " ; 
                case "m": return "-- " ; 
                case "n": return "-. " ; 
                case "o": return "--- " ; 
                case "p": return ".--. " ; 
                case "q": return "--.- " ; 
                case "r": return ".-. " ; 
                case "s": return "... " ; 
                case "t": return "- " ; 
                case "u": return "..- " ; 
                case "v": return "...- " ; 
                case "w": return ".-- " ; 
                case "x": return "-..- " ; 
                case "y": return "-.-- " ; 
                case "z": return "--.. " ; 

                case "1": return ".---- " ; 
                case "2": return "..--- " ; 
                case "3": return "...-- " ; 
                case "4": return "....- " ; 
                case "5": return "..... " ; 
                case "6": return "-.... " ; 
                case "7": return "--... " ; 
                case "8": return "---.. " ; 
                case "9": return "----. " ; 
                case "0": return "----- " ; 

                case ".": return ".-.-.- " ; 
                case ",": return "--..-- " ; 
                case "?": return "..--.. " ; 
                case "@": return ".--.-. " ; 

                case "": return "!" ; 
            }
            return "!";
        }

        public static void MorseCodeString(String morse)
        {
            for (int i = 0; i < morse.Length; i++)
            {
                char c = morse[i];

                switch (c)
                {
                    case '.': MorseDot(); break;
                    case '-': MorseDash(); break;
                    case '_': MorseDash(); break;
                    case ' ': MorsePause(); break;
                    case '!': MorseWordPause(); break;
                }
            }
        }

        public static void MorsePause()
        {
            System.Threading.Thread.Sleep(MorseTimingLetter);
        }

        public static void MorseWordPause()
        {
            System.Threading.Thread.Sleep(MorseTimingWord);
        }

        public static void MorseDot()
        {
            Console.Beep(MorseAudioFrequency, MorseTimingDot);
        }

        public static void MorseDash()
        {
            Console.Beep(MorseAudioFrequency, MorseTimingDash);
        }
    }

}
