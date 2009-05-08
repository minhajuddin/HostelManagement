using MbUnit.Framework;
using HostelManagement.Domain.Model;
using System.Collections.Generic;
using HostelManagement.Core.Domain.DataAccess;


namespace HostelManangement.IntegrationTests.Domain.DataAccess {
    [TestFixture]
    class SqlTenantRepositoryTests {

        [Test]
        public void GetTenantsShouldReturnAnIListOfTenants() {
            var tenantRepo = new SqlTenantRepository();
            var result = tenantRepo.GetTenants();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(typeof(IList<Tenant>), result);
        }

        [Test]
        public void GetTenantsShouldReturnAtleast1Tenants() {
            var tenantRepo = new SqlTenantRepository();
            var result = tenantRepo.GetTenants();

            Assert.IsTrue(result.Count > 0);
        }
    }
}
