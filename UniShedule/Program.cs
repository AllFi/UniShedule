﻿using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Examples.Echo;
using Telegram.Bot.Extensions.Polling;
using UniShedule.Model;
using UniShedule.Telegram;

namespace UniShedule
{
    class Program
    {
        private static TelegramBotClient? Bot;
        static void Main(string[] args)
        {
            //var db = Database.Database.GetInstance();
            //db.SaveLessons(new List<string>() { "А-05-19", "А-13а-19", "А-13б-19", "А-14-19", "А-16-19" });
            //var db = Database.Database.GetInstance();
            //var list = db.GetScheduleAsync("А-05-19").GetAwaiter().GetResult();
            TelegramApi tg = TelegramApi.GetInstance();
            tg.Start();
            Console.ReadKey();
            tg.Stop();
        }
    }
}
