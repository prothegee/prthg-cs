namespace prthgcs.test;


public class UnitTest1
{
    private readonly string m_email = "foo@bar.baz";
    // private readonly string m_message = "secret message! c#";
    // private readonly string m_initializeKeyStr = "abcdefghijklmnopqrstuvwxyz123456";
    // private readonly string m_initializeVectorStr = "abcdefghijklmnopqrstuvwx";
    // private readonly int m_initializeKeyInt = 123456789;
    // private readonly int m_initializeVectorInt = 987654321;
    // private readonly string m_password = "password123!";


    [Fact]
    public void TestCryptography()
    {
        Console.WriteLine("--------- Start Test CCryptography ---------");

        CCryptography crypt = new CCryptography();

        string SHA1 = crypt.GenerateSHA1(m_email);
        Console.WriteLine("SHA1:");
        Console.WriteLine(SHA1);

        string SHA224 = crypt.GenerateSHA224(m_email);
        Console.WriteLine("SHA224:");
        Console.WriteLine(SHA224);

        Console.WriteLine("---------  End Test CCryptography  ---------");
    }
}