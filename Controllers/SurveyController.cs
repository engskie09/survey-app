using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using survey_app.Data;
using survey_app.Models;

namespace survey_app.Controllers;


public class SurveyController : Controller
{
    private ApplicationDbContext _context;

    public SurveyController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var questions = await _context.Questions.ToListAsync();

        return View();
    }
}
