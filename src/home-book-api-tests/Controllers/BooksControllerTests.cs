using System;
using System.Threading.Tasks;
using NUnit.Framework;
using HomeBook.Api.Controllers;
using HomeBook.Core.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace HomeBook.Api.Tests.Controllers
{
    [TestFixture]
    public class BooksControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task  ShouldReturnBooks()
        {
            // Arrange
            BooksController controller = new BooksController();
            var expected = 200; 

            // Act
            var actual = (await controller.Get()) as IStatusCodeActionResult;

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual.StatusCode);
        }

        [Test]
        public async Task  ShouldReturnBook()
        {
            // Arrange
            BooksController controller = new BooksController();
            var expected = 200; 
            // Act
            var actual = (await controller.Get()) as IStatusCodeActionResult;
            
            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual.StatusCode);
        }

        [Test]
        public async Task  ShouldThrowExceptionWhenBookWasNotFound()
        {
            // Arrange
            BooksController controller = new BooksController();
            var expected = 404; 
            
            // Act
            var actual = (await controller.Get("test")) as IStatusCodeActionResult;
            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual.StatusCode);
        }
    }
}