using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace TestApp.ModelsNorthWind;

public partial class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<Customer> builder);


    public void Configure(EntityTypeBuilder<Customer> builder)
    {

        MoreBuilderCalls (builder) ;


    }
}

