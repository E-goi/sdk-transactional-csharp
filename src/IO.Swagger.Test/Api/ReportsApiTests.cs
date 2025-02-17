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
    ///  Class for testing ReportsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ReportsApiTests
    {
        private ReportsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReportsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReportsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReportsApi
            //Assert.IsInstanceOfType(typeof(ReportsApi), instance, "instance is a ReportsApi");
        }

        /// <summary>
        /// Test ProduceEmailReport
        /// </summary>
        [Test]
        public void ProduceEmailReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string group = null;
            //string groupBy = null;
            //string dateStart = null;
            //string dateEnd = null;
            //var response = instance.ProduceEmailReport(group, groupBy, dateStart, dateEnd);
            //Assert.IsInstanceOf<List<EmailReportResponse>> (response, "response is List<EmailReportResponse>");
        }
        /// <summary>
        /// Test ProduceSmsReport
        /// </summary>
        [Test]
        public void ProduceSmsReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string group = null;
            //string groupBy = null;
            //string dateStart = null;
            //string dateEnd = null;
            //var response = instance.ProduceSmsReport(group, groupBy, dateStart, dateEnd);
            //Assert.IsInstanceOf<List<SmsReportResponse>> (response, "response is List<SmsReportResponse>");
        }
    }

}
