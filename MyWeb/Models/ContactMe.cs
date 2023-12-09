﻿namespace MyWeb.Models
{
    public class ContactMe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public ContactMe(string name, string email, string message)
        {
            Name = name;
            Email = email;
            Message = message;
        }
    }
}
