using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class AppUsers
    {
        
        [Key]
        public long id {get;set;}
        
        public string UserName { get; set; }
    }
}