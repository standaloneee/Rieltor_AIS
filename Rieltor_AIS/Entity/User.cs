using System.ComponentModel.DataAnnotations.Schema;

namespace Rieltor_AIS.Entity
{
    [Table("Users")]
    public class User
    {
        private int id{get;set;}
        private string name{get;set;}
        private string surname{get;set;}
        private string password{get;set;}
        private string phone{get;set;}
        private string position{get;set;}
    }
}