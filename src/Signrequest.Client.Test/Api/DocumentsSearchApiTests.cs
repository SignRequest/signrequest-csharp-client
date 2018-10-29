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
    ///  Class for testing DocumentsSearchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DocumentsSearchApiTests
    {
        private DocumentsSearchApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DocumentsSearchApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DocumentsSearchApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DocumentsSearchApi
            //Assert.IsInstanceOfType(typeof(DocumentsSearchApi), instance, "instance is a DocumentsSearchApi");
        }

        
        /// <summary>
        /// Test DocumentsSearchList
        /// </summary>
        [Test]
        public void DocumentsSearchListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //string q = null;
            //string autocomplete = null;
            //string name = null;
            //string subdomain = null;
            //string signerEmails = null;
            //string status = null;
            //string who = null;
            //string format = null;
            //decimal? signerData = null;
            //var response = instance.DocumentsSearchList(page, limit, q, autocomplete, name, subdomain, signerEmails, status, who, format, signerData);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
    }

}
