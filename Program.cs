using System;
using System.Globalization;
using System.Net;
using System.Threading;
using CommandLine;
using CppBuild.CommandLine;

namespace CppBuild
{
    internal static class Program
    {
        private static int Main(string[] args)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var culture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            
            return Parser.Default.ParseArguments<BuildOptions, object>(args)
                .MapResult(
                    (BuildOptions o) => RunBuild(o),
                    errs => 1
                );
        }

        private static int RunBuild(BuildOptions options)
        {
            Log.Init(options.LogFile, options.ConsoleLog, options.Verbose);
            
            var failed = false;

            // set the current directory
            if (!string.IsNullOrEmpty(options.CurrentDirectory))
            {
                Environment.CurrentDirectory = options.CurrentDirectory;
            }
            
            // Log basic info
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            string versionString = string.Join(".", version?.Major, version?.Minor, version?.Build);
            Log.Info($"CppBuild {versionString}");
            using (new LogIndentScope())
            {
                Log.Verbose("Arguments: " + options);
                Log.Verbose("Workspace: " + options.CurrentDirectory);
            }
            
            
            
            
            return 0;
        }
    }
}
