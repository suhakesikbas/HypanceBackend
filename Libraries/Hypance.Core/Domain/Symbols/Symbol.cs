﻿namespace Hypance.Core.Domain.Symbols;

public class Symbol : BaseEntity
{
    public string Name { get; set; }
    public decimal MinQuantity { get; set; }
    public decimal MaxQuantity { get; set; }
    public bool IsActive { get; set; }
}