void Main()
{
	Go();
}

        public static void Go()
        {
            /*
            Console.WriteLine((int)'A');//65
            Console.WriteLine((int)'Z');//90
            Console.WriteLine((int)'a');//97
            Console.WriteLine((int)'z');//122

            middle-Outz
            2
            okffng-Qwvb

            1X7T4VrCs23k4vv08D6yQ3S19G4rVP188M9ahuxB6j1tMGZs1m10ey7eUj62WV2exLT4C83zl7Q80M
            27
            1Y7U4WsDt23l4ww08E6zR3T19H4sWQ188N9bivyC6k1uNHAt1n10fz7fVk62XW2fyMU4D83am7R80N
            */
            /*
            Print(
                "middle-Outz",
                2,
                "okffng-Qwvb"
             );

            Print(
                "1X7T4VrCs23k4vv08D6yQ3S19G4rVP188M9ahuxB6j1tMGZs1m10ey7eUj62WV2exLT4C83zl7Q80M", 
                27,
                "1Y7U4WsDt23l4ww08E6zR3T19H4sWQ188N9bivyC6k1uNHAt1n10fz7fVk62XW2fyMU4D83am7R80N"
             );
            */
            Print(
                "6DWV95HzxTCHP85dvv3NY2crzt1aO8j6g2zSDvFUiJj6XWDlZvNNr",
                87,
                "6MFE95QigCLQY85mee3WH2laic1jX8s6p2iBMeODrSs6GFMuIeWWa"
             );
        }
        static void Print(string s, int k, string w)
        {
            var x = caesarCipher(s, k);
            Console.WriteLine(s);
            Console.WriteLine(x);
            Console.WriteLine(w);
            Console.WriteLine(x == w);
        }
// Define other methods and classes here

        public static string caesarCipher(string s, int k)
        {
            int y = 90 - 65;
            if (k > y)
            {
                int u = Convert.ToInt32(k / y);
                k = k % y - u;
            }

            bool ok = false;
            string r = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                char n;
                var c = s[i];
                ok = 
                    Get(c, 65, 90, k, out n) ||
                    Get(c, 97, 122, k, out n) ||
                    ok;
                r = string.Concat(r, n);
            }

            return ok ? r : s;
        }

        private static bool Get(char c, int i, int j, int k, out char n)
        {
            n = c;
            if (c >= i && c <= j)
            {
                int z = c + k;
                if (z > j)
                {
                    int d = j - i + 1;
                    z -= d;
                }
                n = (char)z;
                return true;
            }

            return false;
        }
