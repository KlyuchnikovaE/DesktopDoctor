//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopDoctor
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reception
    {
        public Reception()
        {
            this.ReceprionsProcedures = new HashSet<ReceprionProcedure>();
            this.ReceptionsComplaints = new HashSet<ReceptionComplaint>();
            this.ReceptionsMedicines = new HashSet<ReceptionMedicine>();
            this.ReceptionsRecommendations = new HashSet<ReceptionRecommendation>();
        }
    
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public int EmployeeId { get; set; }
        public int PatientId { get; set; }
        public Nullable<double> Temperature { get; set; }
        public Nullable<int> Pressure { get; set; }
        public string Diagnosis { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<ReceprionProcedure> ReceprionsProcedures { get; set; }
        public virtual ICollection<ReceptionComplaint> ReceptionsComplaints { get; set; }
        public virtual ICollection<ReceptionMedicine> ReceptionsMedicines { get; set; }
        public virtual ICollection<ReceptionRecommendation> ReceptionsRecommendations { get; set; }
    }
}