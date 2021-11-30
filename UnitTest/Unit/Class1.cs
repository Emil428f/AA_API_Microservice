using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest.Unit
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equals(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equals(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}

