﻿namespace ErrorProne.NET.CoreAnalyzers
{
    /// <summary>
    /// Diagnostic ids produced by analyzers defined in ErrorProne.Net.Core project.
    /// </summary>
    public static class DiagnosticIds
    {
        /// <nodoc />
        public const string SuspiciousEqualsMethodImplementation = "EPC11";

        /// <nodoc />
        public const string SuspiciousExceptionHandling = "EPC12";
        
        /// <nodoc />
        public const string UnobservedResult = "EPC13";
        
        /// <nodoc />
        public const string RedundantConfigureAwait = "EPC14";
        
        /// <nodoc />
        public const string ConfigureAwaitFalseMustBeUsed = "EPC15";
        
        /// <nodoc />
        public const string NullCoalescingOperatorForAsyncMethods = "EPC16";

        // Exception handling
        public const string IncorrectExceptionPropagation = "ERP021";
        public const string AllExceptionSwalled = "ERP022";
        public const string OnlyExceptionMessageWasObserved = "ERP023";
    }
}