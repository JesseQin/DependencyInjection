// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Framework.DependencyInjection.Tests.Fakes
{
    public class SelfCircularDependencyGeneric<TDependency>
    {
        public SelfCircularDependencyGeneric(SelfCircularDependencyGeneric<string> dependency)
        {

        }

        public SelfCircularDependencyGeneric()
        {

        }
    }
}