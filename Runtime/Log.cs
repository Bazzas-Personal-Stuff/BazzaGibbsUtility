using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace BazzaGibbs.Utility
{
    /// <summary>
    /// Log class to strip debug messages from release builds
    /// </summary>
    public static class Log {
        
        [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
        public static void Info(object message) {
            Debug.Log(message);
        }

        [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
        public static void Warn(object message) {
            Debug.LogWarning(message);
        }

        [Conditional("DEVELOPMENT_BUILD"), Conditional("UNITY_EDITOR")]
        public static void Error(object message) {
            Debug.LogError(message);
        }
        
    }
}
