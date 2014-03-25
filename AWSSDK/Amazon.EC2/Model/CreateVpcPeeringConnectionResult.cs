/*******************************************************************************
 * Copyright 2008-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    [XmlRootAttribute(IsNullable = false)]
    public class CreateVpcPeeringConnectionResult
    {
        private VpcPeeringConnection vpcPeeringConnectionField;

        /// <summary>
        /// Information about the VPC peering connection.
        ///  
        /// </summary>
        public VpcPeeringConnection VpcPeeringConnection
        {
            get { return this.vpcPeeringConnectionField; }
            set { this.vpcPeeringConnectionField = value; }
        }
        
        /// <summary>
        /// Sets the VpcPeeringConnection
        /// <param name="vpcPeeringConnection">The VpcPeeringConnection.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateVpcPeeringConnectionResult WithVpcPeeringConnection(VpcPeeringConnection vpcPeeringConnection)
        {
            this.vpcPeeringConnectionField = vpcPeeringConnection;
            return this;
        }
        
        /// <summary>
        /// Checks if VpcPeeringConnection is set
        /// </summary>
        /// <returns>true if VpcPeeringConnection property is set</returns>
        public bool IsSetVpcPeeringConnection()
        {
            return this.vpcPeeringConnectionField != null;
        }
        
    }
}
