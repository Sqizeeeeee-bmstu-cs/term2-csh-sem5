




public class BadBookCatalogService()
{
    private readonly ConsoleLogger _logger = new ();

    public void AdddBook(string title) => _logger.Log($"книга {title} добавлена");

}
