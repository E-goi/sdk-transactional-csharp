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
    ///  Class for testing CompleteSmsMessageResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CompleteSmsMessageResponseTests
    {
        // TODO uncomment below to declare an instance variable for CompleteSmsMessageResponse
        //private CompleteSmsMessageResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CompleteSmsMessageResponse
            //instance = new CompleteSmsMessageResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CompleteSmsMessageResponse
        /// </summary>
        [Test]
        public void CompleteSmsMessageResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CompleteSmsMessageResponse
            //Assert.IsInstanceOfType<CompleteSmsMessageResponse> (instance, "variable 'instance' is a CompleteSmsMessageResponse");
        }


        /// <summary>
        /// Test the property 'GroupId'
        /// </summary>
        [Test]
        public void GroupIdTest()
        {
            // TODO unit test for the property 'GroupId'
        }
        /// <summary>
        /// Test the property 'TextBody'
        /// </summary>
        [Test]
        public void TextBodyTest()
        {
            // TODO unit test for the property 'TextBody'
        }
        /// <summary>
        /// Test the property 'TemplateId'
        /// </summary>
        [Test]
        public void TemplateIdTest()
        {
            // TODO unit test for the property 'TemplateId'
        }
        /// <summary>
        /// Test the property 'SenderId'
        /// </summary>
        [Test]
        public void SenderIdTest()
        {
            // TODO unit test for the property 'SenderId'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'CreateDate'
        /// </summary>
        [Test]
        public void CreateDateTest()
        {
            // TODO unit test for the property 'CreateDate'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'SubscriberId'
        /// </summary>
        [Test]
        public void SubscriberIdTest()
        {
            // TODO unit test for the property 'SubscriberId'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Register'
        /// </summary>
        [Test]
        public void RegisterTest()
        {
            // TODO unit test for the property 'Register'
        }

    }

}
