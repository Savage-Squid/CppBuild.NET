namespace CppBuild.Build
{
    /// <summary>
    /// The target platform types.
    /// </summary>
    public enum TargetPlatform
    {
        /// <summary>
        /// Running on Windows.
        /// </summary>
        Windows,
        
        /// <summary>
        /// Running on OSX.
        /// </summary>
        OSX,
        
        /// <summary>
        /// Running on Linux.
        /// </summary>
        Linux,

        /// <summary>
        /// Running on Xbox One.
        /// </summary>
        XboxOne,

        /// <summary>
        /// Running Windows Store App (Universal Windows Platform).
        /// </summary>
        UWP,

        /// <summary>
        /// Running on PlayStation 4.
        /// </summary>
        PS4,

        /// <summary>
        /// Running on Xbox Series X.
        /// </summary>
        XboxScarlett,

        /// <summary>
        /// Running on Android.
        /// </summary>
        Android,
        
        /// <summary>
        /// Running on IOS.
        /// </summary>
        IOS,

        /// <summary>
        /// Running on Switch.
        /// </summary>
        Switch,

        /// <summary>
        /// Running on PlayStation 5.
        /// </summary>
        PS5,
    }

    /// <summary>
    /// The target platform architecture types.
    /// </summary>
    public enum TargetArchitecture
    {
        /// <summary>
        /// Anything or not important.
        /// </summary>
        AnyCPU = 0,

        /// <summary>
        /// The x86 32-bit.
        /// </summary>
        x86 = 1,

        /// <summary>
        /// The x86 64-bit.
        /// </summary>
        x64 = 2,

        /// <summary>
        /// The ARM 32-bit.
        /// </summary>
        ARM = 3,

        /// <summary>
        /// The ARM 64-bit.
        /// </summary>
        ARM64 = 4,
    }

    /// <summary>
    /// The target configuration modes.
    /// </summary>
    public enum TargetConfiguration
    {
        /// <summary>
        /// Debug configuration. Without optimizations but with full debugging information.
        /// </summary>
        Debug = 0,

        /// <summary>
        /// Development configuration. With basic optimizations and partial debugging data.
        /// </summary>
        Development = 1,

        /// <summary>
        /// Shipping configuration. With full optimization and no debugging data.
        /// </summary>
        Release = 2,
    }
}