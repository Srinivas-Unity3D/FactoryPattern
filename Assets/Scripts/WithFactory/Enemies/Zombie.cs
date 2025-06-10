using UnityEngine;
using WithFactory.Interfaces;

namespace WithFactory.Enemies
{
    public class Zombie : IEnemy
    {
        public void Attack()
        {
            Debug.Log("Zombie Attacking");
        }
    }

}
