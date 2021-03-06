﻿using System;
using System.Data;
using System.IO;

namespace Ctrip.SOA.Infratructure.Utility
{
    /// <summary>
    /// 异常辅助工具类。
    /// </summary>
    public class ThrowHelper
    {
        /// <summary>
        /// 抛出异常
        /// </summary>
        /// <param name="paramName">导致异常的参数的名称。</param>
        /// <param name="message"><paramref name="paramValue"/>无效时显示的信息。</param>
        /// <param name="parameters">设置 <paramref name="message"/> 格式时使用的参数的数组。</param>
        /// <exception cref="ArgumentOutOfRangeException">抛出 <see cref="ArgumentOutOfRangeException"/>。</exception>
        public static void ThrowArgumentOutOfRangeException(string paramName, string message, params object[] parameters)
        {
            throw new ArgumentOutOfRangeException(paramName, message.FormatWith(parameters));
        }

        /// <summary>
        /// 抛出异常
        /// </summary>
        /// <param name="paramName">导致异常的参数的名称。</param>
        /// <param name="message"><paramref name="paramValue"/> 无效时显示的信息。</param>
        /// <param name="parameters">设置 <paramref name="message"/> 格式时使用的参数的数组。</param>
        /// <exception cref="ArgumentNullException">抛出 <see cref="ArgumentNullException"/>。</exception>
        public static void ThrowArgumentNullException(string paramName, string message, params object[] parameters)
        {
            throw new ArgumentNullException(paramName, message.FormatWith(parameters));
        }

        /// <summary>
        /// 抛出异常
        /// </summary>
        /// <param name="paramName">导致异常的参数的名称。</param>
        /// <param name="message"><paramref name="paramValue"/> 无效时显示的信息。</param>
        /// <param name="parameters">设置 <paramref name="message"/> 格式时使用的参数的数组。</param>
        /// <exception cref="ArgumentException">抛出 <see cref="ArgumentException"/>。</exception>
        public static void ThrowArgumentException(string paramName, string message, params object[] parameters)
        {
            throw new ArgumentException(message.FormatWith(parameters), paramName);
        }

        /// <summary>
        /// 抛出异常。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        public static void ThrowNotSupportedException(string message, params object[] parameters)
        {
            throw new NotSupportedException(message.FormatWith(parameters));
        }

        /// <summary>
        /// 抛出异常。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        public static void ThrowNotImplementedException(string message, params object[] parameters)
        {
            throw new NotImplementedException(message.FormatWith(parameters));
        }

        /// <summary>
        /// 抛出异常。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        public static void ThrowInvalidOperationException(string message, params object[] parameters)
        {
            throw new InvalidOperationException(message.FormatWith(parameters));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inner"></param>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        public static void ThrowInvalidOperationException(Exception inner, string message, params object[] parameters)
        {
            throw new InvalidOperationException(message.FormatWith(parameters), inner);
        }

        /// <summary>
        /// 文件加载失败。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        public static void ThrowFileLoadException(string message, params object[] parameters)
        {
            throw new FileLoadException(message.FormatWith(parameters));
        }

        /// <summary>
        /// 文件加载失败。
        /// </summary>
        /// <param name="inner"></param>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        public static void ThrowFileLoadException(Exception inner, string message, params object[] parameters)
        {
            throw new FileLoadException(message.FormatWith(parameters), inner);
        }

        /// <summary>
        /// 文件不存在。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        public static void ThrowFileNotFoundException(string message, params object[] parameters)
        {
            throw new FileNotFoundException(message.FormatWith(parameters));
        }

        /// <summary>
        /// 文件不存在。
        /// </summary>
        /// <param name="inner"></param>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        public static void ThrowFileNotFoundException(Exception inner, string message, params object[] parameters)
        {
            throw new FileNotFoundException(message.FormatWith(parameters), inner);
        }

        /// <summary>
        /// 格式化异常。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        public static void ThrowFormatException(string message, params object[] parameters)
        {
            throw new FormatException(message.FormatWith(parameters));
        }

        /// <summary>
        /// 数据异常。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        public static void ThrowDataException(string message, params object[] parameters)
        {
            throw new DataException(message.FormatWith(parameters));
        }

        /// <summary>
        /// 数据异常。
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        public static void ThrowDataException(Exception inner, string message, params object[] parameters)
        {
            throw new DataException(message.FormatWith(parameters), inner);
        }

        /// <summary>
        /// 类型加载异常。
        /// </summary>
        /// <param name="inner"></param>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        public static void ThrowTypeLoadExcetpion(string message, params object[] parameters)
        {
            throw new TypeLoadException(message.FormatWith(parameters));
        }

        /// <summary>
        /// 类型加载异常。
        /// </summary>
        /// <param name="inner"></param>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        public static void ThrowTypeLoadExcetpion(Exception inner, string message, params object[] parameters)
        {
            throw new TypeLoadException(message.FormatWith(parameters), inner);
        }
    }
}
