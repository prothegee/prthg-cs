cmake_minimum_required(VERSION 3.15)
project(cppport LANGUAGES CXX)


# ########################################################################
message(STATUS "(MSG) - ${PROJECT_NAME}: compiler ${CMAKE_CXX_COMPILER_ID}")
# ########################################################################


# ########################################################################
if(CMAKE_TOOLCHAIN_FILE STREQUAL "")
    message(STATUS "(MSG) - ${PROJECT_NAME}: CMAKE_TOOLCHAIN_FILE is not supplied")
else()
    message(STATUS "(MSG) - ${PROJECT_NAME}: CMAKE_TOOLCHAIN_FILE is supplied as '${CMAKE_TOOLCHAIN_FILE}'")
endif()
# ########################################################################


# ########################################################################
include(CheckIncludeFileCXX)

check_include_file_cxx(coroutine HAS_COROUTINE)

if(HAS_COROUTINE)
    set(CMAKE_CXX_STANDARD 20)
    message(STATUS "(MSG) - ${PROJECT_NAME}: using c++20")
else ()
    set(CMAKE_CXX_STANDARD 17)
    message(STATUS "(MSG) - ${PROJECT_NAME}: using c++17")
endif (HAS_COROUTINE)

if (CMAKE_BUILD_TYPE STREQUAL "")
    set(CMAKE_BUILD_TYPE "Debug")
elseif(CMAKE_BUILD_TYPE STREQUAL "Profile")
    set(CMAKE_BUILD_TYPE "Debug")
endif()
message(STATUS "(MSG) - ${PROJECT_NAME}: build type is ${CMAKE_BUILD_TYPE}")
# ########################################################################


# ########################################################################
set(CPPPORT_FILE_SOURCE
    src/cppport/CryptographyFunctions.cc
)

add_library(${PROJECT_NAME}
    SHARED
        ${CPPPORT_FILE_SOURCE}
)
# ########################################################################


# ########################################################################
include(GenerateExportHeader)

generate_export_header(${PROJECT_NAME} EXPORT_FILE_NAME ${PROJECT_SOURCE_DIR}/src/cppport/cppport_export.gen.h)
# ########################################################################


# ########################################################################
find_package(cryptopp CONFIG REQUIRED)
target_link_libraries(${PROJECT_NAME}  PRIVATE cryptopp::cryptopp)
# ########################################################################


# ########################################################################
# reserved definitions
# ########################################################################


# ########################################################################
# reserved aux source
# ########################################################################


# ########################################################################
target_include_directories(${PROJECT_NAME}
    PUBLIC
        $<BUILD_INTERFACE:${PROJECT_SOURCE_DIR}/src/cppport>
)

target_sources(${PROJECT_NAME}
    PRIVATE
        ${CMAKE_CURRENT_SOURCE_DIR}/src/cppport
)
# ########################################################################