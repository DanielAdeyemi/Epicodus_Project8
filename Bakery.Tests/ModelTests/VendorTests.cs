using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_StringName()
    {
      Vendor newVendor = new Vendor("AMC", "Vendor");
      Assert.AreEqual("AMC", newVendor.Name);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_One()
    {
      Vendor newVendor = new Vendor("AMC", "Vendor");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
  }
}