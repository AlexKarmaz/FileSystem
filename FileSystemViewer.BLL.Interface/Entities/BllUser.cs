﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemViewer.BLL.Interface.Entities
{
	public class BllUser
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
	}
}
