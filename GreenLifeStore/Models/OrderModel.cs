﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GreenLifeStore.Models
{
    public class OrderModel
    {
      
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalPrice { get; set; }


        //Navigation properties (one to many) , users -> orders : one user has many orders but one order is only to one user
        //FK
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public IdentityUser Users { get; set; }
        public List<OrderProductModel> OrderProduct { get; set; }
      


    }
}
