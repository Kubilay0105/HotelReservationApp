﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Hotel.Context
{
    [Table("ExtraTransactions")]

    public class ExtraTransactions
    {
        [Key]
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int RoomId { get; set; }
        [Required]
        public int Unit { get; set; }
        [Required]
        public decimal Sum { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public bool Status { get; set; }

        //Relations
        [ForeignKey("TypeId")]
        public virtual ExtraType ExtraType { get; set; }
        [ForeignKey("RoomId")]
        public virtual Room Room { get; set; }

    }
}
