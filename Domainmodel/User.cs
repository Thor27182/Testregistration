﻿namespace Domainmodel
{
    public class User
    {
        public string Username { get; set; }

        public User(string username)
        {
            Username = username;
        }
    }
}