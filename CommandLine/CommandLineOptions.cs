using CommandLine;

namespace CppBuild.CommandLine
{
    public class CommandLineOptions
    {
        [Option('w', "workspace", ResourceType = typeof(string), HelpText = "The custom working directory.")]
        public string? CurrentDirectory { get; set; }

        [Option('b', "build", HelpText = "Builds the targets.")]
        public bool Build { get; set; }
        
        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }
    }
}