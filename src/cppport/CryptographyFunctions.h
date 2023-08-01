#ifndef CPPPORT_CRYPTOGRAPHY_FUNCTIONS_H
#define CPPPORT_CRYPTOGRAPHY_FUNCTIONS_H
#include "cppport_export.gen.h"

#include <string>

#include <cryptopp/ec2n.h>
#include <cryptopp/hex.h>
#include <cryptopp/modes.h>
#include <cryptopp/files.h>
#include <cryptopp/osrng.h>
#include <cryptopp/cryptlib.h>
#include <cryptopp/secblock.h>
#include <cryptopp/filters.h>
#include <cryptopp/hex.h>
#include <cryptopp/words.h>

#include <cryptopp/blake2.h>
#include <cryptopp/scrypt.h>
#include <cryptopp/sha.h>
#include <cryptopp/gcm.h>
#include <cryptopp/aes.h>
#include <cryptopp/chacha.h>
#include <cryptopp/rc6.h>


extern "C"
{
    // THIS IS TEST
    CPPPORT_EXPORT int Gen420();

    // THIS IS TEST
    CPPPORT_EXPORT const char *GetInputParam(const char *input);

    /**
     * @brief generate sha1 from input
     * 
     * @note STATUS: OK
     * 
     * @note return length will be 40
     * 
     * @param input 
     * @return CPPPORT_EXPORT const char* 
     */
    CPPPORT_EXPORT const char *GenerateSHA1(const char *input);

    /**
     * @brief generate sha224 from input
     * 
     * @note STATUS: OK
     * 
     * @note return length will be 56
     * 
     * @param input 
     * @return CPPPORT_EXPORT const char* 
     */
    CPPPORT_EXPORT const char *GenerateSHA224(const char *input);

    /**
     * @brief generate sha256 from input
     * 
     * @note STATUS: OK
     * 
     * @note return length will be 64
     * 
     * @param input 
     * @return CPPPORT_EXPORT const char* 
     */
    CPPPORT_EXPORT const char *GenerateSHA256(const char *input);

    /**
     * @brief generate sha384 from input
     * 
     * @note STATUS: OK
     * 
     * @note return length will be 96
     * 
     * @param input 
     * @return CPPPORT_EXPORT const char* 
     */
    CPPPORT_EXPORT const char *GenerateSHA384(const char *input);

    /**
     * @brief generate sha512 from input
     * 
     * @note STATUS: OK
     * 
     * @note return length will be 128
     * 
     * @param input 
     * @return CPPPORT_EXPORT const char* 
     */
    CPPPORT_EXPORT const char *GenerateSHA512(const char *input);

    /**
     * @brief generate blake2b from input
     * 
     * @note STATUS: OK
     * 
     * @note return length will be 128
     * 
     * @param input 
     * @return CPPPORT_EXPORT const char* 
     */
    CPPPORT_EXPORT const char *GenerateBLAKE2b(const char *input);

    /**
     * @brief generate password hasher using scrypt
     * 
     * @note STATUS: OK
     * 
     * @param input 
     * @return CPPPORT_EXPORT const char* 
     */
    CPPPORT_EXPORT const char *GenerateHasherSCRYPT(const char *input, const char *salt);

    /**
     * @brief encrypt input using XChaCha20 stream cipher
     * 
     * @note STATUS: OK
     * 
     * @note initializeKey length must 32 byte e.g. abcdefghijklmnopqrstuvwxyz123456
     * @note initializeVector length must 24 byte e.g. abcdefghijklmnopqrstuvwx
     * 
     * @param input 
     * @param initializeKey 
     * @param initializeVector 
     * @return CPPPORT_EXPORT const char* 
     */
    CPPPORT_EXPORT const char *EncryptXChaCha20(const char *input, const char *initializeKey, const char *initializeVector);

    /**
     * @brief decrypt input using XChaCha20 stream cipher
     * 
     * @note STATUS: OK
     * 
     * @note initializeKey length must 32 byte e.g. abcdefghijklmnopqrstuvwxyz123456
     * @note initializeVector length must 24 byte e.g. abcdefghijklmnopqrstuvwx
     * 
     * @param input 
     * @param initializeVector 
     * @param initializeKey 
     * @return CPPPORT_EXPORT const char* 
     */
    CPPPORT_EXPORT const char *DecryptXChaCha20(const char *input, const char *initializeKey, const char *initializeVector);

    /**
     * @brief encrypt input using CBC AES Rijndael stream cipher
     * 
     * @note STATUS: OK
     * 
     * @note initializeKey length must 9 byte and can't start from 0 e.g. 123456789
     * @note initializeVector length must 9 byte and can't start from 0 e.g. 987654321
     * 
     * @param input 
     * @param initializeKey 
     * @param initializeVector 
     * @return CPPPORT_EXPORT const char* 
     */
    CPPPORT_EXPORT const char *EncryptAES(const char *input, int initializeKey, int initializeVector);

    /**
     * @brief decrypt input using CBC AES Rijndael stream cipher
     * 
     * @note STATUS: ERROR when decrypt input
     * 
     * @note initializeKey length must 9 byte and can't start from 0 e.g. 123456789
     * @note initializeVector length must 9 byte and can't start from 0 e.g. 987654321
     * 
     * @param input 
     * @param initializeKey 
     * @param initializeVector 
     * @return CPPPORT_EXPORT const char* 
     */
    CPPPORT_EXPORT const char *DecryptAES(const char *input, int initializeKey, int initializeVector);

    /**
     * @brief encrypt input using CBC R6 stream cipher
     * 
     * @note STATUS: OK
     * 
     * @note initializeKey length must 16 byte and can't start from 0 e.g. 1234567891234567
     * @note initializeVector length must 16 byte and can't start from 0 e.g. 9876543219876543
     * 
     * @param input 
     * @param initializeKey 
     * @param initializeVector 
     * @return std::string 
     */
    CPPPORT_EXPORT const char *EncryptRC6(const char *input, long initializeKey, long initializeVector);

    /**
     * @brief decrypt input using CBC R6 stream cipher
     * 
     * @note STATUS: OK
     * 
     * @note initializeKey length must 16 byte and can't start from 0 e.g. 1234567891234567
     * @note initializeVector length must 16 byte and can't start from 0 e.g. 9876543219876543
     * 
     * @param input 
     * @param initializeKey 
     * @param initializeVector 
     * @return std::string 
     */
    CPPPORT_EXPORT const char *DecryptRC6(const char *input, long initializeKey, long initializeVector);
}


#endif // CPPPORT_CRYPTOGRAPHY_FUNCTIONS_H