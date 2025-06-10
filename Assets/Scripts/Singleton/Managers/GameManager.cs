using UnityEngine;


namespace Singleton.Managers 
{
    public class GameManager : MonoBehaviour
    {
        public int score { get; private set; }

        public void AddScore(int value)
        {
            score += value;
            Debug.Log($"Score: {score}");
        }
    }

}
