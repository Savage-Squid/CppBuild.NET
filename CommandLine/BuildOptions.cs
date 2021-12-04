using CommandLine;

namespace CppBuild.CommandLine
{
    [Verb("build", HelpText = "Builds the targets.")]
    public class BuildOptions
    {
        [Option('w', "workspace", HelpText = "The custom working directory.")]
        public string? CurrentDirectory { get; set; }

        [Option("logfile", Default = "Log.txt",
            HelpText = "The log file path relative to the working directory. Set to empty to disable it.")]
        public string LogFile { get; set; } = "Log.txt";
        
        [Option("stdout", HelpText = "Enables logging into console.")]
        public bool ConsoleLog { get; set; }
        
        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }
        
        /// <summary>
        /// Enables using guard mutex to prevent running multiple instances of the tool.
        /// </summary>
        [Option("mutex", HelpText = "Enables using guard mutex to prevent running multiple instances of the tool.")]
        public bool Mutex { get; set; }
        
        /// <summary>
        /// The maximum allowed concurrency for a build system (maximum active worker threads count).
        /// </summary>
        [Option("maxConcurrency", Default = 1410, HelpText = "The maximum allowed concurrency for a build system (maximum active worker threads count).")]
        public int MaxConcurrency { get; set; } = 1410;

        /// <summary>
        /// The concurrency scale for a build system that specifies how many worker threads allocate per-logical processor.
        /// </summary>
        [Option("concurrencyProcessorScale", Default = 1.0f, HelpText = "The concurrency scale for a build system that specifies how many worker threads allocate per-logical processor.")]
        public float ConcurrencyProcessorScale { get; set; } = 1.0f;
        
        /// <summary>
        /// The output binaries folder path relative to the working directory.
        /// </summary>
        [Option("binaries", Default = "Binaries", HelpText = "The output binaries folder path relative to the working directory.")]
        public string BinariesFolder  { get; set; } = "Binaries";

        /// <summary>
        /// The intermediate build files folder path relative to the working directory.
        /// </summary>
        [Option("intermediate", Default = "Cache/Intermediate", HelpText = "The intermediate build files folder path relative to the working directory.")]
        public string IntermediateFolder { get; set; } = "Cache/Intermediate";
    }
}