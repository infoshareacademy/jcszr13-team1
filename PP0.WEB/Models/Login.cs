﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP0.WEB.Models
{
    internal class Login
    {
        public string AccountName { get; init; }

        public Login(string accountName)
        {
            AccountName = accountName;
        }
    }
}
