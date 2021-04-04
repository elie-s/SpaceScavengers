using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Elie.Ship
{
    public class UISpeedGauge : MonoBehaviour
    {
        [SerializeField] private RectTransform dimensions = default;
        [Header("Speed")]
        [SerializeField] private TextMeshProUGUI speedText = default;
        [SerializeField] private RectTransform maxCursor = default;
        [SerializeField] private Image speedGauge = default;
        [Header("Thrust")]
        [SerializeField] private TextMeshProUGUI thrustText = default;
        [SerializeField] private Image thrustGauge = default;
        [SerializeField] private Gradient thrustColors = default;

        public void UpdateSpeedValues(string _speedtext, float _maxCursor, float _speedValue)
        {
            speedText.text = _speedtext;

            maxCursor.anchoredPosition = new Vector2(maxCursor.anchoredPosition.x,
                Mathf.Lerp(0.0f, dimensions.sizeDelta.y, _maxCursor));
            
            Debug.Log(Mathf.Lerp(0.0f, dimensions.sizeDelta.y, _maxCursor));

            speedGauge.fillAmount = _speedValue;
        }

        public void UpdateThrustValues(float _thrustValue)
        {
            thrustText.text = Mathf.Round(_thrustValue * 100.0f).ToString()+"%";
            thrustGauge.fillAmount = _thrustValue;
            thrustGauge.color = thrustColors.Evaluate(_thrustValue);

        }
    }

}