﻿using System;

namespace Microsoft.Azure.Jobs
{
    // Bunder of interfaces needed for execution. Grouped together for convenience. 
    internal class ExecuteFunctionInterfaces
    {
        public IAccountInfo AccountInfo;
        public IFunctionInstanceLookup Lookup;
        public IFunctionUpdatedLogger Logger;

        public void VerifyNotNull()
        {
            if (Logger == null)
            {
                throw new InvalidOperationException("Logger cannot be null.");
            }
            if (Lookup == null)
            {
                throw new InvalidOperationException("Lookup cannot be null.");
            }
            if (AccountInfo == null)
            {
                throw new InvalidOperationException("AccountInfo cannot be null.");
            }
        }
    }
}