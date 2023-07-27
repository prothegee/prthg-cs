#include "CryptographyFunctions.h"


CPPPORT_EXPORT int Gen420()
{
    return 420;
}

CPPPORT_EXPORT const char *GetInputParam(const char *input)
{
    std::string fInput(input);
    int length = fInput.length() + 1;

    char* bResult = new char[length];
    const char* fResult = new char[length];

    strcpy(bResult, fInput.c_str());
    fResult = bResult;

    return fResult;
}

CPPPORT_EXPORT const char *GenerateSHA1(const char *input)
{
    std::string tInput(input), tResult;

    CryptoPP::SHA1 hash;
    CryptoPP::byte digest[CryptoPP::SHA1::DIGESTSIZE];
    CryptoPP::HexEncoder encoder;

    hash.CalculateDigest(digest, (CryptoPP::byte*) tInput.c_str(), tInput.length());

    encoder.Attach(new CryptoPP::StringSink(tResult));
    encoder.Put(digest, sizeof(digest));
    encoder.MessageEnd();

    int length = tResult.length() + 1;

    char* bResult = new char[length];
    const char* fResult = new char[length];

    strcpy(bResult, tResult.c_str());
    fResult = bResult;

    return fResult;
}

CPPPORT_EXPORT const char *GenerateSHA224(const char *input)
{
    std::string tInput(input), tResult;

    CryptoPP::SHA224 hash;
    CryptoPP::byte digest[CryptoPP::SHA224::DIGESTSIZE];
    CryptoPP::HexEncoder encoder;

    hash.CalculateDigest(digest, (CryptoPP::byte*) tInput.c_str(), tInput.length());

    encoder.Attach(new CryptoPP::StringSink(tResult));
    encoder.Put(digest, sizeof(digest));
    encoder.MessageEnd();

    int length = tResult.length() + 1;

    char* bResult = new char[length];
    const char* fResult = new char[length];

    strcpy(bResult, tResult.c_str());
    fResult = bResult;

    return fResult;
}
