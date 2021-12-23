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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerCommunicationLink and their operations over its parent. </summary>
    public partial class ServerCommunicationLinkCollection : ArmCollection, IEnumerable<ServerCommunicationLink>, IAsyncEnumerable<ServerCommunicationLink>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ServerCommunicationLinksRestOperations _serverCommunicationLinksRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerCommunicationLinkCollection"/> class for mocking. </summary>
        protected ServerCommunicationLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of ServerCommunicationLinkCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerCommunicationLinkCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _serverCommunicationLinksRestClient = new ServerCommunicationLinksRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SqlServer.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerCommunicationLinks_CreateOrUpdate
        /// <summary> Creates a server communication link. </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="parameters"> The required parameters for creating a server communication link. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ServerCommunicationLinkCreateOrUpdateOperation CreateOrUpdate(string communicationLinkName, ServerCommunicationLinkData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (communicationLinkName == null)
            {
                throw new ArgumentNullException(nameof(communicationLinkName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverCommunicationLinksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, parameters, cancellationToken);
                var operation = new ServerCommunicationLinkCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _serverCommunicationLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerCommunicationLinks_CreateOrUpdate
        /// <summary> Creates a server communication link. </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="parameters"> The required parameters for creating a server communication link. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ServerCommunicationLinkCreateOrUpdateOperation> CreateOrUpdateAsync(string communicationLinkName, ServerCommunicationLinkData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (communicationLinkName == null)
            {
                throw new ArgumentNullException(nameof(communicationLinkName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverCommunicationLinksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ServerCommunicationLinkCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _serverCommunicationLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerCommunicationLinks_Get
        /// <summary> Returns a server communication link. </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual Response<ServerCommunicationLink> Get(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            if (communicationLinkName == null)
            {
                throw new ArgumentNullException(nameof(communicationLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _serverCommunicationLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerCommunicationLink(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerCommunicationLinks_Get
        /// <summary> Returns a server communication link. </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public async virtual Task<Response<ServerCommunicationLink>> GetAsync(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            if (communicationLinkName == null)
            {
                throw new ArgumentNullException(nameof(communicationLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverCommunicationLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerCommunicationLink(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual Response<ServerCommunicationLink> GetIfExists(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            if (communicationLinkName == null)
            {
                throw new ArgumentNullException(nameof(communicationLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverCommunicationLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ServerCommunicationLink>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerCommunicationLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public async virtual Task<Response<ServerCommunicationLink>> GetIfExistsAsync(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            if (communicationLinkName == null)
            {
                throw new ArgumentNullException(nameof(communicationLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinkCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _serverCommunicationLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ServerCommunicationLink>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerCommunicationLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual Response<bool> Exists(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            if (communicationLinkName == null)
            {
                throw new ArgumentNullException(nameof(communicationLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(communicationLinkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            if (communicationLinkName == null)
            {
                throw new ArgumentNullException(nameof(communicationLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinkCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(communicationLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerCommunicationLinks_ListByServer
        /// <summary> Gets a list of server communication links. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerCommunicationLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerCommunicationLink> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerCommunicationLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverCommunicationLinksRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerCommunicationLink(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerCommunicationLinks_ListByServer
        /// <summary> Gets a list of server communication links. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerCommunicationLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerCommunicationLink> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerCommunicationLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerCommunicationLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverCommunicationLinksRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerCommunicationLink(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<ServerCommunicationLink> IEnumerable<ServerCommunicationLink>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerCommunicationLink> IAsyncEnumerable<ServerCommunicationLink>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ServerCommunicationLink, ServerCommunicationLinkData> Construct() { }
    }
}
