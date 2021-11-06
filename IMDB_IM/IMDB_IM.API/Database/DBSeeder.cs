using IMDB_IM.API.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;

namespace IMDB_IM.API.Database
{
    public class DBSeeder
    {
        public static byte[] ReadFile(string path)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(path);
                long numberBytes = fileInfo.Length;

                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);

                byte[] data = binaryReader.ReadBytes((int)numberBytes);
                return data;
            }
            catch (System.Exception)
            {
                return null;
            }
        }


        public static void InitSeeding(IMDBMistralContext context)
        {
            context.Database.Migrate();

            if (context.Movies.Any())
            {
                return;
            }
            


            Movie theShawShankRedemption = new Movie
            {
                Title = "The Shawshank Redemption",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1994"),
                CoverImage =ReadFile("./Resources/movies/shawshankRedemption.jpg")
            };
            context.Movies.Add(theShawShankRedemption);
            
            Movie theGodfather = new Movie
            {
                Title = "The Godfather",
                Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1978"),
                CoverImage = ReadFile("./Resources/movies/godfather.jpg")

            };
            context.Movies.Add(theGodfather);


            Movie theGodFatherII = new Movie
            {
                Title = "The Godfather part II",
                Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1974"),
                CoverImage = ReadFile("./Resources/movies/godfatherii.jpg")
            };

            context.Movies.Add(theGodFatherII);

            Movie darkKnight = new Movie
            {
                Title = "The Dark Knight",
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/2008"),
                CoverImage = ReadFile("./Resources/movies/darkKnight.jpg")
            };
            context.Movies.Add(darkKnight);



            Movie twelveAngryMen = new Movie
            {
                Title = "12 Angry Men",
                Description = "The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1957"),
                CoverImage = ReadFile("./Resources/movies/twelweAngryMan.jpg")
            };
            context.Movies.Add(twelveAngryMen);


            Movie lotrReturnOfTheKing = new Movie
            {
                Title = "The Shawshank Redemption",
                Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/2003"),
                CoverImage = ReadFile("./Resources/movies/lotrReturnOfTheKing.jpg")
            };
            context.Movies.Add(lotrReturnOfTheKing);


            Movie pulpFiction = new Movie
            {
                Title = "Pulp Fiction",
                Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1995"),
                CoverImage = ReadFile("./Resources/movies/pulpFiction.jpg")
            };

            context.Movies.Add(pulpFiction);


            Movie schindlersList = new Movie
            {
                Title = "Schindler's List",
                Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1993"),
                CoverImage = ReadFile("./Resources/movies/schindlersList.jpg")
            };
            context.Movies.Add(schindlersList);


            Movie Inception = new Movie
            {
                Title = "Inception",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/2010"),
                CoverImage = ReadFile("./Resources/movies/inception.jpg")
            };

            context.Movies.Add(Inception);


            Movie fightClub = new Movie
            {
                Title = "Fight Club",
                Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1999"),
                CoverImage = ReadFile("./Resources/movies/fightClub.jpg")
            };

            context.Movies.Add(fightClub);


            Movie lotrFellowshipOfTheRing = new Movie
            {
                Title = "The Lord of the Rings: The Fellowship of the Ring",
                Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/2001"),
                CoverImage = ReadFile("./Resources/movies/lotrFellowshipOfTheRings.jpg")
            };

            context.Movies.Add(lotrFellowshipOfTheRing);


            Movie forrestGFump = new Movie
            {
                Title = "Forrest Gump",
                Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1994"),
                CoverImage = ReadFile("./Resources/movies/forrestGump.jpg")
            };

            context.Movies.Add(forrestGFump);


            Movie goodBadUgly = new Movie
            {
                Title = "Il buono, il brutto, il cattivo",
                Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1966"),
                CoverImage = ReadFile("./Resources/movies/goodBadUgly.jpg")
            };

            context.Movies.Add(goodBadUgly);


            Movie lotrTwoTowers = new Movie
            {
                Title = "The Lord of the Rings: The Two Towers",
                Description = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/2002"),
                CoverImage = ReadFile("./Resources/movies/lotrTwoTowers.jpg")
            };

            context.Movies.Add(lotrTwoTowers);


            Movie theMatrix = new Movie
            {
                Title = "The Matrix",
                Description = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1999"),
                CoverImage = ReadFile("./Resources/movies/theMatrix.jpg")
            };

            context.Movies.Add(theMatrix);


            Movie goodfellas = new Movie
            {
                Title = "GoodFellas",
                Description = "The story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1990"),
                CoverImage = ReadFile("./Resources/movies/goodfellas.jpg")
            };

            context.Movies.Add(goodfellas);


            Movie starwarsV = new Movie
            {
                Title = "Star Wars: Episode V - The Empire Strikes Back",
                Description = "After the Rebels are brutally overpowered by the Empire on the ice planet Hoth, Luke Skywalker begins Jedi training with Yoda, while his friends are pursued across the galaxy by Darth Vader and bounty hunter Boba Fett.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1980"),
                CoverImage = ReadFile("./Resources/movies/starwarsV.jpg")
            };
            context.Movies.Add(starwarsV);


            Movie oneFlewOver = new Movie
            {
                Title = "One Flew Over the Cuckoo's Nest",
                Description = "A criminal pleads insanity and is admitted to a mental institution, where he rebels against the oppressive nurse and rallies up the scared patients.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1975"),
                CoverImage = ReadFile("./Resources/movies/oneFlewOverCuckoosNest.jpg")
            };
            context.Movies.Add(oneFlewOver);


            Movie parasite = new Movie
            {
                Title = "Gisaengchung",
                Description = "Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/2019"),
                CoverImage = ReadFile("./Resources/movies/parasite.jpg")
            };

            context.Movies.Add(parasite);


            Movie interstellar = new Movie
            {
                Title = "Interstellar",
                Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/2014"),
                CoverImage = ReadFile("./Resources/movies/interstellar.jpg")
            };
            context.Movies.Add(interstellar);


            Movie cityOfGod = new Movie
            {
                Title = "Cidade de Deus",
                Description = "In the slums of Rio, two kids' paths diverge as one struggles to become a photographer and the other a kingpin.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/2002"),
                CoverImage = ReadFile("./Resources/movies/cityOfGod.jpg")
            };
            context.Movies.Add(cityOfGod);


            Movie spiritedAway = new Movie
            {
                Title = "Sen to Chihiro no kamikakushi",
                Description = "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits, and where humans are changed into beasts.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/2001"),
                CoverImage = ReadFile("./Resources/movies/spiritedAway.jpg")
            };

            context.Movies.Add(spiritedAway);


            Movie savingPrivateRyan = new Movie
            {
                Title = "Saving Private Ryan",
                Description = "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper whose brothers have been killed in action.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1998"),
                CoverImage = ReadFile("./Resources/movies/savingPrivateRyan.jpg")
            };

            context.Movies.Add(savingPrivateRyan);


            Movie greenMile = new Movie
            {
                Title = "The Green Mile",
                Description = "The lives of guards on Death Row are affected by one of their charges: a black man accused of child murder and rape, yet who has a mysterious gift.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1999"),
                CoverImage = ReadFile("./Resources/movies/greenMile.jpg")
            };

            context.Movies.Add(greenMile);


            Movie lifeIsBeautiful = new Movie
            {
                Title = "La vita è bella",
                Description = "When an open-minded Jewish waiter and his son become victims of the Holocaust, he uses a perfect mixture of will, humor, and imagination to protect his son from the dangers around their camp.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1997"),
                CoverImage = ReadFile("./Resources/movies/lifeIsBeautiful.jpg")
            };
            context.Movies.Add(lifeIsBeautiful);


            Movie seven = new Movie
            {
                Title = "Se7en",
                Description = "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1995"),
                CoverImage = ReadFile("./Resources/movies/seven.jpg")
            };

            context.Movies.Add(seven);


            Movie silenceOfTheLambs = new Movie
            {
                Title = "The Silence of the Lambs",
                Description = "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1995"),
                CoverImage = ReadFile("./Resources/movies/silenceOfTheLambs.jpg")
            };

            context.Movies.Add(silenceOfTheLambs);


            Movie starWars = new Movie
            {
                Title = "Star Wars",
                Description = "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1977"),
                CoverImage = ReadFile("./Resources/movies/starWars.jpg")
            };

            context.Movies.Add(starWars);


            Movie seppuku = new Movie
            {
                Title = "Sepukku",
                Description = "When a ronin requesting seppuku at a feudal lord's palace is told of the brutal suicide of another ronin who previously visited, he reveals how their pasts are intertwined - and in doing so challenges the clan's integrity.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1962"),
                CoverImage = ReadFile("./Resources/movies/sepukku.jpg")
            };

            context.Movies.Add(seppuku);


            Movie shichinin = new Movie
            {
                Title = "Shichinin no samurai",
                Description = "A poor village under attack by bandits recruits seven unemployed samurai to help them defend themselves.",
                Type = (int)MoviesShowsType.Movies,
                ReleaseDate = Convert.ToDateTime("1/1/1954"),
                CoverImage = ReadFile("./Resources/movies/shichinin.jpg")
            };

            context.Movies.Add(shichinin);
            context.SaveChanges();


            Rating shawshank10 = new Rating { RatingN = 10, FkMovie = theShawShankRedemption };
            context.Ratings.Add(shawshank10);

            Rating godFather10 = new Rating { RatingN = 10, FkMovie = theGodfather };
            context.Ratings.Add(godFather10);

            Rating godFather9 = new Rating { RatingN = 9, FkMovie = theGodfather };
            context.Ratings.Add(godFather9);

            Rating darkK = new Rating { RatingN = 9, FkMovie = darkKnight };
            context.Ratings.Add(darkK);

            Rating godFatherII = new Rating { RatingN = 9, FkMovie = theGodFatherII };
            context.Ratings.Add(godFatherII);


            Rating angryMen = new Rating { RatingN = 9, FkMovie = twelveAngryMen };
            context.Ratings.Add(angryMen);

            Rating lotrK10 = new Rating { RatingN = 10, FkMovie = lotrReturnOfTheKing };
            context.Ratings.Add(lotrK10);

            Rating lotrK10ii = new Rating { RatingN = 10, FkMovie = lotrReturnOfTheKing };
            context.Ratings.Add(lotrK10ii);


            Rating lotrK9 = new Rating { RatingN = 9, FkMovie = lotrReturnOfTheKing };
            context.Ratings.Add(lotrK9);

            Rating lotr8 = new Rating { RatingN = 8, FkMovie = lotrReturnOfTheKing };
            context.Ratings.Add(lotr8);

            Rating pulp10 = new Rating { RatingN = 10, FkMovie = pulpFiction };
            context.Ratings.Add(pulp10);

            Rating pulp10ii = new Rating { RatingN = 10, FkMovie = pulpFiction };
            context.Ratings.Add(pulp10ii);


            Rating pulpK9 = new Rating { RatingN = 9, FkMovie = pulpFiction };
            context.Ratings.Add(pulpK9);

            Rating pulp8 = new Rating { RatingN = 8, FkMovie = pulpFiction };
            context.Ratings.Add(pulp8);

            Rating sList10 = new Rating { RatingN = 10, FkMovie = schindlersList };
            context.Ratings.Add(sList10);

            Rating sList8ii = new Rating { RatingN = 8, FkMovie = schindlersList };
            context.Ratings.Add(sList8ii);

            Rating sList9ii = new Rating { RatingN = 9, FkMovie = schindlersList };
            context.Ratings.Add(sList9ii);

            Rating sList8 = new Rating { RatingN = 8, FkMovie = schindlersList };
            context.Ratings.Add(sList8);

            Rating inception10 = new Rating { RatingN = 10, FkMovie = Inception };
            context.Ratings.Add(inception10);

            Rating inception9 = new Rating { RatingN = 9, FkMovie = Inception };
            context.Ratings.Add(inception9);

            Rating inception8 = new Rating { RatingN = 8, FkMovie = Inception };
            context.Ratings.Add(inception8);

            Rating inception7 = new Rating { RatingN = 7, FkMovie = Inception };
            context.Ratings.Add(inception7);

            Rating fc = new Rating { RatingN = 7, FkMovie = fightClub };
            context.Ratings.Add(fc);

            Rating lotrFR = new Rating { RatingN = 7, FkMovie = lotrFellowshipOfTheRing };
            context.Ratings.Add(lotrFR);

            Rating fg = new Rating { RatingN = 7, FkMovie = forrestGFump };
            context.Ratings.Add(fg);

            Rating gbu = new Rating { RatingN = 6, FkMovie = goodBadUgly };
            context.Ratings.Add(gbu);

            Rating lotrTT = new Rating { RatingN = 6, FkMovie = lotrTwoTowers };
            context.Ratings.Add(lotrTT);

            Rating matrix = new Rating { RatingN = 6, FkMovie = theMatrix };
            context.Ratings.Add(matrix);

            Rating gf = new Rating { RatingN = 5, FkMovie = goodfellas };
            context.Ratings.Add(gf);

            Rating sv5 = new Rating { RatingN = 5, FkMovie = starwarsV };
            context.Ratings.Add(sv5);

            Rating ofoc = new Rating { RatingN = 5, FkMovie = oneFlewOver };
            context.Ratings.Add(ofoc);

            Rating paras = new Rating { RatingN = 4, FkMovie = parasite };
            context.Ratings.Add(paras);

            Rating ist = new Rating { RatingN = 4, FkMovie = interstellar };
            context.Ratings.Add(ist);

            Rating cog = new Rating { RatingN = 4, FkMovie = cityOfGod };
            context.Ratings.Add(cog);

            Rating sa = new Rating { RatingN = 3, FkMovie = spiritedAway };
            context.Ratings.Add(sa);

            Rating spr = new Rating { RatingN = 3, FkMovie = savingPrivateRyan };
            context.Ratings.Add(spr);

            Rating gm = new Rating { RatingN = 3, FkMovie = greenMile };
            context.Ratings.Add(gm);

            Rating lb = new Rating { RatingN = 3, FkMovie = lifeIsBeautiful };
            context.Ratings.Add(lb);

            Rating s7 = new Rating { RatingN = 2, FkMovie = seven };
            context.Ratings.Add(s7);

            Rating sl = new Rating { RatingN = 2, FkMovie = silenceOfTheLambs };
            context.Ratings.Add(sl);

            Rating sw = new Rating { RatingN = 2, FkMovie = starWars };
            context.Ratings.Add(sw);

            Rating sp = new Rating { RatingN = 1, FkMovie = seppuku };
            context.Ratings.Add(sp);

            Rating sm = new Rating { RatingN = 1, FkMovie = shichinin };
            context.Ratings.Add(sm);
            context.SaveChanges();

        }
    }
}
