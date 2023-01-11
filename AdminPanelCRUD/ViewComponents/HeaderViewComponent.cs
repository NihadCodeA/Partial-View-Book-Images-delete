
namespace AdminPanelCRUD.ViewComponents
{
	public class HeaderViewComponent:ViewComponent
	{
		private readonly PustokContext _context;
		public HeaderViewComponent(PustokContext context) 
		{
			_context = context;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			Book book =_context.Books.FirstOrDefault();

			return View(await Task.FromResult(book));
		}
	}
}
