﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Payment
    {
        [Key]
        public int paymentID { get; set; }
        public int userID { get; set; }     
        public PaymentMethod method { get; set; }
        public string nameOnCard { get; set; }
        public int cardNumber { get; set; }
        public DateTime expiration { get; set; }
        public string CVV { get; set; }
    }
}
