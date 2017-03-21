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

/*
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Container for the parameters to the PutEventStream operation.
    /// Use to create or update the event stream for an app.
    /// </summary>
    public partial class PutEventStreamRequest : AmazonPinpointRequest
    {
        private string _applicationId;
        private WriteEventStream _writeEventStream;

        /// <summary>
        /// Gets and sets the property ApplicationId. ApplicationId
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property WriteEventStream. EventStream to write.
        /// </summary>
        public WriteEventStream WriteEventStream
        {
            get { return this._writeEventStream; }
            set { this._writeEventStream = value; }
        }

        // Check to see if WriteEventStream property is set
        internal bool IsSetWriteEventStream()
        {
            return this._writeEventStream != null;
        }

    }
}