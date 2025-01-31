// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>An update to a workspace.</summary>
    public partial class WorkspaceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspaceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspaceUpdateInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspaceUpdateTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspaceUpdateTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.WorkspaceUpdateTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="WorkspaceUpdate" /> instance.</summary>
        public WorkspaceUpdate()
        {

        }
    }
    /// An update to a workspace.
    public partial interface IWorkspaceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable
    {
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspaceUpdateTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspaceUpdateTags Tag { get; set; }

    }
    /// An update to a workspace.
    internal partial interface IWorkspaceUpdateInternal

    {
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspaceUpdateTags Tag { get; set; }

    }
}