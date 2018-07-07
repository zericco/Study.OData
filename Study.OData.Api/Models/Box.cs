﻿using System.ComponentModel.DataAnnotations;

namespace Study.OData.Client.Models
{
	public class Box
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
