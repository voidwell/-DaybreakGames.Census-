﻿using System;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace DaybreakGames.Census
{
    sealed class UnderscorePropertyJsonNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return Regex.Replace(name, @"(\w)([A-Z])", "$1_$2").ToLower();
        }
    }
}
