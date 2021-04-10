using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
	public class Book
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Desc { get; set; }
		public decimal Price { get; set; }
		public bool IsRecommend { get; set; }
		public int Available { get; set; }
	}
}
