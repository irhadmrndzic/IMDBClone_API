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
                CoverImage = ReadFile("./Resources/movies/shawshankRedemption.jpg")
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
                Title = "GoodFellas Morgan",
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


            Rating shawshank10 = new Rating { RatingN = 5, FkMovie = theShawShankRedemption };
            context.Ratings.Add(shawshank10);

            Rating godFather10 = new Rating { RatingN = 5, FkMovie = theGodfather };
            context.Ratings.Add(godFather10);

            Rating godFather9 = new Rating { RatingN = 4, FkMovie = theGodfather };
            context.Ratings.Add(godFather9);

            Rating darkK = new Rating { RatingN = 2, FkMovie = darkKnight };
            context.Ratings.Add(darkK);

            Rating godFatherII = new Rating { RatingN = 3, FkMovie = theGodFatherII };
            context.Ratings.Add(godFatherII);


            Rating angryMen = new Rating { RatingN = 5, FkMovie = twelveAngryMen };
            context.Ratings.Add(angryMen);

            Rating lotrK10 = new Rating { RatingN = 2, FkMovie = lotrReturnOfTheKing };
            context.Ratings.Add(lotrK10);

            Rating lotrK10ii = new Rating { RatingN = 3, FkMovie = lotrReturnOfTheKing };
            context.Ratings.Add(lotrK10ii);


            Rating lotrK9 = new Rating { RatingN = 5, FkMovie = lotrReturnOfTheKing };
            context.Ratings.Add(lotrK9);

            Rating lotr8 = new Rating { RatingN = 4, FkMovie = lotrReturnOfTheKing };
            context.Ratings.Add(lotr8);

            Rating pulp10 = new Rating { RatingN = 3, FkMovie = pulpFiction };
            context.Ratings.Add(pulp10);

            Rating pulp10ii = new Rating { RatingN = 1, FkMovie = pulpFiction };
            context.Ratings.Add(pulp10ii);


            Rating pulpK9 = new Rating { RatingN = 4, FkMovie = pulpFiction };
            context.Ratings.Add(pulpK9);

            Rating pulp8 = new Rating { RatingN = 5, FkMovie = pulpFiction };
            context.Ratings.Add(pulp8);

            Rating sList10 = new Rating { RatingN = 2, FkMovie = schindlersList };
            context.Ratings.Add(sList10);

            Rating sList8ii = new Rating { RatingN = 3, FkMovie = schindlersList };
            context.Ratings.Add(sList8ii);

            Rating sList9ii = new Rating { RatingN = 4, FkMovie = schindlersList };
            context.Ratings.Add(sList9ii);

            Rating sList8 = new Rating { RatingN = 1, FkMovie = schindlersList };
            context.Ratings.Add(sList8);

            Rating inception10 = new Rating { RatingN = 1, FkMovie = Inception };
            context.Ratings.Add(inception10);

            Rating inception9 = new Rating { RatingN = 2, FkMovie = Inception };
            context.Ratings.Add(inception9);

            Rating inception8 = new Rating { RatingN = 4, FkMovie = Inception };
            context.Ratings.Add(inception8);

            Rating inception7 = new Rating { RatingN = 2, FkMovie = Inception };
            context.Ratings.Add(inception7);

            Rating fc = new Rating { RatingN = 3, FkMovie = fightClub };
            context.Ratings.Add(fc);

            Rating lotrFR = new Rating { RatingN = 2, FkMovie = lotrFellowshipOfTheRing };
            context.Ratings.Add(lotrFR);

            Rating fg = new Rating { RatingN = 4, FkMovie = forrestGFump };
            context.Ratings.Add(fg);

            Rating gbu = new Rating { RatingN = 5, FkMovie = goodBadUgly };
            context.Ratings.Add(gbu);

            Rating lotrTT = new Rating { RatingN = 4, FkMovie = lotrTwoTowers };
            context.Ratings.Add(lotrTT);

            Rating matrix = new Rating { RatingN = 1, FkMovie = theMatrix };
            context.Ratings.Add(matrix);

            Rating gf = new Rating { RatingN = 2, FkMovie = goodfellas };
            context.Ratings.Add(gf);

            Rating sv5 = new Rating { RatingN = 4, FkMovie = starwarsV };
            context.Ratings.Add(sv5);

            Rating ofoc = new Rating { RatingN = 4, FkMovie = oneFlewOver };
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






            Movie breakingBad = new Movie
            {
                Title = "Breaking Bad",
                Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2008"),
                CoverImage = ReadFile("./Resources/shows/breakingbad.jpg")
            };

            context.Movies.Add(breakingBad);

            Movie got = new Movie
            {
                Title = "Game Of Thrones",
                Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2011"),
                CoverImage = ReadFile("./Resources/shows/got.jpg")
            };

            context.Movies.Add(got);

            Movie mandalorian = new Movie
            {
                Title = "The Mandalorian",
                Description = "The travels of a lone bounty hunter in the outer reaches of the galaxy, far from the authority of the New Republic.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2019"),
                CoverImage = ReadFile("./Resources/shows/mandalorian.jpg")
            };

            context.Movies.Add(mandalorian);

            Movie friends = new Movie
            {
                Title = "Friends",
                Description = "Follows the personal and professional lives of six twenty to thirty-something-year-old friends living in Manhattan.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/1994"),
                CoverImage = ReadFile("./Resources/shows/friends.jpg")
            };

            context.Movies.Add(friends);

            Movie sopranos = new Movie
            {
                Title = "The Sopranos",
                Description = "New Jersey mob boss Tony Soprano deals with personal and professional issues in his home and business life that affect his mental state, leading him to seek professional psychiatric counseling.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/1999"),
                CoverImage = ReadFile("./Resources/shows/sopranos.jpg")
            };

            context.Movies.Add(sopranos);

            Movie wonderYears = new Movie
            {
                Title = "The Wonder Years",
                Description = "Kevin Arnold recalls growing up during the late 60s and early 70s; the turbulent social times make the transition from child to adult unusually interesting.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/1988"),
                CoverImage = ReadFile("./Resources/shows/wonderYears.jpg")
            };

            context.Movies.Add(wonderYears);


            Movie seinfeld = new Movie
            {
                Title = "Seinfeld",
                Description = "The continuing misadventures of neurotic New York City stand-up comedian Jerry Seinfeld and his equally neurotic New York City friends.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/1989"),
                CoverImage = ReadFile("./Resources/shows/seinfeld.jpg")
            };

            context.Movies.Add(seinfeld);

            Movie houseOfCards = new Movie
            {
                Title = "House of Cards",
                Description = "A Congressman works with his equally conniving wife to exact revenge on the people who betrayed him.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2013"),
                CoverImage = ReadFile("./Resources/shows/houseOfCards.jpg")
            };

            context.Movies.Add(houseOfCards);

            Movie lost = new Movie
            {
                Title = "Breaking bad",
                Description = "The survivors of a plane crash are forced to work together in order to survive on a seemingly deserted tropical island.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2004"),
                CoverImage = ReadFile("./Resources/shows/lost.jpg")
            };

            context.Movies.Add(lost);

            Movie westworld = new Movie
            {
                Title = "Westworld",
                Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2016"),
                CoverImage = ReadFile("./Resources/shows/westworld.jpg")
            };

            context.Movies.Add(westworld);

            Movie strangerThings = new Movie
            {
                Title = "Stranger Things",
                Description = "When a young boy disappears, his mother, a police chief and his friends must confront terrifying supernatural forces in order to get him back.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2016"),
                CoverImage = ReadFile("./Resources/shows/strangerthinfs.jpg")
            };

            context.Movies.Add(strangerThings);

            Movie xFiles = new Movie
            {
                Title = "The X Files",
                Description = "Two F.B.I. Agents, Fox Mulder the believer and Dana Scully the skeptic, investigate the strange and unexplained, while hidden forces work to impede their efforts.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/1993"),
                CoverImage = ReadFile("./Resources/shows/xfiles.jpg")
            };

            context.Movies.Add(xFiles);

            Movie chernobyl = new Movie
            {
                Title = "Chernobyl",
                Description = "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2019"),
                CoverImage = ReadFile("./Resources/shows/chernobzl.jpg")
            };

            context.Movies.Add(chernobyl);

            Movie saul = new Movie
            {
                Title = "Better Call Saul",
                Description = "The trials and tribulations of criminal lawyer Jimmy McGill in the time before he established his strip-mall law office in Albuquerque, New Mexico.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2015"),
                CoverImage = ReadFile("./Resources/shows/betterCallSaul.jpg")
            };

            context.Movies.Add(saul);

            Movie narcos = new Movie
            {
                Title = "Narcos",
                Description = "A chronicled look at the criminal exploits of Colombian drug lord Pablo Escobar, as well as the many other drug kingpins who plagued the country through the years.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2015"),
                CoverImage = ReadFile("./Resources/shows/narcos.jpg")
            };

            context.Movies.Add(narcos);

            Movie familyGuy = new Movie
            {
                Title = "Family Guy",
                Description = "In a wacky Rhode Island town, a dysfunctional family strive to cope with everyday life as they are thrown from one crazy scenario to another.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/1999"),
                CoverImage = ReadFile("./Resources/shows/familyGuy.jpg")
            };

            context.Movies.Add(familyGuy);

            Movie par = new Movie
            {
                Title = "Parks and Recreation ",
                Description = "The absurd antics of an Indiana town's public officials as they pursue sundry projects to make their city a better place.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2009"),
                CoverImage = ReadFile("./Resources/shows/par.jpg")
            };

            context.Movies.Add(par);

            Movie simpsons = new Movie
            {
                Title = "The Simpsons",
                Description = "The satiric adventures of a working-class family in the misfit city of Springfield.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/1989"),
                CoverImage = ReadFile("./Resources/shows/simpsons.jpg")
            };
            context.Movies.Add(simpsons);


            Movie wire = new Movie
            {
                Title = "The Wire",
                Description = "The Baltimore drug scene, as seen through the eyes of drug dealers and law enforcement.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2002"),
                CoverImage = ReadFile("./Resources/shows/theWire.jpg")
            };

            context.Movies.Add(wire);

            Movie rome = new Movie
            {
                Title = "The Rome",
                Description = "A down-to-earth account of the lives of both illustrious and ordinary Romans set in the last days of the Roman Republic.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2005"),
                CoverImage = ReadFile("./Resources/shows/rome.jpg")
            };
            context.Movies.Add(rome);

            Movie ram = new Movie
            {
                Title = "Rick And Morty",
                Description = "An animated series that follows the exploits of a super scientist and his not-so-bright grandson.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2013"),
                CoverImage = ReadFile("./Resources/shows/rickAndMorty.jpg")
            };
            context.Movies.Add(ram);

            Movie homeland = new Movie
            {
                Title = "Homeland",
                Description = "A bipolar CIA operative becomes convinced a prisoner of war has been turned by al-Qaeda and is planning to carry out a terrorist attack on American soil.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2011"),
                CoverImage = ReadFile("./Resources/shows/homeland.jpg")
            };
            context.Movies.Add(homeland);

            Movie bob = new Movie
            {
                Title = "Band of Brothers",
                Description = "The story of Easy Company of the U.S. Army 101st Airborne Division and their mission in World War II Europe, from Operation Overlord to V-J Day.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2001"),
                CoverImage = ReadFile("./Resources/shows/bandOfBrothers.jpg")
            };
            context.Movies.Add(bob);

            Movie vikings = new Movie
            {
                Title = "Vikings",
                Description = "Vikings transports us to the brutal and mysterious world of Ragnar Lothbrok, a Viking warrior and farmer who yearns to explore - and raid - the distant shores across the ocean.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2013"),
                CoverImage = ReadFile("./Resources/shows/vikings.jpg")
            };
            context.Movies.Add(vikings);

            Movie boys = new Movie
            {
                Title = "The Boys",
                Description = "A group of vigilantes set out to take down corrupt superheroes who abuse their superpowers.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2019"),
                CoverImage = ReadFile("./Resources/shows/theBoys.jpg")
            };
            context.Movies.Add(boys);


            Movie gp = new Movie
            {
                Title = "The Good Place",
                Description = "Four people and their otherworldly frienemy struggle in the afterlife to define what it means to be good.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2016"),
                CoverImage = ReadFile("./Resources/shows/goodPlace.jpg")
            };
            context.Movies.Add(gp);


            Movie twentyFour = new Movie
            {
                Title = "24",
                Description = "Jack Bauer races against the clock to subvert terrorist plots and save his nation from ultimate disaste",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2001"),
                CoverImage = ReadFile("./Resources/shows/twentyFour.jpg")
            };
            context.Movies.Add(twentyFour);


            Movie twoAndHalfMen = new Movie
            {
                Title = "Two and a Half Men",
                Description = "A hedonistic jingle writer's free-wheeling life comes to an abrupt halt when his brother and 10-year-old nephew move into his beach-front house.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2003"),
                CoverImage = ReadFile("./Resources/shows/twoAndHalfMen.jpg")
            };
            context.Movies.Add(twoAndHalfMen);


            Movie xMen = new Movie
            {
                Title = "X-Men",
                Description = "A team of mutant superheroes fight for justice and human acceptance in the Marvel Comics universe.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/1992"),
                CoverImage = ReadFile("./Resources/shows/xMen.jpg")
            };
            context.Movies.Add(xMen);

            Movie legion = new Movie
            {
                Title = "Legion",
                Description = "David Haller is a troubled young man diagnosed as schizophrenic, but after a strange encounter, he discovers special powers that will change his life forever.",
                Type = (int)MoviesShowsType.Shows,
                ReleaseDate = Convert.ToDateTime("1/1/2017"),
                CoverImage = ReadFile("./Resources/shows/legion.jpg")
            };
            context.Movies.Add(legion);

            context.SaveChanges();

            Rating bb = new Rating { RatingN = 5, FkMovie = breakingBad };
            context.Ratings.Add(bb);

            Rating gt = new Rating { RatingN = 5, FkMovie = got };
            context.Ratings.Add(gt);

            Rating ml = new Rating { RatingN = 4, FkMovie = mandalorian };
            context.Ratings.Add(ml);

            Rating fr = new Rating { RatingN = 2, FkMovie = friends };
            context.Ratings.Add(fr);

            Rating fr2 = new Rating { RatingN = 4, FkMovie = friends };
            context.Ratings.Add(fr2);

            Rating wy = new Rating { RatingN = 5, FkMovie = wonderYears };
            context.Ratings.Add(wy);

            Rating sf = new Rating { RatingN = 2, FkMovie = seinfeld };
            context.Ratings.Add(sf);

            Rating hc = new Rating { RatingN = 3, FkMovie = houseOfCards };
            context.Ratings.Add(hc);

            Rating lt = new Rating { RatingN = 5, FkMovie = lost };
            context.Ratings.Add(lt);

            Rating ww = new Rating { RatingN = 4, FkMovie = westworld };
            context.Ratings.Add(ww);

            Rating sth = new Rating { RatingN = 3, FkMovie = strangerThings };
            context.Ratings.Add(sth);

            Rating xf = new Rating { RatingN = 1, FkMovie = xFiles };
            context.Ratings.Add(xf);

            Rating cb = new Rating { RatingN = 4, FkMovie = chernobyl };
            context.Ratings.Add(cb);

            Rating bcs = new Rating { RatingN = 5, FkMovie = saul };
            context.Ratings.Add(bcs);

            Rating nrcs = new Rating { RatingN = 2, FkMovie = narcos };
            context.Ratings.Add(nrcs);

            Rating fag = new Rating { RatingN = 3, FkMovie = familyGuy };
            context.Ratings.Add(fag);

            Rating parc = new Rating { RatingN = 4, FkMovie = par };
            context.Ratings.Add(parc);

            Rating smp = new Rating { RatingN = 1, FkMovie = simpsons };
            context.Ratings.Add(smp);

            Rating wr = new Rating { RatingN = 1, FkMovie = wire };
            context.Ratings.Add(wr);

            Rating rm = new Rating { RatingN = 2, FkMovie = rome };
            context.Ratings.Add(rm);

            Rating ramo = new Rating { RatingN = 4, FkMovie = ram };
            context.Ratings.Add(ramo);

            Rating hl = new Rating { RatingN = 2, FkMovie = homeland };
            context.Ratings.Add(hl);

            Rating ban = new Rating { RatingN = 3, FkMovie = bob };
            context.Ratings.Add(ban);

            Rating vk = new Rating { RatingN = 2, FkMovie = vikings };
            context.Ratings.Add(vk);

            Rating bys = new Rating { RatingN = 4, FkMovie = boys };
            context.Ratings.Add(bys);

            Rating gpl = new Rating { RatingN = 5, FkMovie = gp };
            context.Ratings.Add(gpl);

            Rating tw = new Rating { RatingN = 4, FkMovie = twentyFour };
            context.Ratings.Add(tw);

            Rating twa = new Rating { RatingN = 1, FkMovie = twoAndHalfMen };
            context.Ratings.Add(twa);

            Rating xm = new Rating { RatingN = 2, FkMovie = xMen };
            context.Ratings.Add(xm);

            Rating lg = new Rating { RatingN = 4, FkMovie = legion };
            context.Ratings.Add(lg);

            context.SaveChanges();

            Actor robertoBenigni = new Actor
            {
                FirstName = "Roberto",
                LastName = "Benigni"
            };
            context.Actors.Add(robertoBenigni);

            Actor kevinSpacey = new Actor
            {
                FirstName = "Kevin",
                LastName = "Spacey"
            };
            context.Actors.Add(kevinSpacey);

            Actor jodieFoster = new Actor
            {
                FirstName = "Jodie",
                LastName = "Foster"
            };
            context.Actors.Add(jodieFoster);

            Actor anthonyHopkins = new Actor
            {
                FirstName = "Anthony",
                LastName = "Hopkins"
            };
            context.Actors.Add(anthonyHopkins);

            Actor markHamill = new Actor
            {
                FirstName = "Mark",
                LastName = "Hamill"
            };
            context.Actors.Add(markHamill);

            Actor tomHanks = new Actor
            {
                FirstName = "Tom",
                LastName = "Hanks"
            };
            context.Actors.Add(tomHanks);

            Actor morganFreeman = new Actor
            {
                FirstName = "Morgan",
                LastName = "Freeman"
            };
            context.Actors.Add(morganFreeman);

            Actor bobGunton = new Actor
            {
                FirstName = "Bob",
                LastName = "Gunton"
            };
            context.Actors.Add(bobGunton);

  

            Actor marlonBrando = new Actor
            {
                FirstName = "Marlon",
                LastName = "Brando"
            };
            context.Actors.Add(marlonBrando);

            Actor alPacino = new Actor
            {
                FirstName = "Al",
                LastName = "Pacino"
            };
            context.Actors.Add(alPacino);




            Actor cbale = new Actor
            {
                FirstName = "Christian",
                LastName = "Bale"
            };
            context.Actors.Add(cbale);

            Actor heathLeadger = new Actor
            {
                FirstName = "Heath",
                LastName = "Ledger"
            };
            context.Actors.Add(heathLeadger);




            Actor deniro = new Actor
            {
                FirstName = "Robert",
                LastName = "De Niro"
            };
            context.Actors.Add(deniro);



            Actor henryFonda = new Actor
            {
                FirstName = "Henry",
                LastName = "Fonda"
            };
            context.Actors.Add(henryFonda);

            Actor martinBalsam = new Actor
            {
                FirstName = "Martin",
                LastName = "Balsam"
            };
            context.Actors.Add(martinBalsam);



            Actor elijahWood = new Actor
            {
                FirstName = "Elijah",
                LastName = "Wood"
            };
            context.Actors.Add(elijahWood);

            Actor viggoMortessen = new Actor
            {
                FirstName = "Viggo",
                LastName = "Mortessen"
            };
            context.Actors.Add(viggoMortessen);



            Actor travolta = new Actor
            {
                FirstName = "John",
                LastName = "Travolta"
            };
            context.Actors.Add(travolta);

            Actor uma = new Actor
            {
                FirstName = "Uma",
                LastName = "Thurman"
            };
            context.Actors.Add(uma);



            Actor liamNesson = new Actor
            {
                FirstName = "Liam",
                LastName = "Neeson"
            };
            context.Actors.Add(liamNesson);

            Actor ralph = new Actor
            {
                FirstName = "Ralph",
                LastName = "Fiennes"
            };
            context.Actors.Add(ralph);


            Actor leonardoDiCaprio = new Actor
            {
                FirstName = "Leonardo",
                LastName = "DiCaprio"
            };
            context.Actors.Add(leonardoDiCaprio);

            Actor elliotPage = new Actor
            {
                FirstName = "Elliot",
                LastName = "Page"
            };
            context.Actors.Add(leonardoDiCaprio);

            Actor bradPitt = new Actor
            {
                FirstName = "Brad",
                LastName = "Pitt"
            };
            context.Actors.Add(bradPitt);

            Actor edwardNorton = new Actor
            {
                FirstName = "Edward",
                LastName = "Norton"
            };
            context.Actors.Add(edwardNorton);

            context.SaveChanges();

            MoviesActor inceptionAc1 = new MoviesActor
            {
                FkMovie = Inception,
                FkActor = leonardoDiCaprio
            };
            context.MoviesActors.Add(inceptionAc1);

            MoviesActor inceptionAc2 = new MoviesActor
            {
                FkMovie = Inception,
                FkActor = elliotPage
            };
            context.MoviesActors.Add(inceptionAc2);



            MoviesActor lotrac1 = new MoviesActor
            {
                FkMovie = lotrReturnOfTheKing,
                FkActor = elijahWood
            };
            context.MoviesActors.Add(lotrac1);

            MoviesActor lotrac2 = new MoviesActor
            {
                FkMovie = lotrReturnOfTheKing,
                FkActor = viggoMortessen
            };
            context.MoviesActors.Add(lotrac2);

            MoviesActor fc1 = new MoviesActor
            {
                FkMovie = fightClub,
                FkActor = edwardNorton
            };
            context.MoviesActors.Add(fc1);

            MoviesActor fc2 = new MoviesActor
            {
                FkMovie = fightClub,
                FkActor = bradPitt
            };
            context.MoviesActors.Add(fc2);


            MoviesActor lotrf1 = new MoviesActor
            {
                FkMovie = lotrFellowshipOfTheRing,
                FkActor = edwardNorton
            };
            context.MoviesActors.Add(lotrf1);

            MoviesActor lotrf2 = new MoviesActor
            {
                FkMovie = lotrFellowshipOfTheRing,
                FkActor = ralph
            };
            context.MoviesActors.Add(lotrf2);


            MoviesActor sListaAc1 = new MoviesActor
            {
                FkMovie = schindlersList,
                FkActor = liamNesson
            };
            context.MoviesActors.Add(sListaAc1);

            MoviesActor sListAc2 = new MoviesActor
            {
                FkMovie = schindlersList,
                FkActor = ralph
            };
            context.MoviesActors.Add(sListAc2);

            MoviesActor gf1 = new MoviesActor
            {
                FkMovie = theGodfather,
                FkActor = marlonBrando
            };
            context.MoviesActors.Add(gf1);

            MoviesActor gf2 = new MoviesActor
            {
                FkMovie = theGodfather,
                FkActor = alPacino
            };
            context.MoviesActors.Add(gf2);

            MoviesActor dka = new MoviesActor
            {
                FkMovie = darkKnight,
                FkActor = cbale
            };
            context.MoviesActors.Add(dka);

            MoviesActor pf1 = new MoviesActor
            {
                FkMovie = pulpFiction,
                FkActor = travolta
            };
            context.MoviesActors.Add(pf1);

            MoviesActor pf2 = new MoviesActor
            {
                FkMovie = pulpFiction,
                FkActor = uma
            };
            context.MoviesActors.Add(pf2);


            MoviesActor dka2 = new MoviesActor
            {
                FkMovie = darkKnight,
                FkActor = heathLeadger
            };
            context.MoviesActors.Add(dka2);

            MoviesActor forrestAc1 = new MoviesActor
            {
                FkMovie = forrestGFump,
                FkActor = alPacino
            };
            context.MoviesActors.Add(forrestAc1);

            MoviesActor forrestAc2 = new MoviesActor
            {
                FkMovie = forrestGFump,
                FkActor = cbale
            };
            context.MoviesActors.Add(forrestAc2);


            MoviesActor gbac1 = new MoviesActor
            {
                FkMovie = goodBadUgly,
                FkActor = viggoMortessen
            };
            context.MoviesActors.Add(gbac1);

            MoviesActor gbac2 = new MoviesActor
            {
                FkMovie = goodBadUgly,
                FkActor = elliotPage
            };
            context.MoviesActors.Add(gbac2);

            MoviesActor am1 = new MoviesActor
            {
                FkMovie = twelveAngryMen,
                FkActor = henryFonda
            };
            context.MoviesActors.Add(am1);

            MoviesActor am2 = new MoviesActor
            {
                FkMovie = twelveAngryMen,
                FkActor = martinBalsam
            };
            context.MoviesActors.Add(am2);


            MoviesActor mtr1 = new MoviesActor
            {
                FkMovie = lotrTwoTowers,
                FkActor = viggoMortessen
            };
            context.MoviesActors.Add(mtr1);

            MoviesActor mtr2 = new MoviesActor
            {
                FkMovie = lotrTwoTowers,
                FkActor = elijahWood
            };
            context.MoviesActors.Add(mtr2);


            MoviesActor lottw1 = new MoviesActor
            {
                FkMovie = theMatrix,
                FkActor = uma
            };
            context.MoviesActors.Add(lottw1);

            MoviesActor lottw2 = new MoviesActor
            {
                FkMovie = theMatrix,
                FkActor = uma
            };
            context.MoviesActors.Add(lottw2);


            MoviesActor gfac1 = new MoviesActor
            {
                FkMovie = goodfellas,
                FkActor = deniro
            };
            context.MoviesActors.Add(gfac1);

            MoviesActor gfac2 = new MoviesActor
            {
                FkMovie = goodfellas,
                FkActor = heathLeadger
            };
            context.MoviesActors.Add(gfac2);


            MoviesActor swac1 = new MoviesActor
            {
                FkMovie = starWars,
                FkActor = deniro
            };
            context.MoviesActors.Add(swac1);

            MoviesActor swac2 = new MoviesActor
            {
                FkMovie = starWars,
                FkActor = liamNesson
            };
            context.MoviesActors.Add(swac2);


            MoviesActor ofAc1 = new MoviesActor
            {
                FkMovie = oneFlewOver,
                FkActor = travolta
            };
            context.MoviesActors.Add(ofAc1);

            MoviesActor ofAc2 = new MoviesActor
            {
                FkMovie = oneFlewOver,
                FkActor = elijahWood
            };
            context.MoviesActors.Add(ofAc2);


            MoviesActor parAc1 = new MoviesActor
            {
                FkMovie = parasite,
                FkActor = edwardNorton
            };
            context.MoviesActors.Add(parAc1);

            MoviesActor parAc2 = new MoviesActor
            {
                FkMovie = parasite,
                FkActor = elijahWood
            };
            context.MoviesActors.Add(parAc2);


            MoviesActor interstellarAc1 = new MoviesActor
            {
                FkMovie = interstellar,
                FkActor = deniro
            };
            context.MoviesActors.Add(interstellarAc1);

            MoviesActor interstellarAc2 = new MoviesActor
            {
                FkMovie = interstellar,
                FkActor = alPacino
            };
            context.MoviesActors.Add(interstellarAc2);


            MoviesActor cogAc1 = new MoviesActor
            {
                FkMovie = cityOfGod,
                FkActor = cbale
            };
            context.MoviesActors.Add(cogAc1);

            MoviesActor cogAc2 = new MoviesActor
            {
                FkMovie = cityOfGod,
                FkActor = leonardoDiCaprio
            };
            context.MoviesActors.Add(cogAc2);


            MoviesActor saAc1 = new MoviesActor
            {
                FkMovie = spiritedAway,
                FkActor = elijahWood
            };
            context.MoviesActors.Add(saAc1);

            MoviesActor saAc2 = new MoviesActor
            {
                FkMovie = parasite,
                FkActor = elliotPage
            };
            context.MoviesActors.Add(saAc2);


            MoviesActor sprAc1 = new MoviesActor
            {
                FkMovie = savingPrivateRyan,
                FkActor = leonardoDiCaprio
            };
            context.MoviesActors.Add(sprAc1);

            MoviesActor sprAc2 = new MoviesActor
            {
                FkMovie = savingPrivateRyan,
                FkActor = ralph
            };
            context.MoviesActors.Add(sprAc2);


            MoviesActor gmAc1 = new MoviesActor
            {
                FkMovie = greenMile,
                FkActor = uma
            };
            context.MoviesActors.Add(gmAc1);

            MoviesActor gmAc2 = new MoviesActor
            {
                FkMovie = greenMile,
                FkActor = bradPitt
            };
            context.MoviesActors.Add(gmAc2);


            MoviesActor libAc1 = new MoviesActor
            {
                FkMovie = lifeIsBeautiful,
                FkActor = tomHanks
            };
            context.MoviesActors.Add(libAc1);

            MoviesActor libAc2 = new MoviesActor
            {
                FkMovie = lifeIsBeautiful,
                FkActor = robertoBenigni
            };
            context.MoviesActors.Add(libAc2);


            MoviesActor sevenAc1 = new MoviesActor
            {
                FkMovie = seven,
                FkActor = morganFreeman
            };
            context.MoviesActors.Add(sevenAc1);

            MoviesActor sevenAc2 = new MoviesActor
            {
                FkMovie = seven,
                FkActor = bradPitt
            };
            context.MoviesActors.Add(sevenAc2);


            MoviesActor silenceAc1 = new MoviesActor
            {
                FkMovie = silenceOfTheLambs,
                FkActor = jodieFoster
            };
            context.MoviesActors.Add(silenceAc1);

            MoviesActor silenceAc2 = new MoviesActor
            {
                FkMovie = silenceOfTheLambs,
                FkActor = anthonyHopkins
            };
            context.MoviesActors.Add(silenceAc2);


            MoviesActor sw2Ac1 = new MoviesActor
            {
                FkMovie = starwarsV,
                FkActor = markHamill
            };
            context.MoviesActors.Add(sw2Ac1);

            MoviesActor sw2Ac2 = new MoviesActor
            {
                FkMovie = silenceOfTheLambs,
                FkActor = kevinSpacey
            };
            context.MoviesActors.Add(sw2Ac2);


            MoviesActor seppukkuAc1 = new MoviesActor
            {
                FkMovie = seppuku,
                FkActor = tomHanks
            };
            context.MoviesActors.Add(seppukkuAc1);

            MoviesActor seppukkuAc2 = new MoviesActor
            {
                FkMovie = seppuku,
                FkActor = kevinSpacey
            };
            context.MoviesActors.Add(seppukkuAc2);


            MoviesActor samuraiAc1 = new MoviesActor
            {
                FkMovie = shichinin,
                FkActor = leonardoDiCaprio
            };
            context.MoviesActors.Add(samuraiAc1);

            MoviesActor samuraiAc2 = new MoviesActor
            {
                FkMovie = shichinin,
                FkActor = ralph
            };
            context.MoviesActors.Add(samuraiAc2);

            MoviesActor shawshankActor1 = new MoviesActor
            {
                FkMovie = theShawShankRedemption,
                FkActor = morganFreeman
            };
            context.MoviesActors.Add(shawshankActor1);

            MoviesActor shawshankAc2 = new MoviesActor
            {
                FkMovie = theShawShankRedemption,
                FkActor = bobGunton
            };
            context.MoviesActors.Add(shawshankAc2);


            MoviesActor goodFatherActorII = new MoviesActor
            {
                FkMovie = theGodFatherII,
                FkActor = alPacino
            };
            context.MoviesActors.Add(goodFatherActorII);

            MoviesActor goodFatherActorIIii = new MoviesActor
            {
                FkMovie = theGodFatherII,
                FkActor = deniro
            };
            context.MoviesActors.Add(goodFatherActorIIii);

            context.SaveChanges();

        }
    }
}
