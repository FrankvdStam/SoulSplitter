cargo build --target x86_64-pc-windows-msvc  --release
rem --target i686-pc-windows-msvc
echo f | xcopy /f /y "target\x86_64-pc-windows-msvc\release\soulmods.dll"   "src\SoulMemory\soulmods\x64\soulmods.dll"
rem echo f | xcopy /f /y "target\i686-pc-windows-msvc\release\soulmods.dll"     "src\SoulMemory\soulmods\x86\soulmods.dll"

pause