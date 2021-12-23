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

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of GalleryImage and their operations over its parent. </summary>
    public partial class GalleryImageCollection : ArmCollection, IEnumerable<GalleryImage>, IAsyncEnumerable<GalleryImage>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly GalleryImagesRestOperations _galleryImagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="GalleryImageCollection"/> class for mocking. </summary>
        protected GalleryImageCollection()
        {
        }

        /// <summary> Initializes a new instance of GalleryImageCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal GalleryImageCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _galleryImagesRestClient = new GalleryImagesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Gallery.ResourceType;

        // Collection level operations.

        /// <summary> Create or update a gallery image definition. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryImage"> Parameters supplied to the create or update gallery image operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> or <paramref name="galleryImage"/> is null. </exception>
        public virtual GalleryImageCreateOrUpdateOperation CreateOrUpdate(string galleryImageName, GalleryImageData galleryImage, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImage == null)
            {
                throw new ArgumentNullException(nameof(galleryImage));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _galleryImagesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage, cancellationToken);
                var operation = new GalleryImageCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _galleryImagesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage).Request, response);
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

        /// <summary> Create or update a gallery image definition. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryImage"> Parameters supplied to the create or update gallery image operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> or <paramref name="galleryImage"/> is null. </exception>
        public async virtual Task<GalleryImageCreateOrUpdateOperation> CreateOrUpdateAsync(string galleryImageName, GalleryImageData galleryImage, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImage == null)
            {
                throw new ArgumentNullException(nameof(galleryImage));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _galleryImagesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage, cancellationToken).ConfigureAwait(false);
                var operation = new GalleryImageCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _galleryImagesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage).Request, response);
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

        /// <summary> Retrieves information about a gallery image definition. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<GalleryImage> Get(string galleryImageName, CancellationToken cancellationToken = default)
        {
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageCollection.Get");
            scope.Start();
            try
            {
                var response = _galleryImagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryImage(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about a gallery image definition. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public async virtual Task<Response<GalleryImage>> GetAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageCollection.Get");
            scope.Start();
            try
            {
                var response = await _galleryImagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new GalleryImage(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<GalleryImage> GetIfExists(string galleryImageName, CancellationToken cancellationToken = default)
        {
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _galleryImagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<GalleryImage>(null, response.GetRawResponse())
                    : Response.FromValue(new GalleryImage(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public async virtual Task<Response<GalleryImage>> GetIfExistsAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _galleryImagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<GalleryImage>(null, response.GetRawResponse())
                    : Response.FromValue(new GalleryImage(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<bool> Exists(string galleryImageName, CancellationToken cancellationToken = default)
        {
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(galleryImageName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(galleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List gallery image definitions in a gallery. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryImage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GalleryImage> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GalleryImage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleryImagesRestClient.ListByGallery(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GalleryImage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleryImagesRestClient.ListByGalleryNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List gallery image definitions in a gallery. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryImage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GalleryImage> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GalleryImage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleryImagesRestClient.ListByGalleryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GalleryImage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleryImagesRestClient.ListByGalleryNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<GalleryImage> IEnumerable<GalleryImage>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GalleryImage> IAsyncEnumerable<GalleryImage>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, GalleryImage, GalleryImageData> Construct() { }
    }
}
