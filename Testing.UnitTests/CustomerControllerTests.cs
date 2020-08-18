using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Testing.Fundamentals;

namespace Testing.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController controller;

        [SetUp]
        public void SetUp()
        {
            controller = new CustomerController();
        }
        [Test]
        public void GetCustomer_IdIsZero_CustomerNotFound()
        {
            var result = controller.GetCustomer(0);

            Assert.That(result, Is.TypeOf<CustomerController.NotFound>());

            //Assert.That(result, Is.InstanceOf<CustomerController.NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_CustomerOk()
        {
            var result = controller.GetCustomer(1);

            Assert.That(result , Is.InstanceOf<CustomerController.Ok>());
        }
    }
}
