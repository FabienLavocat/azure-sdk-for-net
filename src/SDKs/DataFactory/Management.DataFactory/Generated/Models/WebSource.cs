// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using System.Linq;

    /// <summary>
    /// A copy activity source for web page table.
    /// </summary>
    public partial class WebSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the WebSource class.
        /// </summary>
        public WebSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebSource class.
        /// </summary>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        public WebSource(object sourceRetryCount = default(object), object sourceRetryWait = default(object))
            : base(sourceRetryCount, sourceRetryWait)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
