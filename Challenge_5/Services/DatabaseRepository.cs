using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5.Services
{
    public class DatabaseRepository
    {
        private static string dbFile = Path.Combine(Environment.CurrentDirectory, "BudgetDb.db3");

        public static T Insert<T>(T item)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int rows = conn.Insert(item);
                if (rows > 0)
                    return item;
            }
            return item;
        }

        public static void Delete<T>(T item)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                conn.Delete(item);
            }
        }

        public static T Update<T>(T item)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int rows = conn.Update(item);   
                if (rows > 0)
                    return item;
            }
            return item;
        }

        

        public static List<T> Read<T>() where T : new()
        {
            List<T> items;

            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                items = conn.Table<T>().ToList();
            }

            return items;
        }
        public static List<T> ReadWithChildren<T>() where T : new()
        {
            List<T> items;

            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                items = conn.GetAllWithChildren<T>();
            }

            return items;
        }

        public static T ReadById<T>(object pk) where T : new()
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                return conn.GetWithChildren<T>(pk);
            }

        }
    }
}
