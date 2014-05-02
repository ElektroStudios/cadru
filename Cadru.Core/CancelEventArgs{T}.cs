﻿//------------------------------------------------------------------------------
// <copyright file="CancelEventArgs{T}.cs" 
//  company="Scott Dorman" 
//  library="Cadru">
//    Copyright (C) 2001-2014 Scott Dorman.
// </copyright>
// 
// <license>
//    Licensed under the Microsoft Public License (Ms-PL) (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//    http://opensource.org/licenses/Ms-PL.html
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </license>
//------------------------------------------------------------------------------

namespace Cadru
{
    using System;
    using System.ComponentModel;
    using System.Runtime.Serialization;

    /// <summary>
    /// <see cref="CancelEventArgs{T}"/> is the base class for classes containing event data
    /// for a cancelable event.
    /// </summary>
    /// <typeparam name="T">The type of the event data.</typeparam>
    [DataContract]
    public class CancelEventArgs<T> : CancelEventArgs
    {
        #region fields
        private readonly T data;
        #endregion

        #region constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelEventArgs{T}"/> class.
        /// </summary>
        /// <param name="data">The event data.</param>
        public CancelEventArgs(T data)
        {
            this.data = data;
        }
        #endregion

        #region events
        #endregion

        #region properties
        /// <summary>
        /// Gets the event data.
        /// </summary>
        /// <value>The event data.</value>
        [DataMember]
        public T Data
        {
            get { return this.data; }
        }
        #endregion

        #region methods
        #endregion
    }
}
