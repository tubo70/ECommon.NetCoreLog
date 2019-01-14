using ECommon.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace ECommon.NLogs
{
    public class NetCoreLoggerFactory : Logging.ILoggerFactory
    {
        private readonly Microsoft.Extensions.Logging.ILoggerFactory factory;
        public NetCoreLoggerFactory(Microsoft.Extensions.Logging.ILoggerFactory factory)
        {
            this.factory = factory;
        }
        public Logging.ILogger Create(string name)
        {
            return new NetCoreLogger(factory.CreateLogger(name));
        }

        public Logging.ILogger Create(Type type)
        {
            return new NetCoreLogger(factory.CreateLogger(type));
        }
          
    }
}
