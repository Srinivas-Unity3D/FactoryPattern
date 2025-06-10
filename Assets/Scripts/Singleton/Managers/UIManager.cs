using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Singleton.Managers 
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager Instance { get; private set; }
        public TextMeshProUGUI scoreText;

        private void Awake()
        {
            if (Instance != null && Instance != this) 
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }

        public void UpdateScore(int score) 
        {
            scoreText.text = score.ToString();
        }
    }


}
