﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseStockControl.Models
{
	public class Supplier
	{
		[Key]
		[Index]
		public int id { get; set; }
		public string name { get; set; }
		public string surname { get; set; }
		public string company { get; set; }
		public string nipt { get; set; }
		public string email { get; set; }
		public string phone1 { get; set; }
		public string phone2 { get; set; }
		public string address { get; set; }
		public string description { get; set; }
		public DateTime datecreated { get; set; }
		public bool status { get; set; }
	}
}