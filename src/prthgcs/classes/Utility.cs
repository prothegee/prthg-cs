namespace prthgcs
{
    /// <summary>
    /// prthgcs utility class
    /// </summary>
    public class CUtility
    {
        private string m_alphanumeric;


        public CUtility()
        {
            this.m_alphanumeric = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        }


        public int GenerateRandomNumber(int min, int max)
        {
            var rd = new Random();
            return rd.Next(min, max);
        }
        public double GenerateRandomNumber(double min, double max)
        {
            var rd = new Random();
            return rd.NextDouble() * (max - min) + min;
        }

        /// <summary>
        /// geneerate random alphanumeric
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string GenerateRandomAlphanumeric(int length)
        {
            string result = "";

            if (length <= 1) { length = 1; }

            for (int i = 0; i < length; i++)
            {
                var j = GenerateRandomNumber(0, (int)m_alphanumeric.Length - 1);
                result += m_alphanumeric[j];
            }

            return result;
        }

        /// <summary>
        /// generate random uuid
        /// </summary>
        /// <returns></returns>
        public string GenerateRandomUUID()
        {
            string result;
            string str1 = GenerateRandomAlphanumeric(8), str2 = GenerateRandomAlphanumeric(4), str3 = GenerateRandomAlphanumeric(4), str4 = GenerateRandomAlphanumeric(4), str5 = GenerateRandomAlphanumeric(12);

            result = @$"{str1}-{str2}-{str3}-{str4}-{str5}";

            return result;
        }

        /// <summary>
        /// check if input is alphabetic value
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool CheckInputIsAlphabetic(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }

        /// <summary>
        /// check if input is alphanumeric value
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool CheckInputIsAlphaNumeric(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9]+$");
        }

        /// <summary>
        /// change input to letter case
        /// </summary>
        /// <param name="input"></param>
        /// <param name="letterCase">0 is lowercase, 1 is uppercase, 2 is mixedcase</param>
        /// <returns></returns>
        public string ChangeInputLetterCase(string input, int letterCase)
        {
            string result = "";

            switch (letterCase)
            {
                case 0:
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        result += input[i].ToString().ToLower();
                    }
                }
                break;

                case 1:
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        result += input[i].ToString().ToUpper();
                    }
                }
                break;

                case 2:
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        // 0 is lower, 1 is upper
                        var mixedcase = GenerateRandomNumber(0, 2);

                        if (mixedcase == 0 && CheckInputIsAlphabetic(input[i].ToString()))
                        {
                            result += input[i].ToString().ToLower();
                        }
                        else if (mixedcase == 1 && CheckInputIsAlphabetic(input[i].ToString()))
                        {
                            result += input[i].ToString().ToUpper();
                        }
                        else
                        {
                            result += input[i].ToString();
                        }
                    }
                }
                break;

                default:
                {
                    result = input;
                }
                break;
            }

            return result;
        }
    }
}