
namespace AdminPanelCRUD.Controllers
{
    public class BookController :Controller
    {
        private readonly PustokContext _pustokContext;
        public BookController(PustokContext pustokContext)
        {     
            _pustokContext= pustokContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int id)
        {

            Book book = _pustokContext.Books
                .Include(x => x.Author).Include(x=>x.Genre)
                .Include(x=>x.BookImages).FirstOrDefault(x=>x.Id==id);

            if (book == null) return View("Error");
            BookViewModel bookViewModel= new BookViewModel
            {
                Book=book,
                RelatedBooks=_pustokContext.Books.Include(x=>x.BookImages)
                .Include(x=>x.Author).Include(x=>x.Genre)
                .Where(x=>x.GenreId==book.GenreId).ToList(),
            };
            return View(book);
        }
    }
}
