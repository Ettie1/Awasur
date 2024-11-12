using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace awasur.Models;

public class Policyholder
{
    [Key]
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    public int PolicyholderId {get; set;}
    public string Title {get; set;}
    public string Firstname {get; set;}
    [DisplayName("Surname")]
    public string Lastname {get; set;}
    [StringLength(13)]
    public string IDNo {get; set;}
    public int Age {get; set;}
    public DateTime DateOfBirth {get; set;}

}
public enum Title
{
    Mr, Ms
}