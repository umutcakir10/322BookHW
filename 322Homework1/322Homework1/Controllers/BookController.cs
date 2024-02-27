using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using _322Homework1.Models;


namespace _322Homework1.Controllers
{
 




    public class BookController : Controller
    {
        
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Display(string name, string author, int page_number, DateTime due_date, int a)
        {
            Book book = new Book();
            book.name = name;
            book.author = author;
            book.page_number = page_number;
            book.due_date = due_date;
            ///book.remainingTime = remainingTime;
            DateTime now = DateTime.Now;
            ///remainingTime = due_date - now;

            TimeSpan remainingTime = due_date - now;
            ///a = remainingTime.TotalDays;
            book.remainingTime = remainingTime;
            return View(book);
        }
    }

}