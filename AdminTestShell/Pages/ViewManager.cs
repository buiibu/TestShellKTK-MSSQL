﻿using AdminTestShell.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AdminTestShell.Pages
{
    public class ViewManager
    {
        private static Database.user9Entities database;

        private static Administration administration;
        private static Admins admins;
        private static Heads heads;
        private static Teachers teachers;
        private static Authorization authorization;

        private static Database.user9Entities Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database.user9Entities();
                    if (database.Database.Exists() == false)
                    {
                        MessageBox.Show("Подключение к базе данных не было выполнено. Приложение будет завершено.",
                            "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                        Application.Current.Shutdown();
                    }
                }
                return database;
            }
        }

        public static Administration Administration
        {
            get
            {
                if(administration == null)
                {
                    administration = new Administration();
                }
                return administration;
            }
        }
        public static Admins Admins
        {
            get
            {
                if(admins == null)
                {
                    admins = new Admins(database);
                }
                return admins;
            }
        }

        public static Heads Heads
        {
            get
            {
                if(heads == null)
                {
                    heads = new Heads(database);
                }
                return heads;
            }
        }

        public static Teachers Teachers
        {
            get
            {
                if (teachers == null)
                {
                    teachers= new Teachers(database);
                }
                return teachers;
            }
        }


        public static Authorization Authorization
        {
            get
            {
                if(authorization == null)
                {
                    authorization = new Authorization(Database);
                }
                return authorization;
            }
        }
    }
}
