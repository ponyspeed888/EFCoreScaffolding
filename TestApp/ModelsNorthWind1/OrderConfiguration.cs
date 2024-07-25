using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace TestApp.ModelsNorthWind;

public partial class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<Order> builder);


    public void Configure(EntityTypeBuilder<Order> builder)
    {

        MoreBuilderCalls (builder) ;


    }
}

