using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;

namespace AutoFakker.Tests
{
    [TestFixture]
    public class AutoFakeTest
    {
        private AutoFaker _fake;

        [SetUp]
        public void AAA_TestSetup()
        {
            _fake = new AutoFaker();
        }

        [Test]
        public void Create_RootClass_Returns_TypeAssignableToRootClass()
        {
            var fake = _fake.Create<RootClass>();
            
            fake.Should().BeAssignableTo<RootClass>();
        }

        [Test]
        public void Create_RootClass_Returns_TypeAssignableToFakeRooClass()
        {
            var fake = _fake.Create<RootClass>();
            
            fake.Should().BeAssignableTo<Fake<RootClass>>();
        }
    }

    public class RootClass
    {
        public void Tree()
        {
            throw new NotImplementedException();
        }
    }
}
