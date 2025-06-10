using UnityEngine;
using WithoutFactory.Interfaces;


namespace WithoutFactory.Enemies 
{
    public class Zombie : IEnemy
    {
        public void Attack()
        {
            Debug.Log("Zombie Attacking!");
        }
    }

}
