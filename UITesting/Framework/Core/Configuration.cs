﻿using System;
namespace UITesting.Framework.Core
{
    public class Configuration
    {
        private Configuration()
        {
        }
		public static String Get(String value)
		{
			return System.Configuration.ConfigurationManager.AppSettings[value];
		}
    }
}
