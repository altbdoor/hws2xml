using System;
using System.IO;

using TiltedEngine;


public class HWSConverter
{
    public static int Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Please enter the input and output path.");
            Console.WriteLine("Example:");
            Console.WriteLine("  HWS to XML: hws2xml.exe input.hws output.xml");
            Console.WriteLine("  XML to HWS: hws2xml.exe input.xml output.hws");
            return 1;
        }
        
        bool IsHWSToXML = true;
        string HWSPath = args[0];
        string XMLPath = args[1];
        
        if (args[0].EndsWith(".xml")) {
            IsHWSToXML = false;
            HWSPath = args[1];
            XMLPath = args[0];
        }
        
        if (IsHWSToXML && !File.Exists(HWSPath))
        {
            Console.WriteLine("Input .hws file does not exist.");
            return 1;
        }
        else if (!IsHWSToXML && !File.Exists(XMLPath))
        {
            Console.WriteLine("Input .xml file does not exist.");
            return 1;
        }
        
        if (IsHWSToXML)
        {
            // https://github.com/joedf/HWSEdit/blob/8c68e80/HWSEdit/MainForm.cs#L184-L188
            BinaryReader BR = new BinaryReader(File.Open(HWSPath, FileMode.Open));
            SValue OBJ = SValue.LoadStream(BR);
            TextWriter TW = new StreamWriter(XMLPath);
            SValue.SaveXML(OBJ, TW);
            TW.Close();
        }
        else {
            // https://github.com/joedf/HWSEdit/blob/8c68e80/HWSEdit/MainForm.cs#L217-L221
            TextReader TR = new StreamReader(XMLPath);
            SValue OBJ = SValue.FromXMLFile(TR);
            BinaryWriter BW = new BinaryWriter(File.Open(HWSPath, FileMode.Create));
            SValue.SaveStream(OBJ, BW);
            BW.Close();
        }
        
        Console.WriteLine("Conversion complete.");
        return 0;
    }
}
