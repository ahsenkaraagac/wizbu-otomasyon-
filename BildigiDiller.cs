//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wizbuotomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class BildigiDiller
    {
        public BildigiDiller()
        {
            this.Personel = new HashSet<Personel>();
        }
    
        public int Id { get; set; }
        public string ProgramlamaDili { get; set; }
        public Nullable<int> Seviyesi { get; set; }
    
        public virtual ICollection<Personel> Personel { get; set; }
    }
}
