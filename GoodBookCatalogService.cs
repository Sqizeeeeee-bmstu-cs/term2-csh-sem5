



public class GoodBookCatalogService(ILogger _logger)
{
    public void AdddBook(string title) => _logger.Log($"книга {title} добавлена");
}
