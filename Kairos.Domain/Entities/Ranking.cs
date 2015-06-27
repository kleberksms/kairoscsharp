﻿using System;

namespace Kairos.Domain.Entities
{
    public class Ranking
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
