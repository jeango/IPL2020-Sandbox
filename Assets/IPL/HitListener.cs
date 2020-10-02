using UnityEngine;

namespace IPL
{
    public class HitListener : MonoBehaviour
    {
        private void Start()
        {
            var tanks = GameManager.Instance.Tanks;
            foreach (var tank in tanks)
            {
                tank.onHit += TankIsHit;
            }
        }

        public void TankHit()
        {
            print("A tank was hit");
        }
        
        public void TankIsHit(Tank tank)
        {
            print(tank.name +" was hit!");
        }
    }
}