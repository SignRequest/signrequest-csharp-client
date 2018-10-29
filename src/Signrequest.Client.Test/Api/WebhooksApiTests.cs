/* 
 * SignRequest API
 *
 * API for SignRequest.com
 *
 * OpenAPI spec version: v1
 * Contact: tech-support@signrequest.com
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

using Signrequest.Client.Client;
using Signrequest.Client.Api;
using Signrequest.Client.Model;

namespace Signrequest.Client.Test
{
    /// <summary>
    ///  Class for testing WebhooksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WebhooksApiTests
    {
        private WebhooksApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WebhooksApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WebhooksApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WebhooksApi
            //Assert.IsInstanceOfType(typeof(WebhooksApi), instance, "instance is a WebhooksApi");
        }

        
        /// <summary>
        /// Test WebhooksCreate
        /// </summary>
        [Test]
        public void WebhooksCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebhookSubscription data = null;
            //var response = instance.WebhooksCreate(data);
            //Assert.IsInstanceOf<WebhookSubscription> (response, "response is WebhookSubscription");
        }
        
        /// <summary>
        /// Test WebhooksDelete
        /// </summary>
        [Test]
        public void WebhooksDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //instance.WebhooksDelete(uuid);
            
        }
        
        /// <summary>
        /// Test WebhooksList
        /// </summary>
        [Test]
        public void WebhooksListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.WebhooksList(page, limit);
            //Assert.IsInstanceOf<InlineResponse2009> (response, "response is InlineResponse2009");
        }
        
        /// <summary>
        /// Test WebhooksPartialUpdate
        /// </summary>
        [Test]
        public void WebhooksPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //WebhookSubscription data = null;
            //var response = instance.WebhooksPartialUpdate(uuid, data);
            //Assert.IsInstanceOf<WebhookSubscription> (response, "response is WebhookSubscription");
        }
        
        /// <summary>
        /// Test WebhooksRead
        /// </summary>
        [Test]
        public void WebhooksReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //var response = instance.WebhooksRead(uuid);
            //Assert.IsInstanceOf<WebhookSubscription> (response, "response is WebhookSubscription");
        }
        
        /// <summary>
        /// Test WebhooksUpdate
        /// </summary>
        [Test]
        public void WebhooksUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //WebhookSubscription data = null;
            //var response = instance.WebhooksUpdate(uuid, data);
            //Assert.IsInstanceOf<WebhookSubscription> (response, "response is WebhookSubscription");
        }
        
    }

}
