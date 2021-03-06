// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable enable
namespace System.Xml.Xsl.XsltOld
{
    internal abstract class Action
    {
        internal const int Initialized = 0;
        internal const int Finished = -1;

        internal abstract void Execute(Processor processor, ActionFrame frame);

        internal virtual void ReplaceNamespaceAlias(Compiler compiler) { }
    }
}
