using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Singleton.Events;
using System;

namespace Singleton.Managers 
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager Instance { get; private set; }
        public TextMeshProUGUI scoreText;

        public GameEvent scoreupdateEvent;

        private void Awake()
        {
            if (Instance != null && Instance != this) 
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }

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
            scoreText.text = $"Score: {GameManager.instance.score}";
        }
    }
}
