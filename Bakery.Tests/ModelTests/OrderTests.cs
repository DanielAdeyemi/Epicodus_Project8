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
			Order newOrder = new Order("Bread", "wow", "3/05", 22);
			Assert.AreEqual("Bread" ,newOrder.Title);
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithIdAndGetterReturns_IntOne()
    {
      Order newOrder = new Order("Bread", "wow", "3/05", 22);
			int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

  }
}
