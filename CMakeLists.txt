cmake_minimum_required(VERSION 3.15)
project(cppport LANGUAGES CXX)


# ########################################################################
if(INC_VPCKG)
    include("${INC_VPCKG_DIR}/scripts/buildsystems/vcpkg.cmake")
    message(STATUS "(MSG) - ${PROJECT_NAME}: INC_VPCKG_DIR is supplied as ${INC_VPCKG_DIR}")
else()
    message(STATUS "(MSG) - ${PROJECT_NAME}: INC_VPCKG_DIR is not supplied, will assume library already include from workstation environment")
endif(INC_VPCKG)
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