﻿using System;

namespace Cookie.Core
{
    public delegate void OnLogDelegate(string log, LogMessageType logType);

    public sealed class Logger
    {
        private static volatile Logger _Instance;
        private static object syncRoot = new Object();

        private Logger() {}

        public static Logger Default
        {
            get
            {
                if (_Instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_Instance == null)
                            _Instance = new Logger();
                    }
                }

                return _Instance;
            }
        }

        #region Membres

        public event OnLogDelegate OnLog;
        private void OnOnLog(string log, LogMessageType logType)
        {
            OnLog?.Invoke(log, logType);
        }

        public void Log(string info, LogMessageType logType = LogMessageType.Divers)
        {
            OnOnLog(info, logType);
        }

        #endregion
    }
}
