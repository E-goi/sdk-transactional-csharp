/* 
 * Transactional API
 *
 * # Introduction    This API is a service provided by [E-goi](www.e-goi.com) to send transactional messages.    Transactional Messaging is a 1-to-1 communication channel, usually from an organization directed to a specific consumer.   They can be triggered by:    * __Actions__ - The consumer interacts with the organization (ie.: online shopping);  * __Time__ - The consumer's actions are time-bounded by the organization (ie.: period of inactivity).    Because of the nature of these messages,   it is expected that the consumer is interested in the content of these messages.   Therefore, they have a different treatment from marketing messages, and have a higher acceptance and opening rate.    >DISCLAIMER  >  >Please notice that this platform is more delicate in regards to the nature and processing of its messages.  >  >It should NOT be used as a mean of mass marketing, scams, phishing or overall unruly behaviour.   >  >Failure to comply may lead to limitation of use and even termination of account.    ***
 *
 * OpenAPI spec version: V2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing VerifyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VerifyApiTests
    {
        private VerifyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VerifyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VerifyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VerifyApi
            //Assert.IsInstanceOfType(typeof(VerifyApi), instance, "instance is a VerifyApi");
        }

        /// <summary>
        /// Test CancelVerify
        /// </summary>
        [Test]
        public void CancelVerifyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.CancelVerify(id);
            //Assert.IsInstanceOf<List<VerifyIdResponse>> (response, "response is List<VerifyIdResponse>");
        }
        /// <summary>
        /// Test GetVerify
        /// </summary>
        [Test]
        public void GetVerifyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetVerify(id);
            //Assert.IsInstanceOf<CheckVerifyResponse> (response, "response is CheckVerifyResponse");
        }
        /// <summary>
        /// Test RequestVerify
        /// </summary>
        [Test]
        public void RequestVerifyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VerifyRequest body = null;
            //var response = instance.RequestVerify(body);
            //Assert.IsInstanceOf<VerifyIdResponse> (response, "response is VerifyIdResponse");
        }
        /// <summary>
        /// Test ResendVerify
        /// </summary>
        [Test]
        public void ResendVerifyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ResendVerify(id);
            //Assert.IsInstanceOf<List<VerifyIdResponse>> (response, "response is List<VerifyIdResponse>");
        }
        /// <summary>
        /// Test ValidateVerifyCode
        /// </summary>
        [Test]
        public void ValidateVerifyCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ValidateCodeVerifyRequest body = null;
            //var response = instance.ValidateVerifyCode(id, body);
            //Assert.IsInstanceOf<List<VerifyIdResponse>> (response, "response is List<VerifyIdResponse>");
        }
    }

}
