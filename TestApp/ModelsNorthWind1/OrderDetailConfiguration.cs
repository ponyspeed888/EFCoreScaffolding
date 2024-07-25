using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace TestApp.ModelsNorthWind;

public partial class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<OrderDetail> builder);


    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {

        MoreBuilderCalls (builder) ;


    }
}

