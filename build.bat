@echo off

echo Building exe...
echo ----------------------------------------

set csc_path=C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe

%csc_path% /t:exe /out:hws2xml.exe Main.cs OpenTK.cs TiltedEngine.cs

echo ----------------------------------------
echo Done!
