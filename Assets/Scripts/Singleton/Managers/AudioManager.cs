using Singleton.Events;
using UnityEngine;


namespace Singleton.Managers
{
    public class AudioManager : MonoBehaviour
    {

        [SerializeField] private AudioClip pickupClick;
        private AudioSource audioSource;

        public GameEvent playAudioEvent;

        private void Awake()
        {
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
