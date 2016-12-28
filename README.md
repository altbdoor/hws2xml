hws2xml
===

A simple console application which converts [Hammerwatch](http://store.steampowered.com/app/239070) game saves (HWS) into XML files, and vice versa.

This project only brings together codes which are relevant in converting HWS into XML files.

- Check out the more complete project on [HWSEdit](https://github.com/joedf/HWSEdit)
- Core conversion code (`TiltedEngine.cs`) from [Myran](http://hammerwatch.com/forum/index.php?topic=2197.msg5313#msg5313)
- OpenTK shim (`OpenTK.cs`) by [joedf](http://hammerwatch.com/forum/index.php?topic=2197.msg5318#msg5318)


#### Usage

On Windows, you will need at least [.NET 4.5 Framework](https://www.microsoft.com/en-us/download/details.aspx?id=30653) or above. Or, you could use [Mono](http://www.mono-project.com/) too.

On Unix, you will need to use [Mono](http://www.mono-project.com/) to run the compiled executable.

If you are using Mono, do remember to execute it with `mono hws2xml.exe`.

```cmd
C:\>hws2xml.exe
Please enter the input and output path.
Example:
  HWS to XML: hws2xml.exe input.hws output.xml
  XML to HWS: hws2xml.exe input.xml output.hws

C:\>hws2xml.exe test.hws test.xml
Conversion complete.

C:\>hws2xml.exe test.xml test.hws
Conversion complete.
```


#### Download

Downloads can be found at [AppVeyor](https://ci.appveyor.com/project/altbdoor/hws2xml/build/artifacts).

- `win_hws2xml.zip` for Windows
- `mono_hws2xml.zip` for Mono


#### Why

- Hosted a multiplayer game with friends
- Fell sick, could not host
- Wanted to change host to another friend
- Found HWSEdit, but the players tab was not working
- Converted to XML with HWSEdit and changed the host
- Feel adventurous to help HWSEdit, but no C# knowledge
- Do not know how to decode original conversion logic from Myran
- Kept the conversion in C#
- Plan to remake the editing in another language
