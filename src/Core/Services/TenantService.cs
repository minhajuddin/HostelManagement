using System.Collections.Generic;
using HostelManagement.Domain.Model;
using HostelManagement.Core.Domain.DataAccess;

namespace HostelManagement.Core.Services {
    public class TenantService {

        private ITenantRepository _repository;

        public TenantService(ITenantRepository repository) {
            _repository = repository;
        }

        public IList<Tenant> GetTenants() {
            var tenants = _repository.GetTenants();
            return tenants;
        }

        public void AddTenant(Tenant tenant) {
            _repository.AddTenant(tenant);
            _repository.Save();
        }

        public Tenant GetTenant(string admissionNumber) {
            var tenant = _repository.GetTenant(admissionNumber);
            return tenant;
        }

        public void UpdateTenant(Tenant tenant) {
            _repository.UpdateTenant(tenant);
            _repository.Save();
        }

        public void DeleteTenant(string admissionNumber) {
            _repository.DeleteTenant(admissionNumber);
            _repository.Save();
        }
    }
}