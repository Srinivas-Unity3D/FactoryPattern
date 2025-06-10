using UnityEngine;
using Singleton.Managers;
using Singleton.Events;
using Singleton.Variables;


namespace Singleton.Player 
{
    public class PlayerController : MonoBehaviour
    {
        public float moveSpeed = 5f;

        [Header("Events")]
        public GameEvent pickupEvent;
        public GameEvent scoreChangeEvent;

        [Header("Variables")]
        public IntVariable scoreVariable;

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
                scoreVariable.Add(1);
                scoreChangeEvent?.Raise();
                Destroy(other.gameObject);
            }
        }
    }
}


