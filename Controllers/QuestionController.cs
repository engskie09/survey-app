using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using survey_app.Data;
using survey_app.Models;

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

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Question question)
    {
        if (ModelState.IsValid)
        {
            try
            {
                _context.Add(question);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            
            catch (Exception exception)
            {
                 ModelState.AddModelError(string.Empty, $"something went wrong {exception.Message}");
            }
        }

        ModelState.AddModelError(string.Empty, $"something went wrong invalid model");
        return View(question);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var exist = await _context.Questions.Where(x => x.Id == id).FirstOrDefaultAsync();
        return View(exist);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Question question)
    {
        if (ModelState.IsValid)
        {
            try
            {
                var exist = await _context.Questions.Where(x => x.Id == question.Id).FirstOrDefaultAsync();

                if (exist != null)
                {
                    exist.Description = question.Description;
                }

                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            
            catch (Exception exception)
            {
                 ModelState.AddModelError(string.Empty, $"something went wrong {exception.Message}");
            }
        }

        ModelState.AddModelError(string.Empty, $"something went wrong invalid model");
        return View(question);
    }
}
