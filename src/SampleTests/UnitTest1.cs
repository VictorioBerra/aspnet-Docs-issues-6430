using SampleMVC.Controllers;
using System;
using Xunit;

namespace SampleTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a = new HomeController(null);
        }
    }
}
