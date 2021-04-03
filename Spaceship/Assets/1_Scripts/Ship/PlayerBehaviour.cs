using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elie.Ship
{
    public class PlayerBehaviour : MonoBehaviour
    {
        [SerializeField] private ShipController shipController = default;
        
        #region MONOBEHAVIOUR

        private void Update()
        {
            shipController.IncreaseRoll(Input.GetAxis("Triggers"));
            shipController.IncreaseYaw(Input.GetAxis("RJS_X"));
            shipController.IncreasePitch(Input.GetAxis("RJS_Y"));
        }
        
        #endregion
    }
}
