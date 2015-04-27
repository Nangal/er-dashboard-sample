//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERDashboard.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admittance
    {
        public Admittance()
        {
            this.ClinicalNotes = new HashSet<ClinicalNote>();
            this.Complaints = new HashSet<Complaint>();
            this.Orders = new HashSet<Order>();
            this.Tests = new HashSet<Test>();
            this.Vitals = new HashSet<Vital>();
        }
    
        public int ID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public Nullable<int> StaffAttendingID { get; set; }
        public Nullable<int> StaffRNID { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> TimestampIn { get; set; }
        public Nullable<System.DateTime> TimestampOut { get; set; }
        public string Location { get; set; }
        public string Severity { get; set; }
        public string Disposition { get; set; }
        public string Diagnosis { get; set; }
        public string Clinical_Notes { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual ICollection<ClinicalNote> ClinicalNotes { get; set; }
        public virtual ICollection<Complaint> Complaints { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
        public virtual ICollection<Vital> Vitals { get; set; }
    }
}