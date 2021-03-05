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

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Vendor newVendor1 = new Vendor("AMC", "Vendor1");
      Vendor newVendor2 = new Vendor("APL", "Vendor2");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
  }

    [TestMethod]
    public void Find_ReturnsCorrectVendorById_Vendor()
    {
      Vendor newVendor1 = new Vendor("AMC", "Vendor1");
      Vendor newVendor2 = new Vendor("APL", "Vendor2");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

}
}