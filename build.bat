@echo off

set csc_path=C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe
set mcs_path=C:\Program Files (x86)\Mono\bin\mcs

echo ----------------------------------------
echo Building Windows exe...
echo ----------------------------------------

%csc_path% /optimize+ /t:exe /out:hws2xml.exe Main.cs OpenTK.cs TiltedEngine.cs
7z a win_hws2xml.zip hws2xml.exe > nul
del hws2xml.exe

echo ----------------------------------------
echo Building Mono exe...
echo ----------------------------------------

%mcs_path% -out:hws2xml.exe -r:System -r:System.Drawing -r:System.Xml.Linq Main.cs OpenTK.cs TiltedEngine.cs
7z a mono_hws2xml.zip hws2xml.exe > nul
del hws2xml.exe

echo Done!
