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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the RotateEncryptionKey operation.
    /// <para> Rotates the encryption keys for a cluster. </para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.RotateEncryptionKey"/>
    public class RotateEncryptionKeyRequest : AmazonWebServiceRequest
    {
        private string clusterIdentifier;

        /// <summary>
        /// The unique identifier of the cluster that you want to rotate the encryption keys for. Constraints: Must be the name of valid cluster that
        /// has encryption enabled.
        ///  
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this.clusterIdentifier; }
            set { this.clusterIdentifier = value; }
        }

        /// <summary>
        /// Sets the ClusterIdentifier property
        /// </summary>
        /// <param name="clusterIdentifier">The value to set for the ClusterIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RotateEncryptionKeyRequest WithClusterIdentifier(string clusterIdentifier)
        {
            this.clusterIdentifier = clusterIdentifier;
            return this;
        }
            

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this.clusterIdentifier != null;
        }
    }
}
    
