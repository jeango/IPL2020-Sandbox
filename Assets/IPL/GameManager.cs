using UnityEngine;

namespace IPL
{
    public class GameManager : SingletonMb<GameManager>
    {
        [SerializeField] private Tank[] tanks;
        public Tank[] Tanks => tanks;
        protected override void Initialize()
        {
        }
        protected override void Cleanup()
        {
        }
    }
}