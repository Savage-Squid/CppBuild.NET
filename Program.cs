using System;
using System.Net;
using CommandLine;
using CppBuild.CommandLine;

namespace CppBuild
{
    internal static class Program
    {
        private static int Main(string[] args)
        {
            
            return Parser.Default.ParseArguments<BuildOptions, object>(args)
                .MapResult(
                    (BuildOptions o) => RunBuild(o),
                    errs => 1
                );
        }

        private static int RunBuild(BuildOptions options)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            
            Log.Init(options.LogFile, options.ConsoleLog, options.Verbose);
            
            
            
            return 0;
        }
    }
}
