cargo build -Zmultitarget --target x86_64-pc-windows-msvc --release
rem cargo build -Zmultitarget --target x86_64-pc-windows-msvc --target=i686-pc-windows-msvc --release

echo f | xcopy /f /y "target\x86_64-pc-windows-msvc\release\soulsmods.dll"   "src\SoulMemory\soulsmods\x64\soulsmods.dll"

pause