using System;
using SQLite;
namespace ICT13580068FinalA.Models
{
    public class Product
    {
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[NotNull]
		[MaxLength(100)]
		public string Name { get; set; }

		[NotNull]
		[MaxLength(100)]
		public string Lastname { get; set; }

		public int Age { get; set; }
		public string Sex { get; set; }
		public string Department { get; set; }
		public int Phone { get; set; }

		[NotNull]
		public string Address { get; set; }
		public string Status { get; set; }
		public int Number { get; set; }
		public decimal Saraly { get; set; }

	}
}
