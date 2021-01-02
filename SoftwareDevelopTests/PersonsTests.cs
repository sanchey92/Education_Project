using System;
using System.Collections.Generic;
using NUnit.Framework;
using SoftwareDevelopDomain;
using SoftwareDevelopDomain.Persons;

namespace SoftwareDevelopTests
{
    public class PersonTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void ManagerTotalPay()
        {
            var manager = new Manager("test", new List<TimeRecord>()
            {
                new TimeRecord(DateTime.Now.AddDays(-3), "test", 8, "test message"),
                new TimeRecord(DateTime.Now.AddDays(-2), "test", 10, "test message"),
                new TimeRecord(DateTime.Now.AddDays(-1), "test", 7, "test message"),
            });
            
            Assert.IsTrue(manager.TotalPay == 29750);
        }
    }
}