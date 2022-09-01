using System;
namespace aspFront.Models
{
	public class Product
	{
		public static int id = 0;
		public Product()
		{
			id++;
			this.Id = id;
		}

		public int Id { get; set; }

		public string Name { get; set; }

        public double Price { get; set; }

        public double OldPrice { get; set; }

		public string ImgURL { get; set; }
    }
}

