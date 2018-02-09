// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeviceProvisioningServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// the service specific properties of a provisoning service, including
    /// keys, linked iot hubs, current state, and system generated properties
    /// such as hostname and idScope
    /// </summary>
    public partial class IotDpsPropertiesDescription
    {
        /// <summary>
        /// Initializes a new instance of the IotDpsPropertiesDescription
        /// class.
        /// </summary>
        public IotDpsPropertiesDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotDpsPropertiesDescription
        /// class.
        /// </summary>
        /// <param name="state">Current state of the provisioning service.
        /// Possible values include: 'Activating', 'Active', 'Deleting',
        /// 'Deleted', 'ActivationFailed', 'DeletionFailed', 'Transitioning',
        /// 'Suspending', 'Suspended', 'Resuming', 'FailingOver',
        /// 'FailoverFailed'</param>
        /// <param name="provisioningState">The ARM provisioning state of the
        /// provisioning service.</param>
        /// <param name="iotHubs">List of IoT hubs assosciated with this
        /// provisioning service.</param>
        /// <param name="allocationPolicy">Allocation policy to be used by this
        /// provisioning service. Possible values include: 'Hashed',
        /// 'GeoLatency', 'Static'</param>
        /// <param name="serviceOperationsHostName">Service endpoint for
        /// provisioning service.</param>
        /// <param name="deviceProvisioningHostName">Device endpoint for this
        /// provisioning service.</param>
        /// <param name="idScope">Unique identifier of this provisioning
        /// service.</param>
        /// <param name="authorizationPolicies">List of authorization keys for
        /// a provisioning service.</param>
        public IotDpsPropertiesDescription(string state = default(string), string provisioningState = default(string), IList<IotHubDefinitionDescription> iotHubs = default(IList<IotHubDefinitionDescription>), string allocationPolicy = default(string), string serviceOperationsHostName = default(string), string deviceProvisioningHostName = default(string), string idScope = default(string), IList<SharedAccessSignatureAuthorizationRuleAccessRightsDescription> authorizationPolicies = default(IList<SharedAccessSignatureAuthorizationRuleAccessRightsDescription>))
        {
            State = state;
            ProvisioningState = provisioningState;
            IotHubs = iotHubs;
            AllocationPolicy = allocationPolicy;
            ServiceOperationsHostName = serviceOperationsHostName;
            DeviceProvisioningHostName = deviceProvisioningHostName;
            IdScope = idScope;
            AuthorizationPolicies = authorizationPolicies;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets current state of the provisioning service. Possible
        /// values include: 'Activating', 'Active', 'Deleting', 'Deleted',
        /// 'ActivationFailed', 'DeletionFailed', 'Transitioning',
        /// 'Suspending', 'Suspended', 'Resuming', 'FailingOver',
        /// 'FailoverFailed'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the ARM provisioning state of the provisioning
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets list of IoT hubs assosciated with this provisioning
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "iotHubs")]
        public IList<IotHubDefinitionDescription> IotHubs { get; set; }

        /// <summary>
        /// Gets or sets allocation policy to be used by this provisioning
        /// service. Possible values include: 'Hashed', 'GeoLatency', 'Static'
        /// </summary>
        [JsonProperty(PropertyName = "allocationPolicy")]
        public string AllocationPolicy { get; set; }

        /// <summary>
        /// Gets service endpoint for provisioning service.
        /// </summary>
        [JsonProperty(PropertyName = "serviceOperationsHostName")]
        public string ServiceOperationsHostName { get; private set; }

        /// <summary>
        /// Gets device endpoint for this provisioning service.
        /// </summary>
        [JsonProperty(PropertyName = "deviceProvisioningHostName")]
        public string DeviceProvisioningHostName { get; private set; }

        /// <summary>
        /// Gets unique identifier of this provisioning service.
        /// </summary>
        [JsonProperty(PropertyName = "idScope")]
        public string IdScope { get; private set; }

        /// <summary>
        /// Gets or sets list of authorization keys for a provisioning service.
        /// </summary>
        [JsonProperty(PropertyName = "authorizationPolicies")]
        public IList<SharedAccessSignatureAuthorizationRuleAccessRightsDescription> AuthorizationPolicies { get; set; }

    }
}
