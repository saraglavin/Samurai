﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Quote> ListOfQuotes { get; set; }
        public Hairstyle Hairstyle { get; set; }
        public SecretIdentity SecretIdentity { get; set; }
        public List<SamuraiBattle> SamuraiBattle { get; set; }

    }
}
