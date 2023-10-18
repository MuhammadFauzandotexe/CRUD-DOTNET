using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CRUD_DOTNET.Entities;

[Table(name:"m_customer")]
public class Customer
{
    [Key,Column(name:"id"),DatabaseGenerated(DatabaseGeneratedOption.Identity),Required]
    public int Id { set; get; }
    
    [Column(name:"customer_name",TypeName = "varchar(50)"),Required]
    public string CustomerName { set; get; }
    
    [Column(name:"address",TypeName = "varchar(250)"),Required]
    public string Address { set; get; }
    
    [Column(name:"phone_number",TypeName = "varchar(15)"),Required]
    public string PhoneNumber { set; get; }
    
    [Column(name:"email",TypeName = "varchar(50)"),Required]
    public string Email { set; get; }

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(CustomerName)}: {CustomerName}, {nameof(Address)}: {Address}, {nameof(PhoneNumber)}: {PhoneNumber}, {nameof(Email)}: {Email}";
    }
}