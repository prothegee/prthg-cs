using Xunit;
using prthgcs;


namespace prthgcs.test;


public class UnitTest1
{
    private const string m_email = "foo@bar.baz";

    private const string m_password = "password123!";
    private const string m_passwordSalt = "superSALT321!";

    private const string m_message = "secret message #1 !";

    private const string m_iKeyXChaCha20 = "abcdefghijklmnopqrstuvwxyz123456";
    private const string m_iVecXChaCha20 = "abcdefghijklmnopqrstuvwx";

    private const int m_iKeyAES = 123456789;
    private const int m_iVecAES = 987654321;

    private const long m_iKeyRC6 = 1234567891234567;
    private const long m_iVecRC6 = 9876543219876543;

    readonly CCryptography crypt = new();


    [Fact]
    public void TestSHA1()
    {
        string SHA1 = crypt.GenerateSHA1(m_email);
        if (SHA1 != "93560DA644DAA8BE7EC684EA113CA02287F80AD7")
        {
            var message = "SHA1 failed";
            Assert.Fail(message);
        }
    }

    [Fact]
    public void TestSHA224()
    {
        string SHA224 = crypt.GenerateSHA224(m_email);
        if (SHA224 != "9BE6EC75046155F3B5737BECA50B278FA01CD21E487CC88ADB019CF5")
        {
            var message = "SHA224 failed";
            Assert.Fail(message);
        }
    }

    [Fact]
    public void TestSHA256()
    {
        string SHA256 = crypt.GenerateSHA256(m_email);
        if (SHA256 != "80C66BDD90AE7FD4378CEF780422FE428EE7FB526301F7B236113C4ECE3BE146")
        {
            var message = "SHA256 failed";
            Assert.Fail(message);
        }
    }

    [Fact]
    public void TestSHA384()
    {
        string SHA384 = crypt.GenerateSHA384(m_email);
        if (SHA384 != "A7CF0DC6586E904F0FA5CDE24AFC64ED5D8730599FAD759A4E8543EFCFE687CEDC70A68B50384E9DBC9F816CCFF07186")
        {
            var message = "SHA384 failed";
            Assert.Fail(message);
        }
    }

    [Fact]
    public void TestSHA512()
    {
        string SHA512 = crypt.GenerateSHA512(m_email);
        if (SHA512 != "C6A0F190A0E38156B5A8DEB0E1BB5B192FFAEA46BF4C3E69082B3D71F85C7B3DDC8E5AFC4A81A5565F36361811ABBEE4E88CC1B367D6A6A8EAC36C31BD9ED75C")
        {
            var message = "SHA512 failed";
            Assert.Fail(message);
        }
    }

    [Fact]
    public void TestBLAKE2b()
    {
        string BLAKE2b = crypt.GenerateBLAKE2b(m_email);
        if (BLAKE2b != "BB07EFD34B28ED04357C760D2E2C00EF947E612D12D68E12A67B19B3F09E7C02A9D2D979F64BDCA47C35A2EFAF2E3B1AF2964475F616EFFA843B3FC25A83DC7A")
        {
            var message = "BLAKE2b failed";
            Assert.Fail(message);
        }
    }

    [Fact]
    public void TestHasherSCRYPT()
    {
        string SCRYPT = crypt.GenerateHasherSCRYPT(m_password, m_passwordSalt);
        if (SCRYPT != "0E3CBFDA7121E108F4CE6800C03C18171FB47BB46AAB782796F1D6F3FF9F798BFA6C159D38B685C91CF91C28082D4C92C41243DFD13048620672504F5AB3DA26593592312239D38A6ACCFCA37328B3AD87A0DA385AE038D08BD09A73D8CB70EF69C3D5FA5FA92E374390633812ABBA292809E11CA9593ED3518B6FAF9CAA19B8C8BDA858BEE52539E6AAC0758DA8988E3565DACED44CBAED2BC95E74D131B2E1C45F7C3C8942CBD801392FBCC14462C577F3F29E88C0474ED84DFC0CBB5D05C52F85C4208C70A94FEAC26A5441EA7AA3A63EEC45FBC641C66992E86A137E2CEA0F457C0E037F375AA11FF773C85F7925B34A77CB8CB8BB8F1FCFBD9821A993D8")
        {
            var message = "SCRYPT failed";
            Assert.Fail(message);
        }
    }

    [Fact]
    public void TestXChaCha20()
    {
        string EncryptXChaCha20 = crypt.EncryptXChaCha20(m_message, m_iKeyXChaCha20, m_iVecXChaCha20);
        string DecryptXChaCha20 = crypt.DecryptXChaCha20(EncryptXChaCha20, m_iKeyXChaCha20, m_iVecXChaCha20);
        if (m_message != DecryptXChaCha20)
        {
            var message = "XChaCha20 message & decrypt failed";
            Assert.Fail(message);
        }
    }

    [Fact]
    public void TestAES()
    {
        string EncryptAES = crypt.EncryptAES(m_message, m_iKeyAES, m_iVecAES);
        string DecryptAES = crypt.DecryptAES(EncryptAES, m_iKeyAES, m_iVecAES);
        if (m_message != DecryptAES)
        {
            var message = "AES Rijndael message & decrypt failed";
            Assert.Fail(message);
        }
    }

    [Fact]
    public void TestRC6()
    {
        string EncryptRC6 = crypt.EncryptRC6(m_message, m_iKeyRC6, m_iVecRC6);
        string DecryptRC6 = crypt.DecryptRC6(EncryptRC6, m_iKeyRC6, m_iVecRC6);
        if (m_message != DecryptRC6)
        {
            var message = "RC6 message & decrypt failed";
            Assert.Fail(message);
        }
    }
}