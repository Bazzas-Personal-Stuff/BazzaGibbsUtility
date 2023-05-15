using UnityEngine;

namespace BazzaGibbs.Utility {
    public static class VectorExtensions {
        
        /// <summary>
        /// Transform a Vector2 to top-down 3D coordinates on the XZ plane.
        /// </summary>
        /// <param name="vec2"></param>
        /// <returns></returns>
        public static Vector3 ToTopDown(this Vector2 vec2) {
            return new Vector3(vec2.x, 0.0f, vec2.y);
        }

        /// <summary>
        /// Transform a Vector3 in a top-down context to a Vector2 on the XY plane.
        /// </summary>
        /// <param name="vec3"></param>
        /// <returns></returns>
        public static Vector2 FromTopDown(this Vector3 vec3) {
            return new Vector2(vec3.x, vec3.z);
        }

        /// <summary>
        /// Cast Vector2 to Vector3 with Z = 0.
        /// </summary>
        public static Vector3 ToVector3(this Vector2 vec2) {
            return new Vector3(vec2.x, vec2.y, 0);
        }

        /// <summary>
        /// Cast Vector2 to Vector3, specifying Z value.
        /// </summary>
        public static Vector3 ToVector3(this Vector2 vector2, float z) {
            return new Vector3(vector2.x, vector2.y, z);
        }
    }
}