using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elie.Ship
{
    [CreateAssetMenu(menuName = "Inputs/Settings")]
    public class InputSettings_SO : ScriptableObject
    {
        [Header("Rotations")]
        public InputData pitch = default;
        public InputData yaw = default;
        public InputData roll = default;

        [Header("Strafe")]
        public InputData strafeRight = default;
        public InputData strafeUp = default;
        public InputData strafeForward = default;
        
        [Header("Movements")]
        public InputData maxSpeed = default;
        public InputData maxThrust = default;
        public InputData thrustBase = default;
        public InputData thrustMultiplier = default;
    }
}