using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using survey_app.Data;

namespace survey_app.Controllers;


public class QuestionController : Controller
{
    private ApplicationDbContext _context;

    public QuestionController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var questions = await _context.Questions.ToListAsync();

        return View(questions);
    }
}
