using System.ComponentModel.DataAnnotations;

namespace survey_app.Models;


public class Question
{
    public class Choice
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }
    }

    public int Id {get; set;}
    public string? Description {get; set;}
    public List<Choice>? choices {get; set;}
}