namespace prthgcs
{
    /// <summary>
    /// prthgcs cryptography class
    /// </summary>
    public class CCryptography
    {
        public CCryptography()
        {
        }

        [DllImport("cppport.dll", EntryPoint = "GenerateSHA1", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GenerateSHA1_CPPPORT(string input);

        /// <summary>
        /// generate sha1 from input, length will be 40
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string GenerateSHA1(string input)
        {
            var pInput = GenerateSHA1_CPPPORT(input);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "GenerateSHA224", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GenerateSHA224_CPPPORT(string input);

        /// <summary>
        /// generate sha224 from input, length will be 56
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string GenerateSHA224(string input)
        {
            var pInput = GenerateSHA224_CPPPORT(input);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }
    }
}