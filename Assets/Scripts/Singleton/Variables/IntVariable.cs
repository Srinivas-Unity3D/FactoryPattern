using UnityEngine;


namespace Singleton.Variables
{
    [CreateAssetMenu(menuName = "Variables/IntVariable")]
    public class IntVariable : ScriptableObject
    {
        public int value;

        public void SetValue(int value)
        {
            this.value = value;
        }

        public void Add(int amount)
        {
            value += amount;
        }
    }
}
