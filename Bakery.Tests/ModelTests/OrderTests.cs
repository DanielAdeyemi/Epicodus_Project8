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

    [TestMethod]
    public void GetAll_ReturnOrders_OrderList()
    {
      Order order1 = new Order("Bread", "wow", "3/05", 22);
			Order order2 = new Order("Pastry", "7 paistries for kids", "3/05", 30);
			List<Order> newList = new List<Order> {order1, order2};
			List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

  }
}
