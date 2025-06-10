using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Singleton.Events;
using System;
using Singleton.Variables;

namespace Singleton.Managers 
{
    public class UIManager : MonoBehaviour
    {
        public TextMeshProUGUI scoreText;

        public GameEvent scoreupdateEvent;

        [Header("Variables")]
        public IntVariable scoreVariable;

        private void OnEnable()
        {
            scoreupdateEvent.Register(UpdateScore);
        }

        private void OnDisable()
        {
            scoreupdateEvent.UnRegister(UpdateScore);
        }

        public void UpdateScore() 
        {
            scoreText.text = $"Score: {scoreVariable.value}";
        }
    }
}
