//-----------------------------------------------------------------------
// <copyright company="Daniel Plaisted">
//     Copyright (c) Daniel Plaisted. All rights reserved.
// </copyright>
// This file is a derivation of:
// https://github.com/dsplaisted/PCLStorage
// Which is released under the MS-PL license.
//-----------------------------------------------------------------------

using System;

namespace PCLExt.FileStorage.Exceptions
{
    /// <exclude/>
    public class DirectoryNotFoundException
#if PORTABLE
        : System.IO.IOException
#elif NETSTANDARD2_0
        : System.IO.FileNotFoundException
#else
        : System.IO.DirectoryNotFoundException
#endif
    {
        /// <exclude/>
        public DirectoryNotFoundException(string message) : base(message) { }

        /// <exclude/>
        public DirectoryNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}