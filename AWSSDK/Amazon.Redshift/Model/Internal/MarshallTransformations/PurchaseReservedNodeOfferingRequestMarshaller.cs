/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Purchase Reserved Node Offering Request Marshaller
    /// </summary>       
    public class PurchaseReservedNodeOfferingRequestMarshaller : IMarshaller<IRequest, PurchaseReservedNodeOfferingRequest>
    {
        public IRequest Marshall(PurchaseReservedNodeOfferingRequest purchaseReservedNodeOfferingRequest)
        {
            IRequest request = new DefaultRequest(purchaseReservedNodeOfferingRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "PurchaseReservedNodeOffering");
            request.Parameters.Add("Version", "2012-12-01");
            if (purchaseReservedNodeOfferingRequest != null && purchaseReservedNodeOfferingRequest.IsSetReservedNodeOfferingId())
            {
                request.Parameters.Add("ReservedNodeOfferingId", StringUtils.FromString(purchaseReservedNodeOfferingRequest.ReservedNodeOfferingId));
            }
            if (purchaseReservedNodeOfferingRequest != null && purchaseReservedNodeOfferingRequest.IsSetNodeCount())
            {
                request.Parameters.Add("NodeCount", StringUtils.FromInt(purchaseReservedNodeOfferingRequest.NodeCount));
            }

            return request;
        }
    }
}
