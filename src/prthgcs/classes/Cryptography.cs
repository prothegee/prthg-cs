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
        /// generate sha224 from input
        /// <code>
        /// STATUS: OK
        /// </code>
        /// <code>
        /// return length will be 56
        /// </code>
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
        /// </summary>
        /// <param name="input"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
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
        /// </summary>
        /// <param name="input"></param>
        /// <param name="initializeKey"></param>
        /// <param name="initializeVector"></param>
        /// <returns></returns>
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
        /// </summary>
        /// <param name="input"></param>
        /// <param name="initializeKey"></param>
        /// <param name="initializeVector"></param>
        /// <returns></returns>
        public string DecryptXChaCha20(string input, string initializeKey, string initializeVector)
        {
            var pInput = DecryptXChaCha20_CPPPORT(input, initializeKey, initializeVector);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "EncryptAES", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr EncryptAES_CPPPORT(string input, int initializeKey, int initializeVector);

        /// <summary>
        /// encrypt input using CBC AES Rijndael stream cipher
        /// <code>
        /// STATUS: OK
        /// </code>
        /// <code>
        /// initializeKey length must 9 byte and can't start from 0 e.g. 123456789
        /// </code>
        /// <code>
        /// initializeVector length must 9 byte and can't start from 0 e.g. 987654321
        /// </code>
        /// </summary>
        /// <param name="input"></param>
        /// <param name="initializeKey"></param>
        /// <param name="initializeVector"></param>
        /// <returns></returns>
        public string EncryptAES(string input, int initializeKey, int initializeVector)
        {
            var pInput = EncryptAES_CPPPORT(input, initializeKey, initializeVector);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "DecryptAES", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr DecryptAES_CPPPORT(string input, int initializeKey, int initializeVector);

        /// <summary>
        /// decrypt input using CBC AES Rijndael stream cipher
        /// <code>
        /// STATUS: ERROR when decrypt input
        /// </code>
        /// <code>
        /// initializeKey length must 9 byte and can't start from 0 e.g. 123456789
        /// </code>
        /// <code>
        /// initializeVector length must 9 byte and can't start from 0 e.g. 987654321
        /// </code>
        /// </summary>
        /// <param name="input"></param>
        /// <param name="initializeKey"></param>
        /// <param name="initializeVector"></param>
        /// <returns></returns>
        public string DecryptAES(string input, int initializeKey, int initializeVector)
        {
            var pInput = DecryptAES_CPPPORT(input, initializeKey, initializeVector);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "EncryptRC6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr EncryptRC6_CPPPORT(string input, long initializeKey, long initializeVector);

        /// <summary>
        /// encrypt encrypt input using CBC R6 stream cipher
        /// <code>
        /// STATUS: OK
        /// </code>
        /// <code>
        /// initializeKey length must 16 byte and can't start from 0 e.g. 1234567891234567
        /// </code>
        /// <code>
        /// initializeVector length must 16 byte and can't start from 0 e.g. 9876543219876543
        /// </code>
        /// </summary>
        /// <param name="input"></param>
        /// <param name="initializeKey"></param>
        /// <param name="initializeVector"></param>
        /// <returns></returns>
        public string EncryptRC6(string input, long initializeKey, long initializeVector)
        {
            var pInput = EncryptRC6_CPPPORT(input, initializeKey, initializeVector);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }

        [DllImport("cppport.dll", EntryPoint = "DecryptRC6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr DecryptRC6_CPPPORT(string input, long initializeKey, long initializeVector);

        /// <summary>
        /// encrypt decrypt input using CBC R6 stream cipher
        /// <code>
        /// STATUS: OK
        /// </code>
        /// <code>
        /// initializeKey length must 16 byte and can't start from 0 e.g. 1234567891234567
        /// </code>
        /// <code>
        /// initializeVector length must 16 byte and can't start from 0 e.g. 9876543219876543
        /// </code>
        /// </summary>
        /// <param name="input"></param>
        /// <param name="initializeKey"></param>
        /// <param name="initializeVector"></param>
        /// <returns></returns>
        public string DecryptRC6(string input, long initializeKey, long initializeVector)
        {
            var pInput = DecryptRC6_CPPPORT(input, initializeKey, initializeVector);
            var pInputMarshal = Marshal.PtrToStringAnsi(pInput);

            return pInputMarshal;
        }
    }
}