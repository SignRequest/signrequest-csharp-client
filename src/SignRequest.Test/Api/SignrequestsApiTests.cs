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

using SignRequest.Client;
using SignRequest.Api;
using SignRequest.Model;

namespace SignRequest.Test
{
    /// <summary>
    ///  Class for testing SignrequestsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SignrequestsApiTests
    {
        private SignrequestsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SignrequestsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SignrequestsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SignrequestsApi
            //Assert.IsInstanceOfType(typeof(SignrequestsApi), instance, "instance is a SignrequestsApi");
        }

        
        /// <summary>
        /// Test SignrequestsCancelSignrequest
        /// </summary>
        [Test]
        public void SignrequestsCancelSignrequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //var response = instance.SignrequestsCancelSignrequest(uuid);
            //Assert.IsInstanceOf<InlineResponse201> (response, "response is InlineResponse201");
        }
        
        /// <summary>
        /// Test SignrequestsCreate
        /// </summary>
        [Test]
        public void SignrequestsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SignRequest data = null;
            //var response = instance.SignrequestsCreate(data);
            //Assert.IsInstanceOf<SignRequest> (response, "response is SignRequest");
        }
        
        /// <summary>
        /// Test SignrequestsList
        /// </summary>
        [Test]
        public void SignrequestsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string who = null;
            //string fromEmail = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.SignrequestsList(who, fromEmail, page, limit);
            //Assert.IsInstanceOf<InlineResponse2005> (response, "response is InlineResponse2005");
        }
        
        /// <summary>
        /// Test SignrequestsRead
        /// </summary>
        [Test]
        public void SignrequestsReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //var response = instance.SignrequestsRead(uuid);
            //Assert.IsInstanceOf<SignRequest> (response, "response is SignRequest");
        }
        
        /// <summary>
        /// Test SignrequestsResendSignrequestEmail
        /// </summary>
        [Test]
        public void SignrequestsResendSignrequestEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //var response = instance.SignrequestsResendSignrequestEmail(uuid);
            //Assert.IsInstanceOf<InlineResponse2011> (response, "response is InlineResponse2011");
        }
        
    }

}
