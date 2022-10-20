class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LengthOfLongestSubstring("au"));
    }
    public static int LengthOfLongestSubstring(string s)
    {
        int result = 0;

        char[] inputSt = s.ToArray();
        if(inputSt != null && inputSt.Length > 0)
        {
            if (inputSt.Length == 1)
                return 1;

            int startWindow = 0;
            int endWindow = 0;
            string windowSt = inputSt[startWindow].ToString();

            while (endWindow < inputSt.Length - 1)
            {
                endWindow++;
                int indexFoundChar = windowSt.IndexOf(inputSt[endWindow]);

                if (indexFoundChar == -1)
                { // Not found
                    windowSt = string.Concat(windowSt, inputSt[endWindow]);

                    if (windowSt.Length > result)
                        result = windowSt.Length;
                }
                else
                {
                    if (windowSt.Length > result)
                        result = windowSt.Length;

                    // Slide the window to start and add one more character
                    windowSt = windowSt.Substring(++indexFoundChar);
                    windowSt = string.Concat(windowSt, inputSt[endWindow]);
                }
            }
        }

        return result;
    }
}
