﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//-----------------------------------------------------------------------
// </copyright>

using Microsoft.Build.BackEnd.SdkResolution;

namespace Microsoft.Build.Evaluation.Context
{
    internal sealed class EvaluationContext : EvaluationContextBase
    {
        public override ISdkResolverService SdkResolverService { get; } = new SdkResolverCachingWrapper(new SdkResolverService());
    }
}
