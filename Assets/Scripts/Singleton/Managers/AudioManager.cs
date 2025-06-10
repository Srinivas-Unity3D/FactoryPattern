using Singleton.Events;
using UnityEngine;


namespace Singleton.Managers
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance { get; private set; }

        [SerializeField] private AudioClip pickupClick;
        private AudioSource audioSource;

        public GameEvent playAudioEvent;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;

            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.playOnAwake = false;
        }

        private void OnEnable()
        {
            playAudioEvent.Register(PlayPickupSound);
        }



        private void OnDisable()
        {
            playAudioEvent.UnRegister(PlayPickupSound);
        }

        public void PlayPickupSound() 
        {
            audioSource.PlayOneShot(pickupClick);
        }
    }

}
