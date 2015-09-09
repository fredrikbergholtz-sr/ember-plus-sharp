﻿////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright>Copyright 2012-2015 Lawo AG (http://www.lawo.com). All rights reserved.</copyright>
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Lawo.EmberPlus.Glow
{
    using Lawo.EmberPlus.Ember;

    /// <summary>Provides a singleton <see cref="EmberTypeBag"/> instance containing all Glow types.</summary>
    /// <remarks>
    /// <para><b>Thread Safety</b>: This type is safe for multithreaded operations.</para>
    /// </remarks>
    public static class GlowTypes
    {
        private static readonly EmberTypeBag TheInstance = new EmberTypeBag(
            typeof(GlowGlobal),
            typeof(GlowParameter),
            new EmberType(typeof(GlowParameter.Contents), typeof(GlowParameterContents)),
            typeof(GlowCommand),
            typeof(GlowNode),
            new EmberType(typeof(GlowNode.Contents), typeof(GlowNodeContents)),
            typeof(GlowElementCollection),
            typeof(GlowStreamEntry),
            typeof(GlowStreamCollection),
            typeof(GlowStringIntegerPair),
            typeof(GlowStringIntegerCollection),
            typeof(GlowQualifiedParameter),
            new EmberType(typeof(GlowQualifiedParameter.Contents), typeof(GlowParameterContents)),
            typeof(GlowQualifiedNode),
            new EmberType(typeof(GlowQualifiedNode.Contents), typeof(GlowNodeContents)),
            typeof(GlowRootElementCollection),
            typeof(GlowStreamDescription),
            typeof(GlowMatrix),
            new EmberType(typeof(GlowMatrix.Contents), typeof(GlowMatrixContents)),
            new EmberType(typeof(GlowMatrix.Contents), typeof(GlowMatrixContents.Labels), typeof(GlowLabelCollection)),
            new EmberType(typeof(GlowMatrix.Targets), typeof(GlowTargetCollection)),
            new EmberType(typeof(GlowMatrix.Sources), typeof(GlowSourceCollection)),
            new EmberType(typeof(GlowMatrix.Connections), typeof(GlowConnectionCollection)),
            typeof(GlowTarget),
            typeof(GlowSource),
            typeof(GlowConnection),
            typeof(GlowQualifiedMatrix),
            new EmberType(typeof(GlowQualifiedMatrix.Contents), typeof(GlowMatrixContents)),
            new EmberType(typeof(GlowQualifiedMatrix.Contents), typeof(GlowMatrixContents.Labels), typeof(GlowLabelCollection)),
            new EmberType(typeof(GlowQualifiedMatrix.Targets), typeof(GlowTargetCollection)),
            new EmberType(typeof(GlowQualifiedMatrix.Sources), typeof(GlowSourceCollection)),
            new EmberType(typeof(GlowQualifiedMatrix.Connections), typeof(GlowConnectionCollection)),
            typeof(GlowLabel),
            typeof(GlowFunction),
            new EmberType(typeof(GlowFunction.Contents), typeof(GlowFunctionContents)),
            new EmberType(typeof(GlowFunction.Contents), typeof(GlowFunctionContents.Arguments), typeof(GlowTupleDescription)),
            new EmberType(typeof(GlowFunction.Contents), typeof(GlowFunctionContents.Result), typeof(GlowTupleDescription)),
            typeof(GlowQualifiedFunction),
            new EmberType(typeof(GlowQualifiedFunction.Contents), typeof(GlowFunctionContents)),
            new EmberType(typeof(GlowQualifiedFunction.Contents), typeof(GlowFunctionContents.Arguments), typeof(GlowTupleDescription)),
            new EmberType(typeof(GlowQualifiedFunction.Contents), typeof(GlowFunctionContents.Result), typeof(GlowTupleDescription)),
            typeof(GlowTupleItemDescription),
            typeof(GlowInvocation),
            new EmberType(typeof(GlowInvocation.Arguments), typeof(GlowTuple)),
            typeof(GlowInvocationResult),
            new EmberType(typeof(GlowInvocationResult.Result), typeof(GlowTuple)));

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>Gets the singleton <see cref="EmberTypeBag"/> instance containing all Glow types.</summary>
        public static EmberTypeBag Instance
        {
            get { return TheInstance; }
        }
    }
}