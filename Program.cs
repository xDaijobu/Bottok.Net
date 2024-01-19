// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

string command = "write your command here";
string result = "";
using (System.Diagnostics.Process proc = new System.Diagnostics.Process())
{
    proc.StartInfo.FileName = "/bin/bash";
    proc.StartInfo.Arguments = "-c \" " + command + " \"";
    proc.StartInfo.UseShellExecute = false;
    proc.StartInfo.RedirectStandardOutput = true;
    proc.StartInfo.RedirectStandardError = true;
    proc.Start();

    result += proc.StandardOutput.ReadToEnd();
    result += proc.StandardError.ReadToEnd();

    proc.WaitForExit();
}

Console.WriteLine(result);
Console.WriteLine("Hello, World!");
