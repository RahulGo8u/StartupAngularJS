using System;
using MongoDB.Bson;
namespace AngularJSStartupSkeleton.WebAPI.Models
{
    public class Account
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public object Id { get; set; }
    }
}
