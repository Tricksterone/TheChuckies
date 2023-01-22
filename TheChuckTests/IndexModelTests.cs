﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheChuck.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheChuck.Services;
using Microsoft.Extensions.Logging.Abstractions;
using TheChuckTests.Fakes;
using TheChuck.Models;

namespace TheChuck.Pages.Tests
{
    [TestClass()]
    public class IndexModelTests
    {
        [TestMethod()]
        public async Task OnGet_ShouldDisplayTextFromService()
        {
            //Arrange
            var joke = new Joke() { Value = "Works"};
            var sut = new IndexModel(NullLogger<IndexModel>.Instance, new FakeJokeService(joke));

            //Act
            await sut.OnGet();

            //Assert
            Assert.AreEqual("Works", sut.DisplayText);
        }

        /*

        [TestMethod()]
        public async Task OnGet_ShouldBeUppecase()
        {
            //Arrange
            var joke = new Joke() { Value = "Works"};
            var pageModel = new IndexModel(NullLogger<IndexModel>.Instance, new FakeJokeService(joke));

            //Act
            await pageModel.OnGet();

            //Assert
            Assert.AreEqual("WORKS", pageModel.DisplayText);
        }
        */

    }
}