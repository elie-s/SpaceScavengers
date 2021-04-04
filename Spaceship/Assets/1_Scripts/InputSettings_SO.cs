using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elie.Ship
{
    [CreateAssetMenu(menuName = "Inputs/Settings")]
    public class InputSettings_SO : ScriptableObject
    {
        [Header("Rotations")]
        public InputKeys _pitch = default;
        public InputKeys _yaw = default;
        public InputKeys _roll = default;

        [Header("Strafe")]
        public InputKeys _strafeRight = default;
        public InputKeys _strafeUp = default;
        public InputKeys _strafeForward = default;
        
        [Header("Movements")]
        public InputKeys _maxSpeed = default;
        public InputKeys _maxThrust = default;
        public InputKeys _thrustBase = default;
        public InputKeys _thrustMultiplier = default;

        public string pitch => _pitch.ToString();
        public string yaw => _yaw.ToString();
        public string roll => _roll.ToString();

        public string strafeRight => _strafeRight.ToString();
        public string strafeUp => _strafeUp.ToString();
        public string strafeForward => _strafeForward.ToString();

        public string maxSpeed => _maxSpeed.ToString();
        public string maxThrust => _maxThrust.ToString();
        public string thrustBase => _thrustBase.ToString();
        public string thrustMultiplier => _thrustMultiplier.ToString();
    }

    public enum InputKeys
    {
        LJS_X,
        LJS_Y,
        RJS_X,
        RJS_Y,
        DPad_X,
        DPad_Y,
        Triggers,
        LT,
        RT,
        LB,
        RB,
        Bumpers
    }
}