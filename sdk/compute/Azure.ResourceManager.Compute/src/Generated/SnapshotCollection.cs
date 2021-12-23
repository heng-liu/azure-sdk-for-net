// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of Snapshot and their operations over its parent. </summary>
    public partial class SnapshotCollection : ArmCollection, IEnumerable<Snapshot>, IAsyncEnumerable<Snapshot>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SnapshotsRestOperations _snapshotsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SnapshotCollection"/> class for mocking. </summary>
        protected SnapshotCollection()
        {
        }

        /// <summary> Initializes a new instance of SnapshotCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SnapshotCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _snapshotsRestClient = new SnapshotsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a snapshot. </summary>
        /// <param name="snapshotName"> The name of the snapshot that is being created. The name can&apos;t be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The max name length is 80 characters. </param>
        /// <param name="snapshot"> Snapshot object supplied in the body of the Put disk operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> or <paramref name="snapshot"/> is null. </exception>
        public virtual SnapshotCreateOrUpdateOperation CreateOrUpdate(string snapshotName, SnapshotData snapshot, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (snapshotName == null)
            {
                throw new ArgumentNullException(nameof(snapshotName));
            }
            if (snapshot == null)
            {
                throw new ArgumentNullException(nameof(snapshot));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _snapshotsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, snapshotName, snapshot, cancellationToken);
                var operation = new SnapshotCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _snapshotsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, snapshotName, snapshot).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a snapshot. </summary>
        /// <param name="snapshotName"> The name of the snapshot that is being created. The name can&apos;t be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The max name length is 80 characters. </param>
        /// <param name="snapshot"> Snapshot object supplied in the body of the Put disk operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> or <paramref name="snapshot"/> is null. </exception>
        public async virtual Task<SnapshotCreateOrUpdateOperation> CreateOrUpdateAsync(string snapshotName, SnapshotData snapshot, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (snapshotName == null)
            {
                throw new ArgumentNullException(nameof(snapshotName));
            }
            if (snapshot == null)
            {
                throw new ArgumentNullException(nameof(snapshot));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _snapshotsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, snapshotName, snapshot, cancellationToken).ConfigureAwait(false);
                var operation = new SnapshotCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _snapshotsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, snapshotName, snapshot).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about a snapshot. </summary>
        /// <param name="snapshotName"> The name of the snapshot that is being created. The name can&apos;t be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The max name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual Response<Snapshot> Get(string snapshotName, CancellationToken cancellationToken = default)
        {
            if (snapshotName == null)
            {
                throw new ArgumentNullException(nameof(snapshotName));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotCollection.Get");
            scope.Start();
            try
            {
                var response = _snapshotsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, snapshotName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Snapshot(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about a snapshot. </summary>
        /// <param name="snapshotName"> The name of the snapshot that is being created. The name can&apos;t be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The max name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public async virtual Task<Response<Snapshot>> GetAsync(string snapshotName, CancellationToken cancellationToken = default)
        {
            if (snapshotName == null)
            {
                throw new ArgumentNullException(nameof(snapshotName));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotCollection.Get");
            scope.Start();
            try
            {
                var response = await _snapshotsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, snapshotName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Snapshot(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="snapshotName"> The name of the snapshot that is being created. The name can&apos;t be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The max name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual Response<Snapshot> GetIfExists(string snapshotName, CancellationToken cancellationToken = default)
        {
            if (snapshotName == null)
            {
                throw new ArgumentNullException(nameof(snapshotName));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _snapshotsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, snapshotName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Snapshot>(null, response.GetRawResponse())
                    : Response.FromValue(new Snapshot(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="snapshotName"> The name of the snapshot that is being created. The name can&apos;t be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The max name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public async virtual Task<Response<Snapshot>> GetIfExistsAsync(string snapshotName, CancellationToken cancellationToken = default)
        {
            if (snapshotName == null)
            {
                throw new ArgumentNullException(nameof(snapshotName));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _snapshotsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, snapshotName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Snapshot>(null, response.GetRawResponse())
                    : Response.FromValue(new Snapshot(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="snapshotName"> The name of the snapshot that is being created. The name can&apos;t be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The max name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual Response<bool> Exists(string snapshotName, CancellationToken cancellationToken = default)
        {
            if (snapshotName == null)
            {
                throw new ArgumentNullException(nameof(snapshotName));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(snapshotName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="snapshotName"> The name of the snapshot that is being created. The name can&apos;t be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The max name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string snapshotName, CancellationToken cancellationToken = default)
        {
            if (snapshotName == null)
            {
                throw new ArgumentNullException(nameof(snapshotName));
            }

            using var scope = _clientDiagnostics.CreateScope("SnapshotCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(snapshotName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists snapshots under a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Snapshot" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Snapshot> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Snapshot> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SnapshotCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _snapshotsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Snapshot(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Snapshot> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SnapshotCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _snapshotsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Snapshot(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists snapshots under a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Snapshot" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Snapshot> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Snapshot>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SnapshotCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _snapshotsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Snapshot(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Snapshot>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SnapshotCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _snapshotsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Snapshot(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="Snapshot" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SnapshotCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Snapshot.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Snapshot" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SnapshotCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Snapshot.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Snapshot> IEnumerable<Snapshot>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Snapshot> IAsyncEnumerable<Snapshot>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, Snapshot, SnapshotData> Construct() { }
    }
}
