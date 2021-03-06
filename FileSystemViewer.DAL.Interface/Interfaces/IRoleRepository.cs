﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FileSystemViewer.DAL.Interface.DTO;

namespace FileSystemViewer.DAL.Interface.Interfaces
{
	public interface IRoleRepository : IRepository<DalRole>
	{
		//bool IsUserInRole(string userName, string roleName);
		void AddRoleToUser(int userId, int roleId);
		void RemoveRoleFromUser(int userId, int roleId);
		IEnumerable<DalRole> GetUserRoles(int userId);
	}
}
