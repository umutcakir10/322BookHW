﻿using System;



namespace _322Homework1.Models
{
    public class Book
    {
        public Book()
        {

        }
        public string name { get; set; }
        public string author { get; set; }
        public int page_number { get; set; }
        public DateTime due_date { get; set; }
        public TimeSpan remainingTime { get; set; }
    }
}