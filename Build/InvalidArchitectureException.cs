using System;

namespace CppBuild.Build
{
    /// <summary>
    /// The unsupported architecture exception for code paths that require other architecture.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class InvalidArchitectureException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidArchitectureException"/> class.
        /// </summary>
        /// <param name="architecture">The architecture.</param>
        public InvalidArchitectureException(TargetArchitecture architecture)
            : base($"Unknown architecture {architecture}.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidArchitectureException"/> class.
        /// </summary>
        /// <param name="architecture">The architecture.</param>
        /// <param name="message">The additional message.</param>
        public InvalidArchitectureException(TargetArchitecture architecture, string message)
            : base($"Unknown architecture {architecture}. {message}")
        {
        }
    }
}