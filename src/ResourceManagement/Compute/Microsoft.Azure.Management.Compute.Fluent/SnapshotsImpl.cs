﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Compute.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using ResourceManager.Fluent.Core;
    using Models;
    using Snapshot.Definition;

    /// <summary>
    /// The implementation for Snapshots.
    /// </summary>
    ///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LmNvbXB1dGUuaW1wbGVtZW50YXRpb24uU25hcHNob3RzSW1wbA==
    internal partial class SnapshotsImpl :
        GroupableResources<ISnapshot,
            SnapshotImpl,
            SnapshotInner, 
            ISnapshotsOperations, 
            IComputeManager>,
        ISnapshots
    {
        ///GENMHASH:0A26D543418307E510FEAF101AB92A20:872A681ED7AE386A7C237A1C77E3E12A
        internal SnapshotsImpl(ComputeManager computeManager) : base(computeManager.Inner.Snapshots, computeManager)
        {
        }

        ///GENMHASH:0679DF8CA692D1AC80FC21655835E678:737180B1BC9FBD3E5083EE06E951D489
        public async override Task DeleteByGroupAsync(string groupName, string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Inner.DeleteAsync(groupName, name, cancellationToken);
        }

        ///GENMHASH:1BCE81BDD651175D2AF64E39F4F2C420:BFFE56CE1D59C3CA9284FED6EC0BD4DE
        public void RevokeAccess(string resourceGroupName, string diskName)
        {
            Inner.RevokeAccess(resourceGroupName, diskName);
        }

        ///GENMHASH:C2E2A5650639245BC0993A33DCAA5D61:7697FA7DB7AB14465F345F0D9BFABB88
        public string GrantAccess(string resourceGroupName, string snapshotName, AccessLevel accessLevel, int accessDuration)
        {
            GrantAccessDataInner grantAccessDataInner = new GrantAccessDataInner();
            grantAccessDataInner.Access = accessLevel;
            grantAccessDataInner.DurationInSeconds = accessDuration;
            AccessUriInner accessUriInner = Inner.GrantAccess(resourceGroupName,
                snapshotName,
                grantAccessDataInner);
            return accessUriInner.AccessSAS;
        }

        ///GENMHASH:8ACFB0E23F5F24AD384313679B65F404:664BEF11BF4AA10D27449EE89EF181F3
        public IBlank Define(string name)
        {
            return this.WrapModel(name);
        }

        ///GENMHASH:AB63F782DA5B8D22523A284DAD664D17:B8C153DB909F1EA16660F69BB881AD7A
        public async override Task<ISnapshot> GetByGroupAsync(string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            SnapshotInner inner = await Inner.GetAsync(resourceGroupName, name, cancellationToken);
            return WrapModel(inner);
        }

        ///GENMHASH:7D6013E8B95E991005ED921F493EFCE4:6FB4EA69673E1D8A74E1418EB52BB9FE
        public PagedList<Microsoft.Azure.Management.Compute.Fluent.ISnapshot> List()
        {
            var pagedList = new PagedList<SnapshotInner>(Inner.List(), (string nextPageLink) =>
            {
                return Inner.ListNext(nextPageLink);
            });
            return WrapList(pagedList);
        }

        ///GENMHASH:95834C6C7DA388E666B705A62A7D02BF:F27988875BD81EE531DA23D26C675612
        public PagedList<ISnapshot> ListByGroup(string resourceGroupName)
        {
            var pagedList = new PagedList<SnapshotInner>(Inner.ListByResourceGroup(resourceGroupName), (string nextPageLink) =>
            {
                return Inner.ListByResourceGroupNext(nextPageLink);
            });
            return WrapList(pagedList);
        }

        ///GENMHASH:2FE8C4C2D5EAD7E37787838DE0B47D92:3CA46DBF2D9D3E2609846FB4E368F357
        protected override SnapshotImpl WrapModel(string name)
        {
            return new SnapshotImpl(name, new SnapshotInner(), Manager);
        }

        ///GENMHASH:A33FD2C567E662AFDC5CB2FD277C2CF2:9B2DEA0DAB4AA3978BD346D58F2C8619
        protected override ISnapshot WrapModel(SnapshotInner inner)
        {
            return new SnapshotImpl(inner.Name, inner, Manager);
        }
    }
}