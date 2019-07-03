﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace WorkspaceServer.Kernel
{
    public class PackageAdded : KernelEventBase
    {
        public PackageAdded(IKernelCommand command) : this(command.Id)
        {
        }

        public PackageAdded(Guid parentId) : base(parentId)
        {
        }
    }
}