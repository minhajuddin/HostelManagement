using MbUnit.Framework;
using HostelManagement.Domain.Model;
using System;

namespace HostelManagement.UnitTests.Domain.Model {
    [TestFixture]
    public class TenantTests {

        [Test]
        public void TenantShouldHaveIDAdmissionNumberFullNameFathersNameAddressRoomNumberPhone() {
            var dob = DateTime.Now.AddYears(-18).Date;
            var ts = DateTime.Now;
            Tenant tenant = new Tenant()
            {
                ID = 1,
                AdmissionNumber = "323232",
                FullName = "Jack Welch",
                FathersName = "Jack Obama",
                Address = "Hilly Billy Rd, Hyd",
                RoomNumber = "12C",
                Phone = "3207324",
                IsActive = true,
                DateOfBirth = dob,
                DateOfJoining = ts,
                Timestamp = ts
            };
            Assert.IsNotNull(tenant);
            Assert.AreEqual(tenant.ID, 1);
            Assert.AreEqual(tenant.AdmissionNumber, "323232");
            Assert.AreEqual(tenant.FullName, "Jack Welch");
            Assert.AreEqual(tenant.FathersName, "Jack Obama");
            Assert.AreEqual(tenant.Address, "Hilly Billy Rd, Hyd");
            Assert.AreEqual(tenant.RoomNumber, "12C");
            Assert.AreEqual(tenant.Phone, "3207324");
            Assert.AreEqual(true, tenant.IsActive);
            Assert.AreEqual(dob, tenant.DateOfBirth);
            Assert.AreEqual(ts, tenant.DateOfJoining);
            Assert.AreEqual(ts, tenant.Timestamp);
        }

    }
}