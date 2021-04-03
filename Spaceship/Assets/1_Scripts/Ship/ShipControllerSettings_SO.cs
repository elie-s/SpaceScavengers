using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elie.Ship
{
    [CreateAssetMenu(menuName = "Ships/Settings")]
    public class ShipControllerSettings_SO : ScriptableObject
    {
        [Header("Rotations")]
        public float pitchSpeed = 1.0f;
        public float pitchSmoothness = 0.5f;
        public float yawSpeed = 1.0f;
        public float yawSmoothness = 0.5f;
        public float rollSpeed = 1.0f;
        public float rollSmoothness = 0.5f;
        [Header("Movement")]
        public float maxSpeed = 10.0f;
        public float maxSpeedIncreasingSpeed = 1.0f;
    }
}
