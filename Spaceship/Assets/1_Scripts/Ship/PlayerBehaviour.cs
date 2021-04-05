using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elie.Ship
{
    public class PlayerBehaviour : MonoBehaviour
    {
        [SerializeField] private InputSettings_SO inputs = default;
        [SerializeField] private ShipController shipController = default;
        
        #region MONOBEHAVIOUR

        private void Update()
        {
            shipController.IncreaseRoll(inputs.roll.value);
            shipController.IncreaseYaw(inputs.yaw.value);
            shipController.IncreasePitch(inputs.pitch.value);
            
            shipController.IncreaseMaxSpeed(inputs.maxSpeed.value);
            shipController.IncreaseThrust(inputs.thrustBase.value + inputs.thrustMultiplier.value);
            shipController.SetStrafe(inputs.strafeRight.value,
                                     inputs.strafeUp.value,
                                     inputs.strafeForward.value);
        }
        
        #endregion
    }
}
