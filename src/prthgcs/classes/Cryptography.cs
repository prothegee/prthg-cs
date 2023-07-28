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
        /// generate sha1 from input
        /// <code>
        /// STATUS: OK
        /// </code>
        /// <code>
        /// return length will be 40
        /// </code>
        /// <param name="input"></param>
        /// <returns></returns>
        /// </summary>
        public string GenerateSHA1(string input)
        {
            var pInput = GenerateSHA1_CPPPORT(input);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "GenerateSHA224", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GenerateSHA224_CPPPORT(string input);

        /// <summary>
        /// generate sha224 from input
        /// <code>
        /// STATUS: OK
        /// </code>
        /// <code>
        /// return length will be 56
        /// </code>
        /// <param name="input"></param>
        /// <returns></returns>
        /// </summary>
        public string GenerateSHA224(string input)
        {
            var pInput = GenerateSHA224_CPPPORT(input);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "GenerateSHA256", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GenerateSHA256_CPPPORT(string input);

        /// <summary>
        /// generate sha256 from input
        /// <code>
        /// STATUS: OK
        /// </code>
        /// <code>
        /// return length will be 64
        /// </code>
        /// <param name="input"></param>
        /// <returns></returns>
        /// </summary>
        public string GenerateSHA256(string input)
        {
            var pInput = GenerateSHA256_CPPPORT(input);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "GenerateSHA384", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GenerateSHA384_CPPPORT(string input);

        /// <summary>
        /// generate sha384 from input
        /// <code>
        /// STATUS: OK
        /// </code>
        /// <code>
        /// return length will be 96
        /// </code>
        /// <param name="input"></param>
        /// <returns></returns>
        /// </summary>
        public string GenerateSHA384(string input)
        {
            var pInput = GenerateSHA384_CPPPORT(input);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "GenerateSHA512", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GenerateSHA512_CPPPORT(string input);

        /// <summary>
        /// generate sha512 from input
        /// <code>
        /// STATUS: OK
        /// </code>
        /// <code>
        /// return length will be 128
        /// </code>
        /// <param name="input"></param>
        /// <returns></returns>
        /// </summary>
        public string GenerateSHA512(string input)
        {
            var pInput = GenerateSHA512_CPPPORT(input);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "GenerateBLAKE2b", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GenerateBLAKE2b_CPPPORT(string input);

        /// <summary>
        /// generate blake2b from input
        /// <code>
        /// STATUS: OK
        /// </code>
        /// <code>
        /// return length will be 128
        /// </code>
        /// <param name="input"></param>
        /// <returns></returns>
        /// </summary>
        public string GenerateBLAKE2b(string input)
        {
            var pInput = GenerateBLAKE2b_CPPPORT(input);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "GenerateHasherSCRYPT", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GenerateHasherSCRYPT_CPPPORT(string input, string salt);

        /// <summary>
        /// generate password hasher using scrypt
        /// <code>
        /// STATUS: OK
        /// </code>
        /// <param name="input"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        /// </summary>
        public string GenerateHasherSCRYPT(string input, string salt)
        {
            var pInput = GenerateHasherSCRYPT_CPPPORT(input, salt);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "EncryptXChaCha20", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr EncryptXChaCha20_CPPPORT(string input, string initializeKey, string initializeVector);

        /// <summary>
        /// encrypt input using XChaCha20 stream cipher
        /// <code>
        /// STATUS: OK
        /// </code>
        /// <code>
        /// initializeKey length must 32 byte e.g. abcdefghijklmnopqrstuvwxyz123456
        /// </code>
        /// <code>
        /// initializeVector length must 24 byte e.g. abcdefghijklmnopqrstuvwx
        /// </code>
        /// <param name="input"></param>
        /// <param name="initializeKey"></param>
        /// <param name="initializeVector"></param>
        /// <returns></returns>
        /// </summary>
        public string EncryptXChaCha20(string input, string initializeKey, string initializeVector)
        {
            var pInput = EncryptXChaCha20_CPPPORT(input, initializeKey, initializeVector);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "DecryptXChaCha20", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr DecryptXChaCha20_CPPPORT(string input, string initializeKey, string initializeVector);

        /// <summary>
        /// decrypt input using XChaCha20 stream cipher
        /// <code>
        /// STATUS: OK
        /// </code>
        /// <code>
        /// initializeKey length must 32 byte e.g. abcdefghijklmnopqrstuvwxyz123456
        /// </code>
        /// <code>
        /// initializeVector length must 24 byte e.g. abcdefghijklmnopqrstuvwx
        /// </code>
        /// <param name="input"></param>
        /// <param name="initializeKey"></param>
        /// <param name="initializeVector"></param>
        /// <returns></returns>
        /// </summary>
        public string DecryptXChaCha20(string input, string initializeKey, string initializeVector)
        {
            var pInput = DecryptXChaCha20_CPPPORT(input, initializeKey, initializeVector);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "EncryptCBCAES", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr EncryptCBCAES_CPPPORT(string input, int initializeKey, int initializeVector);

        /// <summary>
        /// encrypt input using CBC AES stream cipher
        /// <code>
        /// STATUS: ERROR
        /// </code>
        /// <code>
        /// initializeKey length must 9 byte and can't start from 0 e.g. 123456789
        /// </code>
        /// <code>
        /// initializeVector length must 9 byte and can't start from 0 e.g. 987654321
        /// </code>
        /// <param name="input"></param>
        /// <param name="initializeKey"></param>
        /// <param name="initializeVector"></param>
        /// <returns></returns>
        /// </summary>
        public string EncryptCBCAES(string input, int initializeKey, int initializeVector)
        {
            var pInput = EncryptCBCAES_CPPPORT(input, initializeKey, initializeVector);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "DecryptCBCAES", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr DecryptCBCAES_CPPPORT(string input, int initializeKey, int initializeVector);

        /// <summary>
        /// decrypt input using CBC AES stream cipher
        /// <code>
        /// STATUS: ERROR
        /// </code>
        /// <code>
        /// initializeKey length must 9 byte and can't start from 0 e.g. 123456789
        /// </code>
        /// <code>
        /// initializeVector length must 9 byte and can't start from 0 e.g. 987654321
        /// </code>
        /// <param name="input"></param>
        /// <param name="initializeKey"></param>
        /// <param name="initializeVector"></param>
        /// <returns></returns>
        /// </summary>
        public string DecryptCBCAES(string input, int initializeKey, int initializeVector)
        {
            var pInput = DecryptCBCAES_CPPPORT(input, initializeKey, initializeVector);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }
    }
}