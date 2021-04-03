using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elie.Ship
{
    public class ShipController : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField] private ShipControllerSettings_SO settings = default;
        [SerializeField] private UISpeedGauge speedGauge = default;
        
        //ROTATIONS
        private float roll;
        private float currentRoll;
        private float yaw;
        private float currentYaw;
        private float pitch;
        private float currentPitch;
        
        //Movement
        private float currentSpeed;
        private float maxSpeed;

        #region MONOBEHAVIOUR
        private void FixedUpdate()
        {
            ApplyRotations();
        }

        #endregion
        
        #region ROTATIONS
        private void ApplyRotations()
        {
            currentRoll = Mathf.Lerp(currentRoll, roll,settings.rollSmoothness );
            currentYaw = Mathf.Lerp(currentYaw, yaw,settings.yawSmoothness );
            currentPitch = Mathf.Lerp(currentPitch, pitch,settings.pitchSmoothness );
            
            transform.Rotate(pitch - currentPitch, yaw - currentYaw,roll - currentRoll, Space.Self);
        }
        
        public void IncreaseRoll(float _value)
        {
            roll += _value * settings.rollSpeed * Time.deltaTime;

            if (roll > 360.0f )
            {
                currentRoll -= 360.0f;
                roll -= 360.0f;
            }
            else if (roll < -360.0f)
            {
                currentRoll += 360.0f;
                roll += 360.0f;
            }
        }
        
        public void IncreaseYaw(float _value)
        {
            yaw += _value * settings.yawSpeed * Time.deltaTime;

            if (yaw > 360.0f )
            {
                currentYaw -= 360.0f;
                yaw -= 360.0f;
            }
            else if (yaw < -360.0f)
            {
                currentYaw += 360.0f;
                yaw += 360.0f;
            }
        }
        
        public void IncreasePitch(float _value)
        {
            pitch += _value * settings.pitchSpeed * Time.deltaTime;

            if (pitch > 360.0f )
            {
                currentPitch -= 360.0f;
                pitch -= 360.0f;
            }
            else if (roll < -360.0f)
            {
                currentPitch += 360.0f;
                pitch += 360.0f;
            }
        }
        #endregion
        
        #region Movement

        public void IncreaseMaxSpeed(float _value)
        {
            maxSpeed = Mathf.Clamp(0.0f, settings.maxSpeed,
                maxSpeed + settings.maxSpeedIncreasingSpeed * _value * Time.deltaTime);
            
            //speedGauge.UpdateValues(Mathf.Round());
        }


        #endregion
    }
}