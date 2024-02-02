﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TransactionRecordApp.Entities
{
    /// <summary>
    /// This class represents the columns in the Transaction table in the DB
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// this corresponds with the table PK and will work as an auto number
        /// since it's an int
        /// </summary>
        public int TransactionId { get; set; }


        [Required(ErrorMessage = "Please enter a Ticker Symbol")]
        public string? TickerSymbol { get; set; }


        [Required(ErrorMessage = "Please enter the Company Name")]
        public string? CompanyName { get; set; }


        [Required(ErrorMessage = "Please enter the quantity of shares")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a whole number greater than zero")]
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "Please enter the a share price that is greater than zero")]
        public double? SharePrice { get; set; }

		public double? GrossValue => Quantity * SharePrice;
	}
}
