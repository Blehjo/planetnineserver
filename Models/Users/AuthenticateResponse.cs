﻿using planetnineserver.Models;

namespace planetnineserver.Models.Users
{
	public class AuthenticateResponse
	{
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
    }
}

