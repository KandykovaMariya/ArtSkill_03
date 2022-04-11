using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ArtSkill_03.Data;
using System;
using System.Linq;

namespace ArtSkill_03.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ArtSkill_03Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ArtSkill_03Context>>()))
            {
                // Look for any movies.
                if (context.IllustrationModel.Any())
                {
                    return;   // DB has been seeded
                }

                context.IllustrationModel.AddRange(
                    new IllustrationModel
                    {
                        Name = "The heavenly devil",
                        shortDesc = "Атмосферный в холодных цветах искуситель",
                        longDesc = "Завораживающе красивый демон со своей историей. " +
                    "Падший ангел, что трепетно относится к хорошим и ярким людям. " +
                    "Постояно носит заколку, подареную ему девочкой, что продала ему душу.",
                        ReleaseDate = DateTime.Parse("2021-10-15"),
                        Category = "Цифровые иллюстрации",
                        //img = " ",
                        img = "/img/демон.jpg",             
                        Price = 7.99M
                    },


                    new IllustrationModel
                    {
                        Name = "The Silent Mermaid",
                        shortDesc = "Русалка озера",
                        longDesc = "Русалка рожденая и живущая в спокойных водах озера. " +
                    "Тихая и уютная жизнь сделали её очень нежной и доброй.",
                        ReleaseDate = DateTime.Parse("2022-1-11"),
                        Category = "Цифровые иллюстрации",
                        //img = " ",
                        img = "/img/Русалка - пухленькая.png",
                        Price = 7.99M
                    },

                    new IllustrationModel
                    {
                        Name = "Bakugo Katsuki-Weizard",
                        shortDesc = "Бакуго кацуки - Вайзард",
                        longDesc = "Бакуго Кацуки вселеной МГА(Моя геройская академия) в образе Вайзрда. " +
                    "Вайзард - это понятие из вселеной Bleach, шинигами с силой монстра-темного духа, Пустого.",
                        ReleaseDate = DateTime.Parse("2022-3-22"),
                        Category = "Цифровые иллюстрации",
                        //img = " ",
                        img = "/img/Бакуго Катцуки (Вайзард).png",
                        Price = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
