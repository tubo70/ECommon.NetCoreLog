using ECommon.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace ECommon.NLogs
{
    public class NetCoreLogger : Logging.ILogger
    {
        private readonly Microsoft.Extensions.Logging.ILogger logger;
        public NetCoreLogger(Microsoft.Extensions.Logging.ILogger logger)
        {
            this.logger = logger;
        }
        public bool IsDebugEnabled
        {
            get
            {
                return logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel.Debug);
            }
        }

        public void Debug(object message)
        {
            logger.LogDebug(message.ToString());
        }

        public void Debug(object message, Exception exception)
        {
            logger.LogDebug(exception, message.ToString());
        }

        public void DebugFormat(string format, params object[] args)
        {
            logger.LogDebug(format, args);
        }

        public void Error(object message)
        {
            logger.LogError(message.ToString());
        }

        public void Error(object message, Exception exception)
        {
            logger.LogError(exception, message.ToString());
        }

        public void ErrorFormat(string format, params object[] args)
        {
            logger.LogError(format, args);
        }

        public void Fatal(object message)
        {
            logger.LogCritical(message.ToString());
        }

        public void Fatal(object message, Exception exception)
        {
            logger.LogCritical(exception, message.ToString());
        }

        public void FatalFormat(string format, params object[] args)
        {
            logger.LogCritical(format, args);
        }

        public void Info(object message)
        {
            logger.LogInformation(message.ToString());
        }

        public void Info(object message, Exception exception)
        {
            logger.LogInformation(exception, message.ToString());
        }

        public void InfoFormat(string format, params object[] args)
        {
            logger.LogInformation(format, args);
        }

        public void Warn(object message)
        {
            logger.LogWarning(message.ToString());
        }

        public void Warn(object message, Exception exception)
        {
            logger.LogWarning(exception, message.ToString());
        }

        public void WarnFormat(string format, params object[] args)
        {
            logger.LogWarning(format, args);
        }
    }
}
