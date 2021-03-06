// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Azure;
    using Management;
    using CustomerInsights;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The fields mapping for Relationships.
    /// </summary>
    public partial class RelationshipLinkFieldMapping
    {
        /// <summary>
        /// Initializes a new instance of the RelationshipLinkFieldMapping
        /// class.
        /// </summary>
        public RelationshipLinkFieldMapping() { }

        /// <summary>
        /// Initializes a new instance of the RelationshipLinkFieldMapping
        /// class.
        /// </summary>
        /// <param name="interactionFieldName">The field name on the
        /// Interaction Type.</param>
        /// <param name="relationshipFieldName">The field name on the
        /// Relationship metadata.</param>
        /// <param name="linkType">Link type. Possible values include:
        /// 'UpdateAlways', 'CopyIfNull'</param>
        public RelationshipLinkFieldMapping(string interactionFieldName, string relationshipFieldName, LinkTypes? linkType = default(LinkTypes?))
        {
            InteractionFieldName = interactionFieldName;
            LinkType = linkType;
            RelationshipFieldName = relationshipFieldName;
        }

        /// <summary>
        /// Gets or sets the field name on the Interaction Type.
        /// </summary>
        [JsonProperty(PropertyName = "interactionFieldName")]
        public string InteractionFieldName { get; set; }

        /// <summary>
        /// Gets or sets link type. Possible values include: 'UpdateAlways',
        /// 'CopyIfNull'
        /// </summary>
        [JsonProperty(PropertyName = "linkType")]
        public LinkTypes? LinkType { get; set; }

        /// <summary>
        /// Gets or sets the field name on the Relationship metadata.
        /// </summary>
        [JsonProperty(PropertyName = "relationshipFieldName")]
        public string RelationshipFieldName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (InteractionFieldName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InteractionFieldName");
            }
            if (RelationshipFieldName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RelationshipFieldName");
            }
        }
    }
}

