using UnityEngine;
using Singleton.Managers;


namespace Singleton.Player 
{
    public class PlayerController : MonoBehaviour
    {
        public float moveSpeed = 5f;

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
                GameManager.instance.AddScore(1);
                Destroy(other.gameObject);
            }
        }
    }
}


