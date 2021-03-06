﻿using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GithubLanguage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Percent { get; set; }
        public int RepositoryId { get; set; }

        public virtual GithubRepository Repository { get; set; }
    }
}
