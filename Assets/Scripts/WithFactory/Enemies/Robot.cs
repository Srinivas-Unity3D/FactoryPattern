using UnityEngine;
using WithFactory.Interfaces;


namespace WithFactory.Enemies 
{
    public class Robot : IEnemy
    {
        public void Attack()
        {
            Debug.Log("Robot is Shooting");
        }
    }

}
