﻿using System.ComponentModel.DataAnnotations;

namespace Airplanes.Dtos
{
    public class AirplaneOfAirport
    {
        [Required]
        public int Pid { get; set; }
        [Required]
        public string Pname { get; set; }
        public List<String> Airplanes { get; set; } = new List<String>();
    }
}
