﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Models
{

    public class SalesOrder
    {
        public int SalesOrderID { get; set; }

        [Display(Name = "Sales Order")]
        public string SalesOrderNumber { get; set; }

        [Display(Name = "Purchase Order")]
        public string PurchaseOrderNumber { get; set; }

        [Display(Name = "Account")]
        public string AccountNumber { get; set; }

        [Display(Name = "Customer ID")]
        public int CustomerID { get; set; }

        [Display(Name = "Created")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Due")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DueDate { get; set; }

        [Display(Name = "on")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ShipDate { get; set; }

        [Display(Name = "to")]
        public int ShipToAddressID { get; set; }

        [Display(Name = "via")]
        public int ShipMethodID { get; set; }

        [Display(Name = "subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal SubTotal { get; set; }

        [Display(Name = "tax")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TaxAmount { get; set; }

        [Display(Name = "freight")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Freight { get; set; }

        [Display(Name = "total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalDue { get; set; }

        [Display(Name = "Modified")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ModifiedDate { get; set; }


    }
}
