﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizApp.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("QuizApp.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Продолжить.
        /// </summary>
        internal static string ContinueText {
            get {
                return ResourceManager.GetString("ContinueText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream LongBeep {
            get {
                return ResourceManager.GetStream("LongBeep", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Время вышло..
        /// </summary>
        internal static string OutOfTimeText {
            get {
                return ResourceManager.GetString("OutOfTimeText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Команда 1 отвечает.
        /// </summary>
        internal static string Player1AnsweringText {
            get {
                return ResourceManager.GetString("Player1AnsweringText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Команда 2 отвечает.
        /// </summary>
        internal static string Player2AnsweringText {
            get {
                return ResourceManager.GetString("Player2AnsweringText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Команда 3 отвечает.
        /// </summary>
        internal static string Player3AnsweringText {
            get {
                return ResourceManager.GetString("Player3AnsweringText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Заново.
        /// </summary>
        internal static string ResetText {
            get {
                return ResourceManager.GetString("ResetText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Запуск.
        /// </summary>
        internal static string RunText {
            get {
                return ResourceManager.GetString("RunText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream ShortBeep {
            get {
                return ResourceManager.GetStream("ShortBeep", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Начальное время введено неправельно. Пожалуйста введите время в формате: минуты:секунды. Пример: 5:32.55.
        /// </summary>
        internal static string StartTimeParseErrorString {
            get {
                return ResourceManager.GetString("StartTimeParseErrorString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Остановить.
        /// </summary>
        internal static string StopText {
            get {
                return ResourceManager.GetString("StopText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Команда 1 отвечает.
        /// </summary>
        internal static string Team1AnsweringText {
            get {
                return ResourceManager.GetString("Team1AnsweringText", resourceCulture);
            }
        }
    }
}
