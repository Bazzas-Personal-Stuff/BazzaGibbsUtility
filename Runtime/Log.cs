using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace BazzaGibbs.Utility
{
    /// <summary>
    /// Log class to strip debug messages from release builds
    /// </summary>
    public static class Log {
        
        // Info
        [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
        public static void Info(object message) {
            Debug.Log(message);
        }
        
        [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
        public static void Info(object message, UnityEngine.Object context) {
            Debug.Log(message, context);
        }

        
        // Warn
        [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
        public static void Warn(object message) {
            Debug.LogWarning(message);
        }

        [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
        public static void Warn(object message, UnityEngine.Object context) {
            Debug.LogWarning(message, context);
        }
        
        
        // Error
        [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
        public static void Error(object message) {
            Debug.LogError(message);
        }
        
        [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
        public static void Error(object message, UnityEngine.Object context) {
            Debug.LogError(message, context);
        }
    }
}
