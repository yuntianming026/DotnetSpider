﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Java2Dotnet.Spider.Ioc
{
	public class IocExtension
	{
		private static IServiceProvider _serviceProvider;

		public static IServiceCollection ServiceCollection { get; set; } = new ServiceCollection();

		public static IServiceProvider ServiceProvider
		{
			get
			{
				if (_serviceProvider == null)
				{
					_serviceProvider = ServiceCollection.BuildServiceProvider();
				}
				return _serviceProvider;
			}
		}
	}
}
