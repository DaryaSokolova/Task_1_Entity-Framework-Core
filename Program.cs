using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.GetEncoding(1251);

            using (norContext db = new norContext())
            {
                // пересоздаем базу данных
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                db.SaveChanges();

                Direction savelovskoe = new Direction { Name = "Савелевское", Path = "Savelevskoe" };
                Direction kievskoe = new Direction { Name = "Киевское", Path = "Kievskoe" };
                Direction belorusskoe = new Direction { Name = "Белорусское", Path = "Belorusskoe" };

                db.Directions.AddRange(savelovskoe, kievskoe, belorusskoe);
                db.SaveChanges();

                Station s1 = new Station
                {
                    //Id = 1,
                    Name = "Тимирязевская",
                    Distance = 3.0 + " км",
                    Direction = "Savelevskoe",
                    Path = "timiryazevskaya",
                    Text = "Тимиря́зевская — остановочный пункт Савёловского " +
                    "направления МЖД в Москве в 3 км от Савёловского вокзала. ",
                    Views = 5,
                    Comments = 1
                };

                Station s2 = new Station
                {
                    //Id = 2,
                    Name = "Окружная",
                    Distance = 6.4 + " км",
                    Direction = "Savelevskoe",
                    Path = "okrygnaya",
                    Text = "Окружна́я — остановочный пункт Савёловского " +
                    "направления Московской железной дороги в Москве. ",
                    Views = 74,
                    Comments = 32
                };

                Station s3 = new Station
                {
                    //Id = 3,
                    Name = "Дегунино",
                    Distance = 8.3 + " км",
                    Direction = "Savelevskoe",
                    Path = "degunino",
                    Text = "Дегу́нино — остановочный пункт Савёловского направления " +
                    "Московской железной дороги в Москве.",
                    Views = 64,
                    Comments = 2
                };

                Station s4 = new Station
                {
                    //Id = 4,
                    Name = "Бескудниково",
                    Distance = 10.3 + " км",
                    Direction = "Savelevskoe",
                    Path = "beskudnikovo",
                    Text = "Беску́дниково — узловая железнодорожная станция " +
                    "Савёловского направления Московской железной дороги в Москве " +
                    "в 10 км от Савёловского вокзала, станция линии МЦД-1 " +
                    "«Белорусско-Савёловский» Московских центральных диаметров.",
                    Views = 75,
                    Comments = 7
                };

                Station s5 = new Station
                {
                    //Id = 5,
                    Name = "Матвеевское",
                    Distance = 7.2 + " км",
                    Direction = "Kievskoe",
                    Path = "matveevskoe",
                    Text = "Матвеевское (в расписаниях и на указателях на платформе " +
                    "используется название Матвеевская) — остановочный пункт " +
                    "Киевского направления Московской железной дороги.",
                    Views = 64,
                    Comments = 6
                };

                Station s6 = new Station
                {
                    //Id = 6,
                    Name = "Очаково",
                    Distance = 10.6 + " км",
                    Direction = "Kievskoe",
                    Path = "ochakovo",
                    Text = "Оча́ково I — станция Московской железной дороги в городе Москве. " +
                    "Находится в 10 километрах к юго-западу от Киевского вокзала, " +
                    "в районе Очаково-Матвеевское. " +
                    "Последняя станция направления в пределах МКАД.",
                    Views = 536,
                    Comments = 2
                };

                Station s7 = new Station
                {
                    //Id = 7,
                    Name = "Мещерская",
                    Distance = 12.8 + " км",
                    Direction = "Kievskoe",
                    Path = "mezjerskoe",
                    Text = "Мещерская (до 11.10.2010 года — Востряко́во, до 28.02.2020 года — Ско́лково) — " +
                    "остановочный пункт Киевского направления Московской железной дороги в Москве." +
                    " Первая платформа на данном направлении за МКАД.",
                    Views = 64,
                    Comments = 24
                };

                Station s8 = new Station
                {
                    //Id = 8,
                    Name = "Солнечная",
                    Distance = 15.7 + " км",
                    Direction = "Kievskoe",
                    Path = "solnechnaya",
                    Text = "Со́лнечная (до 1965 — Суково) — станция Киевского направления " +
                    "Московской железной дороги в городе Москве. Входит в Московско-Смоленский " +
                    "центр организации работы железнодорожных станций ДЦС-3 Московской " +
                    "дирекции управления движением. По характеру основной работы является грузовой, " +
                    "по объёму выполняемой работы отнесена к 1-му классу.",
                    Views = 65,
                    Comments = 32
                };

                Station s9 = new Station
                {
                    //Id = 9,
                    Name = "Беговая",
                    Distance = 2.0 + " км",
                    Direction = "Belorusskoe",
                    Path = "begovaya",
                    Text = "Бегова́я — остановочный пункт Смоленского (Белорусского) " +
                "направления Московской железной дороги в Москве.",
                    Views = 4793,
                    Comments = 53
                };

                Station s10 = new Station
                {
                    //Id = 10,
                    Name = "Фили",
                    Distance = 6.2 + " км",
                    Direction = "Belorusskoe",
                    Path = "fili",
                    Text = "Фили́ — железнодорожная станция Белорусского (Смоленского) " +
                    "направления Московской железной дороги в Москве, станция линии МЦД-1 " +
                    "«Белорусско-Савёловский».",
                    Views = 432,
                    Comments = 3
                };

                db.Stations.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
                db.SaveChanges();

            //    var stations = (from u in db.Stations
            //                    select u);
            //    foreach (var s in stations)
            //    {
            //        Console.WriteLine(s.Id + " " + s.Name + " " 
            //            + s.Turnstiles + " " + s.Distance + " " + s.Direction);
            //    }

            //    var directions = (from u in db.Directions
            //                    select u);

            //    Console.WriteLine();
            //    foreach (var s in directions)
            //    {
            //        Console.WriteLine(s.Id + " " + s.Name);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("#1");
            //using (norContext db = new norContext())
            //{
            //    var stations = (from u in db.Stations
            //                    join c in db.Directions on u.Direction equals c.Id
            //                    where u.Distance < 5.0
            //                    select new { Name1 = u.Name, Name2 = c.Name }).ToList();

            //    foreach (var u in stations)
            //        Console.WriteLine("{" + u.Name1 + "|" + u.Name2 + "}");
            //}

            //Console.WriteLine("#2");
            //using (norContext db = new norContext())
            //{
            //    //все станции по направлению Савелевское с турникетами
            //    var stations_t = (from u in db.Stations
            //                      join c in db.Directions on u.Direction equals c.Id
            //                      where (c.Id == 1) & (u.Turnstiles == true)
            //                      select new { Name1 = u.Name, Name2 = c.Name }).ToList();

            //    //все станции по направлению Савелевское
            //    var stations = (from u in db.Stations
            //                    join c in db.Directions on u.Direction equals c.Id
            //                    where (c.Id == 1)
            //                    select new { Name1 = u.Name, Name2 = c.Name }).ToList();

            //    double res = 1.0 * stations_t.Count / stations.Count * 100;
            //    Console.WriteLine(res.ToString() + " %");
            //}

            //Console.WriteLine("#3");
            //using (norContext db = new norContext())
            //{
            //    var directions = (from d in db.Directions
            //                      select d);

            //    List<int> id_list = new List<int>();
            //    foreach (var d in directions)
            //    {
            //        id_list.Add(d.Id);
            //    }

            //    foreach (int i in id_list)
            //    {
            //        double res = (from u in db.Stations
            //                      where u.Direction == i
            //                      select (u.Distance)).Max();

            //        var stations = (from u in db.Stations
            //                        join c in db.Directions on u.Direction equals c.Id
            //                        where u.Distance == res
            //                        select new { name_dir = c.Name, name_s = u.Name, dist = res }).ToList();

            //        foreach (var u in stations)
            //            Console.WriteLine("{" + u.name_dir + "|" + u.name_s + " " + u.dist + "}");
            //    }
            //}

            //Console.WriteLine("#4");
            //using (norContext db = new norContext())
            //{
            //    //деление на зоны, каждые 2 км -новая зона,
            //    //будем считать число станций, попавших в нее
            //    for (int i = 2; i < 18; i += 2)
            //    {
            //        int count_stations = (from y in db.Stations
            //                              where y.Distance <= i & y.Distance > i - 2
            //                              select y).Count();
            //        Console.WriteLine("{" + i * 1.0 / 10 + "|" + count_stations + "}");
            //    }

            //}

            //Console.WriteLine("#5");
            //using (norContext db = new norContext())
            //{
            //    var directions = (from d in db.Directions
            //                      select d);

            //    List<int> id_list = new List<int>();
            //    foreach (var d in directions)
            //    {
            //        id_list.Add(d.Id);
            //    }

            //    int id_min = int.MaxValue;
            //    int min = int.MaxValue;
            //    foreach (int i in id_list)
            //    {
            //        int count = (from y in db.Stations
            //                     join c in db.Directions on y.Direction equals c.Id
            //                     where y.Turnstiles == true & c.Id == i
            //                     select c).Count();
            //        if (count < min)
            //        {
            //            min = count;
            //            id_min = i;
            //        }

            //    }

            //    var stations = (from y in db.Stations
            //                    join c in db.Directions on y.Direction equals c.Id
            //                    where y.Turnstiles == false & c.Id == id_min
            //                    select y);

            //    stations = stations.OrderBy(p => p.Distance);

            //    Console.WriteLine("До изменения - список без турникетов");
            //    foreach (var s in stations)
            //    {
            //        Console.WriteLine(s.Name + " " + s.Distance);
            //    }

            //    var first = (from y in stations
            //                 select y).First();

            //    first.Turnstiles = true;
            //    db.SaveChanges();

            //    stations = (from y in db.Stations
            //                join c in db.Directions on y.Direction equals c.Id
            //                where y.Turnstiles == false & c.Id == id_min
            //                select y);

            //    stations = stations.OrderBy(p => p.Distance);

            //    var second = (from y in stations
            //                  select y).First();
            //    second.Turnstiles = true;
            //    db.SaveChanges();

            //    Console.WriteLine();
            //    Console.WriteLine("После изменения - список без турникетов");
            //    foreach (var s in stations)
            //    {
            //        Console.WriteLine(s.Name + " " + s.Distance);
            //    }
            //}

            //Console.WriteLine("#6");
            //using (norContext db = new norContext())
            //{
            //    var directions = (from d in db.Directions
            //                      select d);

            //    List<int> id_list = new List<int>();
            //    foreach (var d in directions)
            //    {
            //        id_list.Add(d.Id);
            //    }

            //    int min_distance = int.MaxValue;
            //    int id_min_distance = int.MaxValue;

            //    foreach (int i in id_list)
            //    {
            //        int count = (int)(from y in db.Stations
            //                          where y.Direction == i
            //                          select y.Distance).Sum();
            //        if (count < min_distance)
            //        {
            //            min_distance = count;
            //            id_min_distance = i;
            //        }
            //    }

            //    var stations = (from y in db.Stations
            //                    where y.Direction == id_min_distance
            //                    select y);

            //    double max_distance = (from y in db.Stations
            //                           where y.Direction == id_min_distance
            //                           select y.Distance).Max();

            //    Console.WriteLine("До изменения");
            //    foreach (var s in stations)
            //    {
            //        Console.WriteLine(s.Name + " " + s.Distance);
            //    }

            //    foreach (var s in stations)
            //    {
            //        if (s.Distance == max_distance)
            //        {
            //            db.Stations.Remove(s);
            //        }
            //    }
            //    db.SaveChanges();

            //    Console.WriteLine();
            //    Console.WriteLine("После изменения");
            //    foreach (var s in stations)
            //    {
            //        Console.WriteLine(s.Name + " " + s.Distance);
            //    }
            }
        }
    }
}
