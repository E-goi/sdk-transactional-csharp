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
    ///  Class for testing DomainsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DomainsApiTests
    {
        private DomainsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DomainsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DomainsApi
            //Assert.IsInstanceOfType(typeof(DomainsApi), instance, "instance is a DomainsApi");
        }

        /// <summary>
        /// Test AddDomain
        /// </summary>
        [Test]
        public void AddDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DomainRequest body = null;
            //var response = instance.AddDomain(body);
            //Assert.IsInstanceOf<DomainResponse> (response, "response is DomainResponse");
        }
        /// <summary>
        /// Test ChangeDefaultDomain
        /// </summary>
        [Test]
        public void ChangeDefaultDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DefaultDomainRequest body = null;
            //var response = instance.ChangeDefaultDomain(body);
            //Assert.IsInstanceOf<DomainResponse> (response, "response is DomainResponse");
        }
        /// <summary>
        /// Test ListDefaultDomain
        /// </summary>
        [Test]
        public void ListDefaultDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListDefaultDomain();
            //Assert.IsInstanceOf<DomainResponse> (response, "response is DomainResponse");
        }
        /// <summary>
        /// Test ListDomain
        /// </summary>
        [Test]
        public void ListDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ListDomain(id);
            //Assert.IsInstanceOf<DomainResponse> (response, "response is DomainResponse");
        }
        /// <summary>
        /// Test ListDomains
        /// </summary>
        [Test]
        public void ListDomainsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListDomains();
            //Assert.IsInstanceOf<List<DomainResponse>> (response, "response is List<DomainResponse>");
        }
        /// <summary>
        /// Test ValidateDomain
        /// </summary>
        [Test]
        public void ValidateDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ValidateDomain(id);
            //Assert.IsInstanceOf<ValidateDomainResponse> (response, "response is ValidateDomainResponse");
        }
    }

}
