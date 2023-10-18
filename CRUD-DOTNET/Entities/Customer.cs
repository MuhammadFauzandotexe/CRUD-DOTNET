using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_DOTNET.Entities;

[Table(name:"m_customer")]
public class Customer
{
    public string Id { set; get; }
    public string Name { set; get; }
    public string PhoneNumber { set; get; }
    public string Email { set; get; }
}