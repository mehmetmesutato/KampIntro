﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService dataBaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService> 
            { 
                new SmsLoggerService(), 
                new FileLoggerService(),
                new DatabaseLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

            //List<IKrediManager> krediler = new List<IKrediManager>() 
            //{ 
            //    ihtiyacKrediManager, 
            //    tasitKrediManager 
            //};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
