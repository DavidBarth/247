using _247.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace _247.Controllers
{
    public class IssuesController : Controller
    {
        private ApplicationDbContext _context;

        public IssuesController()
        {
            _context = new ApplicationDbContext();
        }
       
        // GET: Issues
        public ActionResult Index()
        {
            

            var testIssue = new Issue
            {
                Id = 1,
                Location = "Belfast",
                Address = "10, Adelaide street",
                ContactNumber = "07123456789",
                ProblemDescription = "Plumber needed, toalet not flushing down."

            };

            var testIssue2 = new Issue
            {
                Id = 1,
                Location = "Dmurry",
                Address = "1, Dmurry Road",
                ContactNumber = "07523487649",
                ProblemDescription = "No lights"

            };

            List<Issue> issues = new List<Issue>
            { testIssue, testIssue2};

            return View(issues);
        }

        // GET: Issues/Details/5
        public ActionResult Details()
        {
            var testIssue = new Issue
            {
                Id = 1,
                Location = "Belfast",
                Address = "10, Adelaide street",
                ContactNumber = "07123456789",
                ProblemDescription = "Plumber needed, toalet not flushing down."

            };
            return View(testIssue);
        }

        // GET: Issues/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Issues/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Issues/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Issues/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Issues/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Issues/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
