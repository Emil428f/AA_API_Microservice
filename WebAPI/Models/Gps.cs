using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Gps
    {
        public int Id { get; set; }

        public string Coordinates { get; set; }
    }
}