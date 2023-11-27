﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Articles
{
    class Article
    {
        //характеристики -> автоматични properties
        public string Title {  get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        // конструктор -> създава празен обект от класа
        public Article (string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }   

        // метод -> извършва действия от класа
        public void Edit(string newContent)
        { 
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor) 
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }





    }
}
