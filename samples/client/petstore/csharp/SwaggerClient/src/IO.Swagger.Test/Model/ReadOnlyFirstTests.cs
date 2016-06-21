using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ReadOnlyFirst
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ReadOnlyFirstTests
    {
        private ReadOnlyFirst instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReadOnlyFirst();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReadOnlyFirst
        /// </summary>
        [Test]
        public void ReadOnlyFirstInstanceTest()
        {
			Assert.IsInstanceOfType(typeof(ReadOnlyFirst), instance, "instance is a ReadOnlyFirst");
        }

        /// <summary>
        /// Test the property 'Bar'
        /// </summary>
        [Test]
        public void BarTest()
        {
            // TODO: unit test for the property 'Bar'
        }
        /// <summary>
        /// Test the property 'Baz'
        /// </summary>
        [Test]
        public void BazTest()
        {
            // TODO: unit test for the property 'Baz'
        }

    }

}