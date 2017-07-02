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
            for (int i = 0; i < s.Length; i++)
            {
                Character(s[i]);
            }
        }

        public static void Character(char c)
        {
            switch (c.ToString().ToLowerInvariant())
            {
                case "a": MorseCodeString(".- "); break;
                case "b": MorseCodeString("-... "); break;
                case "c": MorseCodeString("-.-. "); break;
                case "d": MorseCodeString("-.. "); break;
                case "e": MorseCodeString(". "); break;
                case "f": MorseCodeString("..-. "); break;
                case "g": MorseCodeString("--. "); break;
                case "h": MorseCodeString(".... "); break;
                case "i": MorseCodeString(".. "); break;
                case "j": MorseCodeString(".--- "); break;
                case "k": MorseCodeString("-.- "); break;
                case "l": MorseCodeString(".-.. "); break;
                case "m": MorseCodeString("-- "); break;
                case "n": MorseCodeString("-. "); break;
                case "o": MorseCodeString("--- "); break;
                case "p": MorseCodeString(".--. "); break;
                case "q": MorseCodeString("--.- "); break;
                case "r": MorseCodeString(".-. "); break;
                case "s": MorseCodeString("... "); break;
                case "t": MorseCodeString("- "); break;
                case "u": MorseCodeString("..- "); break;
                case "v": MorseCodeString("...- "); break;
                case "w": MorseCodeString(".-- "); break;
                case "x": MorseCodeString("-..- "); break;
                case "y": MorseCodeString("-.-- "); break;
                case "z": MorseCodeString("--.. "); break;

                case "1": MorseCodeString(".---- "); break;
                case "2": MorseCodeString("..--- "); break;
                case "3": MorseCodeString("...-- "); break;
                case "4": MorseCodeString("....- "); break;
                case "5": MorseCodeString("..... "); break;
                case "6": MorseCodeString("-.... "); break;
                case "7": MorseCodeString("--... "); break;
                case "8": MorseCodeString("---.. "); break;
                case "9": MorseCodeString("----. "); break;
                case "0": MorseCodeString("----- "); break;

                case ".": MorseCodeString(".-.-.- "); break;
                case ",": MorseCodeString("--..-- "); break;
                case "?": MorseCodeString("..--.. "); break;
                case "@": MorseCodeString(".--.-. "); break;

                case "": MorseCodeString("!"); break;
            }
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
