﻿using System.ComponentModel.DataAnnotations;


namespace FileSystemViewer.PLMVC.Models.User
{
	public class LogViewModel
	{
		[Required(ErrorMessage = "The field can not be empty!")]
		[Display(Name = "Enter your name")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "The field can not be empty!")]
		[DataType(DataType.Password)]
		[Display(Name = "Enter your password")]
		public string Password { get; set; }

		[Display(Name = "Remember password?")]
		public bool RememberMe { get; set; }
	}
}