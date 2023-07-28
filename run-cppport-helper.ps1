clear;

cp ./build/Debug/cppport.* ./src/prthgcs/bin/Debug/net6.0/;
cp ./build/Debug/cppport.* ./src/prthgcs/bin/Debug/net7.0/;
cp ./build/Debug/cppport.* ./src/prthgcs/obj/Debug/net6.0/;
cp ./build/Debug/cppport.* ./src/prthgcs/obj/Debug/net7.0/;

cp ./build/Release/cppport.* ./src/prthgcs/bin/Release/net6.0/;
cp ./build/Release/cppport.* ./src/prthgcs/bin/Release/net7.0/;
cp ./build/Release/cppport.* ./src/prthgcs/obj/Release/net6.0/;
cp ./build/Release/cppport.* ./src/prthgcs/obj/Release/net7.0/;

cp ./build/Debug/cppport.* ./test/bin/Debug/net6.0/;
cp ./build/Debug/cppport.* ./test/bin/Debug/net7.0/;
cp ./build/Debug/cppport.* ./test/obj/Debug/net6.0/;
cp ./build/Debug/cppport.* ./test/obj/Debug/net7.0/;

cp ./build/Release/cppport.* ./test/bin/Release/net6.0/;
cp ./build/Release/cppport.* ./test/bin/Release/net7.0/;
cp ./build/Release/cppport.* ./test/obj/Release/net6.0/;
cp ./build/Release/cppport.* ./test/obj/Release/net7.0/;

dotnet restore .;
dotnet build -c Debug;
dotnet build -c Release;