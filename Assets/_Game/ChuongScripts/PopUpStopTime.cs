using System;
using UnityEngine;

namespace _Game.ChuongScripts
{
    public class PopUpStopTime : MonoBehaviour
    {
        private void OnEnable()
        {
            Time.timeScale = 0f;
        }

        private void OnDisable()
        {
            Time.timeScale = 1f;
        }
    }
}