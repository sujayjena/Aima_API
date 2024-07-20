using Aima.Domain.Entities;
using System.ComponentModel;

namespace Aima.Application.Models
{
    public class ResponseModel 
    {
        [DefaultValue(0)]
        public int Id { get; set; }

        public bool? IsSuccess { get; set; }
        public string? Message { get; set; }

        [DefaultValue(0)]
        public long Total { get; set; }
        public object Data { get; set; }
    }
}
