﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SFA.Models
{
	public class Query
	{
		public int Limit { get; set; }

		public string Order { get; set; }

		public int Page { get; set; }
	}
}
