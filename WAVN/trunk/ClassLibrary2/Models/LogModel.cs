using System;

namespace WAVN.Services.Models
{
    public class LogModel
    {
        public Guid Id{ get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
