//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BudgetManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class BudgetItem
    {
        public int Id { get; set; }
        public double Allocation { get; set; }
        public int BudgetId { get; set; }
        public int CategoryId { get; set; }
        public TransactionType ItemType { get; set; }
    
        public virtual Budget Budget { get; set; }
        public virtual Category Category { get; set; }
    }
}
