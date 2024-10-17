namespace I1SD_Toets1_Start
{
    public static class MyFunctions
    {
        /// <summary>
        /// Returns the string "Welkom bij deze ASP-NET / C# toets"
        /// </summary>
        /// <returns></returns>
        public static string Hallo()
        {
            return "Welkom bij deze ASP-NET / C# toets";
        }

        public static List<int> CreateNumberSequence(int value1)
        {
            if (value1 >= 10 && value1 <= 100)
            {
                List<int> awnser = new List<int>();
                awnser.Add(value1);


                while (value1 != 1)
                {
                    if (value1 % 2 == 0)
                    {
                        value1 = value1 / 2;
                        awnser.Add(value1);
                    }
                    else
                    {
                        value1 = value1 * 3 + 1;
                        awnser.Add(value1);
                    }
                }
                return awnser;
            }
            else
            {
                throw new ArgumentException("Getal moet groter zijn dan 5");
            }
        }
    }
}
