﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace KoiFarmShop.Repositories.Models;

public partial class Koi
{
    public long Id { get; set; }

    public long? FarmId { get; set; }

    public long? PromotionId { get; set; }

    public string Specie { get; set; }

    public string Name { get; set; }

    public string Origin { get; set; }

    public bool? Sex { get; set; }

    public double? Size { get; set; }

    public int? YearOfBirth { get; set; }

    public double? Weight { get; set; }

    public double? Price { get; set; }

    public double? Description { get; set; }

    public string Image { get; set; }

    public string Status { get; set; }

    public virtual ICollection<Consignment> Consignments { get; set; } = new List<Consignment>();

    public virtual KoiFarm Farm { get; set; }

    public virtual ICollection<KoiQualification> KoiQualifications { get; set; } = new List<KoiQualification>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Promotion Promotion { get; set; }
}