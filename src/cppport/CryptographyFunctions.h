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


extern "C"
{
    // THIS IS TEST
    CPPPORT_EXPORT int Gen420();

    // THIS IS TEST
    CPPPORT_EXPORT const char *GetInputParam(const char *input);

    /**
     * @brief generate sha1 from input
     * 
     * @note return length will be 40
     * 
     * @param input 
     * @return CPPPORT_EXPORT const* 
     */
    CPPPORT_EXPORT const char *GenerateSHA1(const char *input);

    CPPPORT_EXPORT const char *GenerateSHA224(const char *input);
}


#endif // CPPPORT_CRYPTOGRAPHY_FUNCTIONS_H