using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CuantoGastoApp.Model
{
    [Table("Line")]
     public class Line
    {
        private int idLine;
        private decimal amount;
        private DateTime createDate;
        private string description;

        [Key]
        [Column("idline")]
        public int Id { get => idLine; set => idLine = value; }
        [Column("amount")]
        public decimal Amount { get => amount; set => amount = value; }
        [Column("createdate")]
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        [Column("description")]
        public string Description { get => description; set => description = value; }
    }
}