﻿//------------------------------------------------------------------------------
// <copyright file="TypeAssert.cs" 
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

namespace Cadru.UnitTest.Framework
{
    using System;
    using Cadru.Contracts;
    using Cadru.Extensions;
    using Cadru.UnitTest.Framework.Properties;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Contains assertion types that are not provided with the standard MSTest assertions.
    /// </summary>
    public static class TypeAssert
    {
        #region fields
        #endregion

        #region constructors
        #endregion

        #region events
        #endregion

        #region properties
        #endregion

        #region methods

        #region IsAssignableFrom

        #region IsAssignableFrom(object value, Type expectedType)
        /// <summary>
        /// Asserts that an object may be assigned a value of a given <see cref="Type"/>.
        /// </summary>
        /// <param name="value">The value to be tested.</param>
        /// <param name="expectedType">The expected <see cref="Type"/>.</param>
        public static void IsAssignableFrom(object value, Type expectedType)
        {
            TypeAssert.IsAssignableFrom(value, expectedType, Resources.Assertion_ExpectedToBeAssignableFrom, value, expectedType);
        }
        #endregion

        #region IsAssignableFrom(object value, Type expectedType, string message)
        /// <summary>
        /// Asserts that an object may be assigned a value of a given <see cref="Type"/>.
        /// </summary>
        /// <param name="value">The value to be tested.</param>
        /// <param name="expectedType">The expected <see cref="Type"/>.</param>
        /// <param name="message">A message to display. This message can be seen in the unit test results.</param>
        public static void IsAssignableFrom(object value, Type expectedType, string message)
        {
            TypeAssert.IsAssignableFrom(value, expectedType, message, null);
        }
        #endregion

        #region IsAssignableFrom(object value, Type expectedType, string message, params object[] parameters)
        /// <summary>
        /// Asserts that an object may be assigned a value of a given <see cref="Type"/>.
        /// </summary>
        /// <param name="value">The value to be tested.</param>
        /// <param name="expectedType">The expected <see cref="Type"/>.</param>
        /// <param name="message">A message to display. This message can be seen in the unit test results.</param>
        /// <param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param>
        public static void IsAssignableFrom(object value, Type expectedType, string message, params object[] parameters)
        {
            if (!value.GetType().IsAssignableFrom(expectedType))
            {
                Assert.Fail(message, parameters);
            }
        }
        #endregion

        #endregion

        #region IsNotAssignableFrom

        #region IsNotAssignableFrom(object value, Type expectedType)
        /// <summary>
        /// Asserts that an object may not be assigned a value of a given <see cref="Type"/>.
        /// </summary>
        /// <param name="value">The value to be tested.</param>
        /// <param name="expectedType">The expected <see cref="Type"/>.</param>
        public static void IsNotAssignableFrom(object value, Type expectedType)
        {
            TypeAssert.IsNotAssignableFrom(value, expectedType, Resources.Assertion_ExpectedToBeAssignableFrom, value, expectedType);
        }
        #endregion

        #region IsNotAssignableFrom(object value, Type expectedType, string message)
        /// <summary>
        /// Asserts that an object may not be assigned a value of a given <see cref="Type"/>.
        /// </summary>
        /// <param name="value">The value to be tested.</param>
        /// <param name="expectedType">The expected <see cref="Type"/>.</param>
        /// <param name="message">A message to display. This message can be seen in the unit test results.</param>
        public static void IsNotAssignableFrom(object value, Type expectedType, string message)
        {
            TypeAssert.IsNotAssignableFrom(value, expectedType, message, null);
        }
        #endregion

        #region IsNotAssignableFrom(object value, Type expectedType, string message, params object[] parameters)
        /// <summary>
        /// Asserts that an object may not be assigned a value of a given <see cref="Type"/>.
        /// </summary>
        /// <param name="value">The value to be tested.</param>
        /// <param name="expectedType">The expected <see cref="Type"/>.</param>
        /// <param name="message">A message to display. This message can be seen in the unit test results.</param>
        /// <param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param>
        public static void IsNotAssignableFrom(object value, Type expectedType, string message, params object[] parameters)
        {
            Requires.NotNull(value, "value");
            if (value.GetType().IsAssignableFrom(expectedType))
            {
                Assert.Fail(message, parameters);
            }
        }
        #endregion

        #endregion

        #region IsType

        #region IsType(object value, Type expectedType)
        /// <summary>
        /// Asserts that an object is of the given <see cref="Type"/>.
        /// </summary>
        /// <param name="value">The value to be tested.</param>
        /// <param name="expectedType">The expected <see cref="Type"/>.</param>
        public static void IsType(object value, Type expectedType)
        {
            Requires.NotNull(value, "value");
            TypeAssert.IsType(value, expectedType, Resources.Assertion_WrongType, expectedType, value.GetType());
        }
        #endregion

        #region IsType(object value, Type expectedType, string message)
        /// <summary>
        /// Asserts that an object is of the given <see cref="Type"/>.
        /// </summary>
        /// <param name="value">The value to be tested.</param>
        /// <param name="expectedType">The expected <see cref="Type"/>.</param>
        /// <param name="message">A message to display. This message can be seen in the unit test results.</param>
        public static void IsType(object value, Type expectedType, string message)
        {
            TypeAssert.IsType(value, expectedType, message, null);
        }
        #endregion

        #region IsType(object value, Type expectedType, string message, params object[] parameters)
        /// <summary>
        /// Asserts that an object is of the given <see cref="Type"/>.
        /// </summary>
        /// <param name="value">The value to be tested.</param>
        /// <param name="expectedType">The expected <see cref="Type"/>.</param>
        /// <param name="message">A message to display. This message can be seen in the unit test results.</param>
        /// <param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param>
        public static void IsType(object value, Type expectedType, string message, params object[] parameters)
        {
            Requires.NotNull(value, "value");
            Type actualType = value.GetType();
            if (actualType != expectedType)
            {
                if (message.IsNullOrWhiteSpace())
                {
                    Assert.Fail(Resources.Assertion_WrongType, expectedType, actualType);
                }
                else
                {
                    Assert.Fail(message, parameters);
                }
            }
        }
        #endregion

        #endregion

        #endregion
    }
}
