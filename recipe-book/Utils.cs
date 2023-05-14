﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace recipe_book
{
	internal static class Utils
	{
		public static T Clone<T>(this T controlToClone)
		where T : Control
		{
			PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

			T instance = Activator.CreateInstance<T>();

			foreach (PropertyInfo propInfo in controlProperties)
			{
				if (propInfo.CanWrite)
				{
					try
					{
						if (propInfo.Name != "WindowTarget")
							propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
					}
					catch (Exception e) { }
				}
			}

			return instance;
		}
	}
}
