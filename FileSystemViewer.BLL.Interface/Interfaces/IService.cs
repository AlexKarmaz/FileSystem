﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemViewer.BLL.Interface.Interfaces
{
	public interface IService<T>
	{
		T GetById(int id);
		IEnumerable<T> GetAll();
		T GetOneByPredicate(Expression<Func<T, bool>> predicates);
		IEnumerable<T> GetAllByPredicate(Expression<Func<T, bool>> predicates);
		void Create(T entity);
		void Delete(T entity);
		void Update(T entity);
	}
}
