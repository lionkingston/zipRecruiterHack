﻿using JobBoard.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobBoard.Models.ViewModels
{
    public class PublicProfileVM
    {
        public UserDomain User {get; set;}
        public ProfileDomain Profile { get; set; }
    }
}