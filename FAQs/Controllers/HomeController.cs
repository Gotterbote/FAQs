using FAQs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FAQs.Controllers
{
    public class HomeController : Controller
    {
        private FaqsContext context { get; set; }

        public HomeController (FaqsContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(string Topic, string Category)
        {  
            ViewBag.Topic = context.Topics.OrderBy(t => t.Name).ToList();
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
            ViewBag.SelectedTopic = Topic;

            IQueryable<FAQ> faqs = context.FAQs
                .Include(f => f.Topic)
                .Include(f => f.Category)
                .OrderBy(f => f.Question);

            if (!string.IsNullOrEmpty(Topic))
            {
                faqs = faqs.Where(f => f.TopicId == Topic);
            }
            if (!string.IsNullOrEmpty(Category))
            {
                faqs = faqs.Where(f => f.CategoryId == Category);
            }
            return View(faqs.ToList());
        }
    }
}
