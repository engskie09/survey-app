using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace survey_app.Models;

public class Question
{
    public class Choice
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }
    }

    [Key]
    public int Id {get; set;}

    [Column(TypeName = "nvarchar(200)")]
    public string? Description {get; set;}
    public List<Choice>? Choices {get; set;}
}