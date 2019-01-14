using ECommon.Configurations;
using ECommon.Logging;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommon.NLogs
{
    public static class ConfigurationExtensions
    {
        /// <summary>Use dot net core as the logger.
        /// </summary>
        /// <returns></returns>
        public static Configuration UseNetCoreLog(this Configuration configuration, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory)
        {
            configuration.SetDefault<ILoggerFactory, NetCoreLoggerFactory>(new NetCoreLoggerFactory(loggerFactory));
            return configuration;
        }
    }
}
