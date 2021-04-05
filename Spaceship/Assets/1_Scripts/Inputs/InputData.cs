using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elie.Ship
{
    [System.Serializable]
    public struct InputData
    {
        public InputKeys key;
        public bool inverted;

        public float value => Input.GetAxis(key.ToString()) * (inverted ? -1.0f : 1.0f);
    }
}
