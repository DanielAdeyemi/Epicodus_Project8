using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstractor_CreateInstanceOfOrder_Order()
    {
			Order newOrder = new Order("test", "wow", "3/05");
			Assert.AreEqual("Bread" ,newOrder.Title);
    }
  }
}
