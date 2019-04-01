using CSASPNETMVCLibraryExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSASPNETMVCLibraryExample.Controllers
{
    public class BooklistController : Controller
    {
        // GET: Booklist
        public ActionResult Indexbook()
        {
            var booklist = new Booklist {
                Bookname = "The Catcher in the Rye",
                Bookdescription = "Story by J. D. Salinger...",
                Bookauthor = "J. D. Salinger",
                Bookreleasedate = 1951
            };
            return View("Indexbook", booklist);
            //return new ViewResult { };
        }

        public ActionResult Fulllist()
        {
            var booklists = new List<Booklist> {
                new Booklist {
                Bookname = "The Catcher in the Rye",
                Bookdescription = "Story by J. D. Salinger...",
                Bookauthor = "J. D. Salinger",
                Bookreleasedate = 1951
            },
                new Booklist {
                Bookname = "The Hunger Games",
                Bookdescription = "Dystopian novel by the American writer Suzanne Collins...",
                Bookauthor = "Suzanne Collins",
                Bookreleasedate = 2008
            },
                new Booklist {
                Bookname = "The Maze Runner",
                Bookdescription = "Novel written by American author James Dashner...",
                Bookauthor = "James Dashner",
                Bookreleasedate = 2009
            },
                new Booklist {
                Bookname = "Divergent",
                Bookdescription = "Debut novel of American novelist Veronica Roth...",
                Bookauthor = "Veronica Roth",
                Bookreleasedate = 2011
            },
            };
            return PartialView("Fulllist", booklists);
        }

    }
}