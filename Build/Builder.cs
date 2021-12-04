using System;

namespace CppBuild.Build
{
    public class Builder
    {
        private static Type[] _buildTypes;

        /// <summary>
        /// The build configuration files postfix.
        /// </summary>
        public static string BuildFilesPostfix = ".Build.cs";

        /// <summary>
        /// The cached list of types from CppBuild assembly. Reused by other build tool utilities to improve performance.
        /// </summary>
        internal static Type[] BuildTypes
        {
            get
            {
                if (_buildTypes == null)
                {
                    using (new ProfileEventScope("CacheBuildTypes"))
                    {
                        _buildTypes = typeof(Program).Assembly.GetTypes();
                    }
                }
                return _buildTypes;
            }
        }
    }
}