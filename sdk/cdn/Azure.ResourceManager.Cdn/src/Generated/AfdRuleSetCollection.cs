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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of AfdRuleSet and their operations over its parent. </summary>
    public partial class AfdRuleSetCollection : ArmCollection, IEnumerable<AfdRuleSet>, IAsyncEnumerable<AfdRuleSet>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AfdRuleSetsRestOperations _afdRuleSetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AfdRuleSetCollection"/> class for mocking. </summary>
        protected AfdRuleSetCollection()
        {
        }

        /// <summary> Initializes a new instance of AfdRuleSetCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AfdRuleSetCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _afdRuleSetsRestClient = new AfdRuleSetsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Profile.ResourceType;

        // Collection level operations.

        /// <summary> Creates a new rule set within the specified profile. </summary>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual AfdRuleSetCreateOperation CreateOrUpdate(string ruleSetName, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRuleSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _afdRuleSetsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken);
                var operation = new AfdRuleSetCreateOperation(Parent, _clientDiagnostics, Pipeline, _afdRuleSetsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName).Request, response);
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

        /// <summary> Creates a new rule set within the specified profile. </summary>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public async virtual Task<AfdRuleSetCreateOperation> CreateOrUpdateAsync(string ruleSetName, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRuleSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _afdRuleSetsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken).ConfigureAwait(false);
                var operation = new AfdRuleSetCreateOperation(Parent, _clientDiagnostics, Pipeline, _afdRuleSetsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName).Request, response);
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

        /// <summary> Gets an existing AzureFrontDoor rule set with the specified rule set name under the specified subscription, resource group and profile. </summary>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual Response<AfdRuleSet> Get(string ruleSetName, CancellationToken cancellationToken = default)
        {
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRuleSetCollection.Get");
            scope.Start();
            try
            {
                var response = _afdRuleSetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdRuleSet(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing AzureFrontDoor rule set with the specified rule set name under the specified subscription, resource group and profile. </summary>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public async virtual Task<Response<AfdRuleSet>> GetAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRuleSetCollection.Get");
            scope.Start();
            try
            {
                var response = await _afdRuleSetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AfdRuleSet(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual Response<AfdRuleSet> GetIfExists(string ruleSetName, CancellationToken cancellationToken = default)
        {
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRuleSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _afdRuleSetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<AfdRuleSet>(null, response.GetRawResponse())
                    : Response.FromValue(new AfdRuleSet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public async virtual Task<Response<AfdRuleSet>> GetIfExistsAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRuleSetCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _afdRuleSetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<AfdRuleSet>(null, response.GetRawResponse())
                    : Response.FromValue(new AfdRuleSet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleSetName, CancellationToken cancellationToken = default)
        {
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRuleSetCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(ruleSetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleSetName"> Name of the rule set under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRuleSetCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ruleSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists existing AzureFrontDoor rule sets within a profile. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AfdRuleSet" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AfdRuleSet> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AfdRuleSet> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdRuleSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdRuleSetsRestClient.ListByProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdRuleSet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AfdRuleSet> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdRuleSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdRuleSetsRestClient.ListByProfileNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdRuleSet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists existing AzureFrontDoor rule sets within a profile. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AfdRuleSet" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AfdRuleSet> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AfdRuleSet>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdRuleSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdRuleSetsRestClient.ListByProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdRuleSet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AfdRuleSet>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdRuleSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdRuleSetsRestClient.ListByProfileNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdRuleSet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<AfdRuleSet> IEnumerable<AfdRuleSet>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AfdRuleSet> IAsyncEnumerable<AfdRuleSet>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, AfdRuleSet, AfdRuleSetData> Construct() { }
    }
}
