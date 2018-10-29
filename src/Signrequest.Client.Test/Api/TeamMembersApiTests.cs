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
    ///  Class for testing TeamMembersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TeamMembersApiTests
    {
        private TeamMembersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TeamMembersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamMembersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TeamMembersApi
            //Assert.IsInstanceOfType(typeof(TeamMembersApi), instance, "instance is a TeamMembersApi");
        }

        
        /// <summary>
        /// Test TeamMembersList
        /// </summary>
        [Test]
        public void TeamMembersListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string isActive = null;
            //string isOwner = null;
            //string isAdmin = null;
            //string userEmail = null;
            //string userFirstName = null;
            //string userLastName = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.TeamMembersList(isActive, isOwner, isAdmin, userEmail, userFirstName, userLastName, page, limit);
            //Assert.IsInstanceOf<InlineResponse2006> (response, "response is InlineResponse2006");
        }
        
        /// <summary>
        /// Test TeamMembersRead
        /// </summary>
        [Test]
        public void TeamMembersReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //var response = instance.TeamMembersRead(uuid);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
    }

}
