using System.Collections.Generic;
using HostelManagement.Core.Services;
using HostelManagement.Core.Domain.DataAccess;
using HostelManagement.Domain.Model;
using HostelManagement.UnitTests.Fakes;
using MbUnit.Framework;
using Moq;

namespace HostelManagement.UnitTests.Services {

    [TestFixture]
    public class TenantServiceTests {

        [Test]
        public void GetTenantsShouldReturnAnIListOfTenants() {
            var mockTenantRepository = new Mock<ITenantRepository>();
            mockTenantRepository.Setup(x => x.GetTenants()).Returns(new List<Tenant>());
            var service = new TenantService(mockTenantRepository.Object);

            var result = service.GetTenants();
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(typeof(IList<Tenant>), result);
        }

        [Test]
        public void GetTenantsShouldReturnAtleast1Tenant() {
            var mockTenantRepository = new Mock<ITenantRepository>();
            mockTenantRepository.Setup(x => x.GetTenants()).Returns(new List<Tenant> { new Tenant() });
            var service = new TenantService(mockTenantRepository.Object);

            var result = service.GetTenants();
            Assert.IsTrue(result.Count > 0);
        }

        [Test]
        public void AddTenantShouldPersistTheNewTenantDetails() {
            var service = new TenantService(new FakeTenantRepository());
            var tenant = GetTenant();
            var initialCount = service.GetTenants().Count;

            service.AddTenant(tenant);
            var result = service.GetTenants().Count;
            Assert.AreEqual(initialCount + 1, result);
        }

        [Test]
        public void CanGetCustomerByAdmissionNumber() {
            var service = new TenantService(new FakeTenantRepository());

            var tenant = service.GetTenant("001");
            Assert.IsNotNull(tenant);
            Assert.AreEqual("001", tenant.AdmissionNumber);
        }

        [Test]
        public void CanEditTenantsDetails() {
            var service = new TenantService(new FakeTenantRepository());
            var tenant = service.GetTenant("001");
            tenant.FullName = "ChangedName";
            service.UpdateTenant(tenant);

            var changedTenant = service.GetTenant("001");

            Assert.AreEqual(tenant.FullName, changedTenant.FullName);
        }

        [Test]
        public void CanDeleteTenant() {
            var service = new TenantService(new FakeTenantRepository());
            service.DeleteTenant("001");
            var tenant = service.GetTenant("001");
            Assert.IsNull(tenant);
        }


        //helpers
        private Tenant GetTenant() {
            return new Tenant()
            {
                ID = 1,
                AdmissionNumber = "323232",
                FullName = "Jack Welch",
                FathersName = "Jack Obama",
                Address = "Hilly Billy Rd, Hyd",
                RoomNumber = "12C",
                Phone = "3207324",
                IsActive = true
            };
        }

    }

}
