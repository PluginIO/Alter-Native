﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ICSharpCode.NRefactory.Cpp.Formatters;

namespace ICSharpCode.NRefactory.Cpp
{
    public class MainWritter
    {
        public static void GenerateMain(string entryType)
        {
            StreamWriter writer = new StreamWriter(FileWritterManager.WorkingPath + "main.cpp");

            writer.WriteLine("#include \"Program.h\"");
            writer.WriteLine("using namespace System;");
            writer.WriteLine("using namespace List;");
            writer.WriteLine();
            writer.WriteLine("int main(int argc, char *argv[])");
            writer.WriteLine("{");
            writer.WriteLine("\tString *args = new String[argc];");
            writer.WriteLine("\tfor(int i = 0; i < argc; i++)");
            writer.WriteLine("\t\targs[i] = argv[i];");
            writer.WriteLine();
            writer.WriteLine("\t" + entryType + "::Main(args);");
            writer.WriteLine("\t//TODO");
            writer.WriteLine("\t//delete args;");
            writer.WriteLine("}");

            writer.Flush();
            writer.Close();

            FileWritterManager.AddSourceFile("main.cpp");
        }
    }
}