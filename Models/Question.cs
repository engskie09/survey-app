using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace survey_app.Models;

public class Choice
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("QuestionId")]
    public int QuestionId { get; set; }
    public string? Description { get; set; }
}

public class Question
{
    [Key]
    public int Id {get; set;}
    [Column]
    public string? Description {get; set;}
    public List<Choice>? Choices {get; set;}
}