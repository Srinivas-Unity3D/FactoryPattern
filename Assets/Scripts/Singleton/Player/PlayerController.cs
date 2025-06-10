using UnityEngine;
using Singleton.Managers;
using Singleton.Events;


namespace Singleton.Player 
{
    public class PlayerController : MonoBehaviour
    {
        public float moveSpeed = 5f;

        [Header("Events")]
        public GameEvent pickupEvent;
        public GameEvent scoreChangeEvent;

        private void Update()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 move = new Vector3(h, 0, v) * moveSpeed * Time.deltaTime;
            transform.Translate(move);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Collectibles")) 
            {
                pickupEvent?.Raise();
                GameManager.instance.AddScore(1);
                scoreChangeEvent?.Raise();
                Destroy(other.gameObject);
            }
        }
    }
}


