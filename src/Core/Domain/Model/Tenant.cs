using System;
namespace HostelManagement.Domain.Model {
    public class Tenant {
        public int ID { get; set; }
        public string AdmissionNumber { get; set; }
        public string FullName { get; set; }
        public string FathersName { get; set; }
        public string Address { get; set; }
        public string RoomNumber { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
