//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUDAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTestPatient
    {
        public int patPatientId { get; set; }
        public string patPatientName { get; set; }
        public Nullable<System.DateTime> patDateOfBirth { get; set; }
        public string patEmailId { get; set; }
        public string patGender { get; set; }
        public string patAddress { get; set; }
        public string patPinCode { get; set; }
    }
}