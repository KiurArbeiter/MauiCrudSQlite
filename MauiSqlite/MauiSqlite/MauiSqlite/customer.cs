﻿using SQLite;


namespace MauiSqlite
{
    [Table("customer")]
    public class Customer
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Mobile {  get; set; }
        public string Email { get; set; }
    }
}
