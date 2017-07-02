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

        public static void String(string s)
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
                case "a": FromString(".- "); break;
                case "b": FromString("-... "); break;
                case "c": FromString("-.-. "); break;
                case "d": FromString("-.. "); break;
                case "e": FromString(". "); break;
                case "f": FromString("..-. "); break;
                case "g": FromString("--. "); break;
                case "h": FromString(".... "); break;
                case "i": FromString(".. "); break;
                case "j": FromString(".--- "); break;
                case "k": FromString("-.- "); break;
                case "l": FromString(".-.. "); break;
                case "m": FromString("-- "); break;
                case "n": FromString("-. "); break;
                case "o": FromString("--- "); break;
                case "p": FromString(".--. "); break;
                case "q": FromString("--.- "); break;
                case "r": FromString(".-. "); break;
                case "s": FromString("... "); break;
                case "t": FromString("- "); break;
                case "u": FromString("..- "); break;
                case "v": FromString("...- "); break;
                case "w": FromString(".-- "); break;
                case "x": FromString("-..- "); break;
                case "y": FromString("-.-- "); break;
                case "z": FromString("--.. "); break;

                case "1": FromString(".---- "); break;
                case "2": FromString("..--- "); break;
                case "3": FromString("...-- "); break;
                case "4": FromString("....- "); break;
                case "5": FromString("..... "); break;
                case "6": FromString("-.... "); break;
                case "7": FromString("--... "); break;
                case "8": FromString("---.. "); break;
                case "9": FromString("----. "); break;
                case "0": FromString("----- "); break;

                case ".": FromString(".-.-.- "); break;
                case ",": FromString("--..-- "); break;
                case "?": FromString("..--.. "); break;
                case "@": FromString(".--.-. "); break;

                case "": FromString("!"); break;
            }
        }

        public static void FromString(String morse)
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
