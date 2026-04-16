


Console.WriteLine("--- Bad Service ---");
var badService = new BadBookCatalogService();
badService.AdddBook("Война и мир"); 
// Мы никак не можем заставить его писать в файл, он "прибит" к консоли внутри себя.


Console.WriteLine("\n--- Good Service (Console) ---");

// 1. Создаем зависимость (логгер для консоли)
ILogger consoleLogger = new ConsoleLogger();
// 2. Внедряем её в сервис через конструктор
var serviceWithConsole = new GoodBookCatalogService(consoleLogger);
serviceWithConsole.AdddBook("1984");


Console.WriteLine("\n--- Good Service (File) ---");

// 1. Создаем другую зависимость (логгер для файла)
ILogger fileLogger = new FileLogger("catalog_logs.txt");
// 2. Внедряем её в тот же класс сервиса
var serviceWithFile = new GoodBookCatalogService(fileLogger);
serviceWithFile.AdddBook("Мастер и Маргарита");

Console.WriteLine("Проверь файл catalog_logs.txt в папке с проектом!");


