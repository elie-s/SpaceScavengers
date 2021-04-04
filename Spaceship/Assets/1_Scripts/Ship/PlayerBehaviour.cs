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
            shipController.IncreaseRoll(Input.GetAxis(inputs.roll));
            shipController.IncreaseYaw(Input.GetAxis(inputs.yaw));
            shipController.IncreasePitch(Input.GetAxis(inputs.pitch));
            
            shipController.IncreaseMaxSpeed(Input.GetAxis(inputs.maxSpeed));
            shipController.IncreaseThrust(Input.GetAxis(inputs.thrustBase) + Input.GetAxis(inputs.thrustMultiplier));
            shipController.SetStrafe(Input.GetAxis(inputs.strafeRight),
                                      Input.GetAxis(inputs.strafeUp),
                                   Input.GetAxis(inputs.strafeForward));
        }
        
        #endregion
    }
}
