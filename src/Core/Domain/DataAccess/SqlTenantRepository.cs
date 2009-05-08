using System.Collections.Generic;
using HostelManagement.Domain.Model;
using NHibernate.Cfg;
using NHibernate;

namespace HostelManagement.Core.Domain.DataAccess {
    public class SqlTenantRepository : ITenantRepository {

        private ISessionFactory _sessionFactory;

        public SqlTenantRepository() {
            _sessionFactory = (new Configuration()).Configure().BuildSessionFactory();
        }

        public IList<Tenant> GetTenants() {
            var session = GetSession();

            var tenants = session.CreateCriteria<Tenant>()
                .List<Tenant>();

            return tenants;
        }

        public void AddTenant(Tenant tenant) {
            throw new System.NotImplementedException();
        }

        public void Save() {
            throw new System.NotImplementedException();
        }

        public Tenant GetTenant(string admissionNumber) {
            throw new System.NotImplementedException();
        }

        public void UpdateTenant(Tenant tenant) {
            throw new System.NotImplementedException();
        }

        public void DeleteTenant(string admissionNumber) {
            throw new System.NotImplementedException();
        }

        //helpers
        private ISession GetSession() {
            return _sessionFactory.OpenSession();
        }

    }
}
