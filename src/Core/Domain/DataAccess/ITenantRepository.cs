using HostelManagement.Domain.Model;
using System.Collections.Generic;

namespace HostelManagement.Core.Domain.DataAccess {
    public interface ITenantRepository {
        IList<Tenant> GetTenants();
        void AddTenant(Tenant tenant);
        void Save();
        Tenant GetTenant(string admissionNumber);
        void UpdateTenant(Tenant tenant);
        void DeleteTenant(string admissionNumber);
    }
}
