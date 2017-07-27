hws2xml
===

A simple console application which converts [Hammerwatch](http://store.steampowered.com/app/239070) game saves (HWS) into XML files, and vice versa.

This project only brings together codes which are relevant in converting HWS into XML files.

- Check out the more complete project on [HWSEdit](https://github.com/joedf/HWSEdit)
- Core conversion code (`TiltedEngine.cs`) from [Myran](http://hammerwatch.com/forum/index.php?topic=2197.msg5313#msg5313)
- OpenTK shim (`OpenTK.cs`) by [joedf](http://hammerwatch.com/forum/index.php?topic=2197.msg5318#msg5318)


### Usage

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


### Build

Details can be found in `build.bat`. Windows build is built with .NET 4.5 `csc.exe`, while Mono build is built with Mono 4.


### Download

Downloads can be found at [AppVeyor](https://ci.appveyor.com/project/altbdoor/hws2xml/build/artifacts).

- `win_hws2xml.zip` for Windows
- `mono_hws2xml.zip` for Mono


### FAQ

1. **Is this converter safe?** <br>
    The core conversion code is directly from Myran, one of the developers of the game. So, it should be safe!
    
    I myself have tested it with a couple of my game saves. I was able to <strike>cheat</strike> obtain all the Strange Planks I missed.

1. **What do I do with the XML now?** <br>
    Feel free to boot up your favorite text editor and start editing the XML. When you are done, use `hws2xml.exe` to convert it back to HWS.

1. **But I don't know how to wade through all this """code"""** <br>
    I have created a small editor of sorts. Its done with largely HTML and JS, and can be found in the repository as `xml_editor.html`. Download the file, and open it on your browser with double click or whatnot.
    
    Do not count on it being able to edit every single parameter of the game though. Its hacky at best. The editor is only tested in Mozilla Firefox and Google Chrome, as it uses some pretty advanced features. Its a self containing file, which means it does not require any other software in order to work.

1. **Is this editor safe?** <br>
    If you mean for your game saves, I would strongly recommend that you keep a backup copy of the original HWS file before doing anything. But as mentioned, I have tested it with my game saves.
    
    If you mean for your browser, I can assure you that it is safe. It does not make any external calls through the internet. The only risk is that it might slow down your browser if the XML file is too large.

1. **So I have to convert my game save, load it in the editor, make changes and re-convert it?** <br>
    Yes.

1. **Why?! That is so much work!** <br>
    The core conversion code is done in C#, in which I have not touched in years. I only have a faint recollection of things, good enough to make the converter in command line, but not enough to make a full blown GUI.
    
    This is also the reason why I did not contribute directly to the original code in HWSEdit. But hey, HWSEdit *is* open source...

1. **This is unfair! You are cheating!** <br>
    Its a choice we all can take. As mentioned by my friend who kept pestering me while working on this project.
    
    `PLAY THE GAME, THE WAY ITS MEANT TO BE PLAYED.`


### More Why

- Hosted a multiplayer game with friends
- Fell sick, could not host
- Wanted to change host to another friend
- Found HWSEdit, but the players tab was not working
- Converted to XML with HWSEdit and changed the host
- Feel adventurous to help HWSEdit, but no C# knowledge
- Do not know how to decode original conversion logic from Myran
- Kept the conversion in C#
- Plan to remake the editing in another language
- And did it in HTML/JavaScript
