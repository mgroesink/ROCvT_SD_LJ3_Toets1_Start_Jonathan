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
            List<int> awnser = new List<int>();

            for (awnser = value1;  < 0;)
            {

            }


                if (value1 % 2 == 0)
                {
                    value1 = value1 / 2;
                }
                else
                {
                    value1 = value1 * 3 + 1;
                }
            

            return awnser;
        }
    }
}
