using System;
using System.ComponentModel.DataAnnotations;
using WebAPI.Interfaces;

namespace WebAPI.Models
{
    public class Gps : IGps
    {
        public int Id { get; set; }

        public string Coordinates { get; set; }
    }
}