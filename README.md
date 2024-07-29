# This project is a drop in replacement of Microsoft.EntityFrameworkCore.Templates. 

Unlike my other repository EFTemplate, which combined all the various variations into a single code base.  This repostitory refactor the code into multiple branches, which make it easier to use and modify


It contains multiple branches.

## How to use :

For all branches except xxx :

* Copy The folder CodeTemplates into you project
* If you want Better template error detection at compile time, follow the instruction in install.txt
* Run reverse engineering as usual to get your model




## The main branch :

This branch is basic the same as Microsoft's version, with the following changes

* Add debug support, so that you can debug using Debugger.Launch
* All t4 include another file file called T4Helper.t4
* Better template error detection at compile time






## BETTER TEMPLATE ERROR DETECTION AT COMPILE TIME

The standard reverse engineering only use the t4 template as unstructured text.  It often return an error message that is meaningless. For example, this code block

    <#

        string StaticExtPropName = "ExtProp" ;
        string DynamicExtPropName = "ExtPropDynamic" ;
        string [] UseConfigure = new stringx [] { "Order", "OrderDetail"} ;

    #>

it return the following message


    Object reference not set to an instance of an object

If change the t4 template custom tool to "TextTemplatingFilePreProcessor", then the error message becomes :

Severity	Code	Description	Project	File	Line	Suppression State
Error (active)	CS0246	The type or namespace name 'stringx' could not be found (are you missing a using directive or an assembly reference?)	TemplateTestConsoleApp	U:\EFTemplate\TemplateTestConsoleApp\CodeTemplates\EFCore\EntityTypeConfiguration.cs	44	

But this create 2 problems :

1. The generated code reference global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData, which only exist in .net framework.  To solve the problem, I created a dummy class int JYDummyT4Helper.cs that provide the definition
2. EntityType.t4 itself use a parameter that use the name also called EntityType.  This will create a compile time error.  My solution is rename EntityType.t4 to entityType.t4






## The UseEntityConfig Branch



To specify which entity to generate config file look for this line in T4Helper.t4

    string [] UseConfigure = new string [] { "Order", "OrderDetail"} ;

and fill with the entity names you want to generate config file.  The generate config file is like :


The generated EntityConfiguration is like :


public partial class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<Order> builder);


    public void Configure(EntityTypeBuilder<Order> builder)
    {

        MoreBuilderCalls (builder) ;


    }
}

So just implement the partial method MoreBuilderCalls in another manually created class, so that it won't be overwritten when regenerating





## The JsonColumn Branch
The branch will generate a ef core 8 json column implementation.

How to use.
* Create a column with type string (nvarchar) and update StaticExtPropName to the column name in  t4helper.t4
  to 
    string StaticExtPropName = "YourProp" ;

    string [] RequireConfigPropertyList = new string [] { StaticExtPropName, DynamicExtPropName } ;

* Create a class called CustomYourProp, fill it with the properties you want

And then you can use the json column



## The mvvm Branch

This branch generate property that use mvvmtoolkit

## The mvvmWithJsonColumn Branch

The branch combine mvvm and JsonColumn
