using AdminPanelCRUD.Models;

namespace AdminPanelCRUD.ViewModels
{
    public class BookViewModel
    {
        public Book Book { get; set; }
        public List<Book> RelatedBooks { get; set; }
    }
}
