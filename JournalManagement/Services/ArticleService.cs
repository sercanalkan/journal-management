using System;
using System.Collections.Generic;
using JournalManagement.Models;

namespace JournalManagement.Services
{
    public class ArticleService
    {
        public Article Get(string id)
        {
            return null;
        }
        
        public List<Article> GetList()
        {
            return null;
        }

        public Article Insert(Article article)
        {
            article.Id = "9384793";
            article.CreateTime = DateTime.Now;
            article.UpdateTime = DateTime.Now;
            //insert into article (asdasiasds,asdasd) values (dsfsd,dfsdf);
            
            return article; //INSERTED
        }

        public bool Update(Article article)
        {
            return true; //UPDATED
        }

        public bool Delete(string id)
        {
            return true;//DELETED
        }
        
        
        
        
        
    }
}