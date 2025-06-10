using UnityEngine;


namespace Singleton.Managers 
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance { get; private set;}

        public int score { get; private set; }

        private void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(gameObject);
                return;
            }

            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        public void AddScore(int value)
        {
            score += value;
            Debug.Log($"Score: {score}");
        }
    }

}
