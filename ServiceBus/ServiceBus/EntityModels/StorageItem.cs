
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ServiceBus.EntityModels
{

using System;
    using System.Collections.Generic;
    
public partial class StorageItem
{

    public System.Guid Id { get; set; }

    public System.Guid ProductId { get; set; }

    public System.Guid StorageId { get; set; }

    public System.Guid Quantity { get; set; }



    public virtual Product Product { get; set; }

    public virtual Storage Storage { get; set; }

}

}
