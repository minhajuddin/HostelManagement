using HostelManagement.Core.Domain.DataAccess;
using HostelManagement.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace HostelManagement.UnitTests.Fakes {
    internal class FakeTenantRepository : ITenantRepository {

        IList<Tenant> _tenants;

        public FakeTenantRepository() {
            _tenants = new List<Tenant>();
            for (int i = 0; i < 10; i++) {
                _tenants.Add(
                    new Tenant
                    {
                        ID = i,
                        FullName = "Test " + i,
                        AdmissionNumber = "00" + i
                    });
            }
        }

        public IList<HostelManagement.Domain.Model.Tenant> GetTenants() {
            return _tenants;
        }

        public void AddTenant(HostelManagement.Domain.Model.Tenant tenant) {
            _tenants.Add(tenant);
        }

        public void Save() {
        }

        public Tenant GetTenant(string admissionNumber) {
            return _tenants.SingleOrDefault(x => x.AdmissionNumber == admissionNumber);
        }


        public void UpdateTenant(Tenant tenant) {
            var oldTenant = _tenants.SingleOrDefault(x => x.AdmissionNumber == tenant.AdmissionNumber);
            oldTenant = tenant;
        }


        public void DeleteTenant(string admissionNumber) {
            var tenant = _tenants.SingleOrDefault(x => x.AdmissionNumber == admissionNumber);
            _tenants.Remove(tenant);
        }

    }
}
