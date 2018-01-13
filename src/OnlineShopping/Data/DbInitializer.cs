using OnlineShopping.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopping.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Games.Any())
            {
                context.AddRange
                (
                    new Game {
                        Name = "Call of Duty WW2",
                        Price = 49.99M, ShortDescription = "Call of Duty: WWII is a first-person shooter video game developed by Sledgehammer Games and published by Activision.",
                        LongDescription = "Call of Duty: WWII is a first-person shooter video game developed by Sledgehammer Games and published by Activision. It is the fourteenth main installment in the Call of Duty series and was released worldwide on November 3, 2017 for Microsoft Windows, PlayStation 4 and Xbox One. It is the first title in the series to be set primarily during World War II since Call of Duty: World at War in 2008.[2] The game is set in the European theatre, and is centered around a squad in the 1st Infantry Division, following their battles on the Western Front, and set mainly in the historical events of Operation Overlord; the multiplayer expands to different fronts not seen in the campaign",
                        Category = Categories["PC"],
                        ImageUrl = "https://docs.google.com/uc?id=1JLZ5FuhcGlMhe145_WRaif5fe_wAzjYn",
                        InStock = true,
                        IsPreferredGame = true,
                        ImageThumbnailUrl = "https://docs.google.com/uc?id=1JLZ5FuhcGlMhe145_WRaif5fe_wAzjYn"
                    },
                    new Game {
                        Name = "Fifa 2018",
                        Price = 45.95M, ShortDescription = "FIFA 18 is a football simulation video game in the FIFA series of video games, developed and published by Electronic Arts",
                        LongDescription = "FIFA 18 is a football simulation video game in the FIFA series of video games, developed and published by Electronic Arts and was released worldwide on 29 September 2017 for Microsoft Windows, PlayStation 3, PlayStation 4, Xbox 360, Xbox One and Nintendo Switch. It is the 25th instalment in the FIFA series. Real Madrid forward Cristiano Ronaldo appears as the cover athlete of the regular edition. Ronaldo appears on the icon edition of the game.",
                        Category = Categories["Console"],
                        ImageUrl = "https://docs.google.com/uc?id=15rydUHgK2XVTPjLzM2ENCmnIMRSAmtnI",
                        InStock = true,
                        IsPreferredGame = true,
                        ImageThumbnailUrl = "https://docs.google.com/uc?id=15rydUHgK2XVTPjLzM2ENCmnIMRSAmtnI"
                    },
                    new Game {
                        Name = "God of War: Ascension ",
                        Price = 40.95M, ShortDescription = "God of War: Ascension is a third-person action-adventure video game developed by Santa Monica Studio and published by Sony Computer Entertainment (SCE)",
                        LongDescription = "God of War: Ascension is a third-person action-adventure video game developed by Santa Monica Studio and published by Sony Computer Entertainment (SCE). The game was first released on March 12, 2013, for the PlayStation 3 (PS3) console. It is the seventh installment in the God of War series and prequel to the entire series. Loosely based on Greek mythology, the game is set in ancient Greece with vengeance as its central motif. The player controls the protagonist Kratos, the former servant of the God of War Ares, who tricked Kratos into killing his wife and daughter. In response to this tragedy, Kratos renounced Ares, breaking his blood oath to the god. Kratos was therefore imprisoned and tortured by the three Furies, guardians of honor and enforcers of punishment. Helped by the oath keeper Orkos, Kratos escapes his imprisonment and confronts the Furies to be completely free of his bond to Ares.",
                        Category = Categories["Console"],
                        ImageUrl = "https://docs.google.com/uc?id=1MqRyh1KYX6JKbdulyQlj4gokQEnOw7Ds",
                        InStock = true,
                        IsPreferredGame = true,
                        ImageThumbnailUrl = "https://docs.google.com/uc?id=1MqRyh1KYX6JKbdulyQlj4gokQEnOw7Ds"
                    },
                    new Game
                    {
                        Name = "Need For Speed Rivals ",
                        Price = 30.75M,
                        ShortDescription = "Need for Speed Rivals is a racing video game developed in a collaboration between Ghost Games and Criterion Games, and published by Electronic Arts.",
                        LongDescription = "Need for Speed Rivals is a racing video game developed in a collaboration between Ghost Games and Criterion Games, and published by Electronic Arts. It is the twentieth installment in the Need for Speed series. The game was released for Microsoft Windows, PlayStation 3 and Xbox 360 on 19 November 2013, and for PlayStation 4 and Xbox One as launch titles in the same month.",
                        Category = Categories["PC"],
                        ImageUrl = "https://docs.google.com/uc?id=1K_dCh72KEJh-yXMavtv2v8T4aV0sCE3h",
                        InStock = true,
                        IsPreferredGame = false,
                        ImageThumbnailUrl = "https://docs.google.com/uc?id=1K_dCh72KEJh-yXMavtv2v8T4aV0sCE3h"
                    },
                    new Game
                    {
                        Name = "Pro Evolution Soccer 2018 ",
                        Price = 40M,
                        ShortDescription = "Pro Evolution Soccer 2018[a] (abbreviated as PES 2018) is a sports video game developed by PES Productions and published by Konami. ",
                        LongDescription = "Pro Evolution Soccer 2018[a] (abbreviated as PES 2018) is a sports video game developed by PES Productions and published by Konami for Microsoft Windows, PlayStation 3, PlayStation 4, Xbox 360 and Xbox One. The game is the 17th installment in the Pro Evolution Soccer series and was released worldwide in September 2017.",
                        Category = Categories["Console"],
                        ImageUrl = "https://docs.google.com/uc?id=1XH_GRPL0tfxlSpeY9IC6XtZ56cyj-gix",
                        InStock = true,
                        IsPreferredGame = false,
                        ImageThumbnailUrl = "https://docs.google.com/uc?id=1XH_GRPL0tfxlSpeY9IC6XtZ56cyj-gix"
                    },
                    new Game
                    {
                        Name = "PlayerUnknown's Battlegrounds ",
                        Price = 30M,
                        ShortDescription = "PlayerUnknown's Battlegrounds (PUBG) is a multiplayer online battle royale game developed and published by PUBG Corporation, a subsidiary of Korean publisher Bluehole.",
                        LongDescription = "PlayerUnknown's Battlegrounds (PUBG) is a multiplayer online battle royale game developed and published by PUBG Corporation, a subsidiary of Korean publisher Bluehole. The game is based on previous mods that were developed by Brendan PlayerUnknown Greene for other games using the 2000 film Battle Royale for inspiration, and expanded into a standalone game under Greene's creative direction. In the game, up to one hundred players parachute onto an island and scavenge for weapons and equipment to kill others while avoiding getting killed themselves.",
                        Category = Categories["PC"],
                        ImageUrl = "https://docs.google.com/uc?id=137OQqo_SAIPyU9ayHhpPmAjS0mvlW7iW",
                        InStock = true,
                        IsPreferredGame = false,
                        ImageThumbnailUrl = "https://docs.google.com/uc?id=137OQqo_SAIPyU9ayHhpPmAjS0mvlW7iW"
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "PC", Description="All PC games" },
                        new Category { CategoryName = "Console", Description="All Console games" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
