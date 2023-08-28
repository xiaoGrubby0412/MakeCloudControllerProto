using System.Collections.Generic;
using System;
using System.IO;
using System.Diagnostics;

namespace Baidu.VR.Zion.Utils
{
    public static class LoggerUtils
    {
        /// <summary>
        /// log 中 tag使用的颜色值
        /// </summary>
        public enum Colour
        {
            white = ColourProtocol.white,
            black = ColourProtocol.black,
            teal = ColourProtocol.teal,
            cyan = ColourProtocol.cyan,
            lightblue = ColourProtocol.lightblue,
            purple = ColourProtocol.purple,
            orange = ColourProtocol.orange,
            olive = ColourProtocol.olive,
            brown = ColourProtocol.brown,
            maroon = ColourProtocol.maroon,
            red = ColourProtocol.red,
            yellow = ColourProtocol.yellow
        }

        public enum LogType 
        {
            Log,
            Warning,
            Error,
        }

        public static void Log(string msg, string tag = "", Colour color = Colour.white)
        {
            FormatLog(LogType.Log, msg, tag, color);
        }
        
        public static void LogWarning(string msg, string tag = "", Colour color = Colour.white)
        {
            FormatLog(LogType.Warning, msg, tag, color);
        }

        public static void LogError(string msg, string tag = "", Colour color = Colour.white)
        {
            FormatLog(LogType.Error, msg, tag, color);
        }

        /// <summary>
        /// 格式化log msg
        /// </summary>
        /// <param name="type"></param>
        /// <param name="msg">log message</param>
        /// <param name="tag">log tag 加入了时间，当前场景</param>
        /// <param name="color">tag的颜色</param>
        private static void FormatLog(LogType type, string msg, string tag, Colour color)
        {
            Console.WriteLine(tag + " " + msg);
        }
    }
}