using UnityEngine;
using UnityEngine.Events;

namespace Singleton.Events
{
    [CreateAssetMenu(fileName = "GameEvent", menuName = "Events/GameEvent")]
    public class GameEvent : ScriptableObject
    {
        private UnityAction listener;

        public void Raise()
        {
            listener?.Invoke();
        }

        public void Register(UnityAction action)
        {
            listener += action;
        }

        public void UnRegister(UnityAction action)
        {
            listener -= action;
        }
    }

}

