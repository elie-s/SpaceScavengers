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
        [SerializeField] private TextMeshProUGUI speedText = default;
        [SerializeField] private RectTransform maxCursor = default;
        [SerializeField] private Image gauge = default;

        public void UpdateValues(string _speedtext, float _maxCursor, float _speedValue)
        {
            speedText.text = _speedtext;

            maxCursor.anchoredPosition = new Vector2(maxCursor.anchoredPosition.x,
                Mathf.InverseLerp(0.0f, dimensions.sizeDelta.y, _maxCursor));

            gauge.fillAmount = _speedValue;
        }
    }

}