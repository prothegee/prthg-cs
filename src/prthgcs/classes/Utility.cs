namespace prthgcs
{
    /// <summary>
    /// prthgcs utility class
    /// </summary>
    public class CUtility
    {
        private string m_alphanumeric = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";


        /// <summary>
        /// generate random number
        /// </summary>
        /// <note>may remove</note>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GenRandomNumber<T>(T? min, T? max)
        {
            #pragma warning disable 8600
            #pragma warning disable 8605

            T result;

            var rd = new Random();

            if (min is int && min is not null && max is int && max is not null)
            {
                int _min = (int)(object)min, _max = (int)(object)min;

                var rs = rd.Next(_min, _max);
                result = (T)(object)rs;
            }
            else if (min is double && min is not null && max is double && max is not null)
            {
                double _min = (double)(object)min, _max = (double)(object)min;

                var rs = rd.NextDouble() * (_max - _min) + _min;
                result = (T)(object)rs;
            }
            else
            {
                int _min = (int)(object)min, _max = (int)(object)min;
                
                var rs = rd.Next(_min, _max);
                result = (T)(object)rs;
            }

            #pragma warning restore 8600
            #pragma warning restore 8605

            return result;
        }

        /// <summary>
        /// geneerate random alphanumeric
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string GenRandomAlphanumeric(int length)
        {
            string result = "";

            if (length <= 1) { length = 1; }

            for (int i = 0; i < length; i++)
            {
                var j = GenRandomNumber(0, (int)m_alphanumeric.Length - 1);
                result += m_alphanumeric[j];
            }

            return result;
        }

        /// <summary>
        /// generate random uuid
        /// </summary>
        /// <returns></returns>
        public string GenRandomUUID()
        {
            string result;
            string str1 = GenRandomAlphanumeric(8), str2 = GenRandomAlphanumeric(4), str3 = GenRandomAlphanumeric(4), str4 = GenRandomAlphanumeric(4), str5 = GenRandomAlphanumeric(12);

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
            return !Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }

        /// <summary>
        /// check if input is alphanumeric value
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool CheckInputIsAlphaNumeric(string input)
        {
            return !Regex.IsMatch(input, @"^[a-zA-Z0-9]+$");
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
                        int mixedcase = GenRandomNumber(0, 1);

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