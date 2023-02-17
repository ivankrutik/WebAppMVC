using DataLayer.Model;

namespace DataLayer
{
    public static class SampleData
    {
        public static void InitData(EfDbContext context)
        {
            if (!context.Library.Any())
            {
                context.Library.Add(new LibraryEntity
                {
                    Adress = "Ул. Мира д.10",
                    Name = "Библиотека всемирно известная",
                    Owner = "Мировая общественность"
                });

                context.Library.Add(new LibraryEntity
                {
                    Adress = "Ул. Ленина д.2",
                    Name = "Библиотека Ленина",
                    Owner = "Город"
                });


                context.Library.Add(new LibraryEntity
                {
                    Adress = "Ул. Индустриальная д.5",
                    Name = "Библиотека техническая",
                    Owner = "РосГТУ"
                });

                context.SaveChanges();
            }

            if (!context.Category.Any())
            {
                context.Category.Add(new CategoryEntity
                {
                    CategoryName = "Сказки",
                    Description = "Сказки для самых маленьких"
                });

                context.Category.Add(new CategoryEntity
                {
                    CategoryName = "Техническая",
                    Description = "Техническая литература для инженеров"
                });

                context.Category.Add(new CategoryEntity
                {
                    CategoryName = "Приключения",
                    Description = "Приключения для приятного времяпровождения"
                });
                context.SaveChanges();
            }

            if (!context.Book.Any())
            {
                context.Book.Add(new BookEntity
                {
                    Prologue = "Аннотация к книге Искушение генерала драконов. " +
                               "Я высокородная лера Астрид — единственная дочь великого лерда, наследница " +
                               "и желанная невеста для многих. Но это в прошлом. Сейчас же моя жизнь — " +
                               "это вечная дорога, потому как у послушниц богини Яники нет цели, есть лишь путь. " +
                               "Он жестокий и беспринципный генерал армии драконов — Ярвен Шрам. " +
                               "Все, что его заботит — месть и жгучее желание получить богатые земли моего отца. " +
                               "И так уж получилось, что единственный ключ к осуществлению его планов — скромная я. " +
                               "Он думал, взяв меня в плен, решит все свои проблемы? Купился на внешность кроткой прекрасной девы? " +
                               "Наивный дракон. Что же я покажу ему, что такое настоящие трудности? И научу их преодолевать! " +
                               "Не бросать же в беде бедного генерала.",
                    QuantityUnit = 1,
                    Title = "Искушение генерала драконов",
                    UnitPrice = 1000,
                    Library = context.Library.Where(x => x.Name == "Библиотека всемирно известная").FirstOrDefault(),
                    Сategory = context.Category.Where(x => x.CategoryName == "Приключения").FirstOrDefault()
                });

                
                context.SaveChanges();
            }
        }
    }
}
