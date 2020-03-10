using System;
using Xunit;
using Moq;
using DIDemoAPP.Controllers;
using Manager;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DIDemoAPP;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;

namespace DIDemoAPPTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var moc = new Mock<ICountryManager>();
            //moc.Setup(x => x.GetCountryList()).Returns(new string[] { });
            var result = new HomeController(moc.Object);
            //Act
            var countryList = result.CountryList();
            int count = countryList.Count;
            //Assert
            Assert.Equal(2.ToString(), count.ToString());
        }

        [Fact]
        public void Test2()
        {
            using (var client = new HttpClient())
            {
                //Act
                var response = (IList<string>) client.GetAsync("/api/values/Add");
                //Assert
                Assert.Equal(2.ToString(), response.Count.ToString());
            }
        }

        [Fact]
        public void Test3()
        {
            //Arrange
            var moc = new Mock<ICalculateManager>();
            var moc1 = new Mock<ICountryManager>();
            var mocResult = moc.Setup(x => x.Add(1, 2)).Returns(3);
            var result = new ValuesController(moc.Object, moc1.Object);
            var expectedOutput = 3;
            //Act
            var res = result.Add();
            //Assert
            Assert.Equal(expectedOutput.ToString(), res.ToString());
        }

    }

}
