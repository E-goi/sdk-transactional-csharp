/* 
 * Transactional API
 *
 * # Introduction    This API is a service provided by [E-goi](www.e-goi.com) to send transactional messages.    Transactional Messaging is a 1-to-1 communication channel, usually from an organization directed to a specific consumer.   They can be triggered by:    * __Actions__ - The consumer interacts with the organization (ie.: online shopping);  * __Time__ - The consumer's actions are time-bounded by the organization (ie.: period of inactivity).    Because of the nature of these messages,   it is expected that the consumer is interested in the content of these messages.   Therefore, they have a different treatment from marketing messages, and have a higher acceptance and opening rate.    >DISCLAIMER  >  >Please notice that this platform is more delicate in regards to the nature and processing of its messages.  >  >It should NOT be used as a mean of mass marketing, scams, phishing or overall unruly behaviour.   >  >Failure to comply may lead to limitation of use and even termination of account.    ***
 *
 * OpenAPI spec version: V2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing CancelAlertRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CancelAlertRequestTests
    {
        // TODO uncomment below to declare an instance variable for CancelAlertRequest
        //private CancelAlertRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CancelAlertRequest
            //instance = new CancelAlertRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CancelAlertRequest
        /// </summary>
        [Test]
        public void CancelAlertRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CancelAlertRequest
            //Assert.IsInstanceOfType<CancelAlertRequest> (instance, "variable 'instance' is a CancelAlertRequest");
        }


        /// <summary>
        /// Test the property 'AlertName'
        /// </summary>
        [Test]
        public void AlertNameTest()
        {
            // TODO unit test for the property 'AlertName'
        }

    }

}
