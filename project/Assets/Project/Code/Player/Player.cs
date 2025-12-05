using UnityEngine;

namespace Project.Code.Players {
    public class Player : MonoBehaviour {
        [Header("Properties")]
        [SerializeField] private float _Health;
        [SerializeField] private float _Move;
        [SerializeField] private float _Speed;
        [Header("Components")]
        [SerializeField] private Rigidbody2D _Player;

        [SerializeField] public Movement Movement { get; private set; }
        [SerializeField] public Health Health { get; private set; }

        private void Update() {
                        
        }

        public void Inif(float SetHealth, float SetMove,float SetSpeed) {
            Health = new Health(Health: SetHealth, MaxHealthValue:350f);
            Movement = new Movement(Speed: SetSpeed, Move: SetMove, Rigidbody2D:_Player);

            _Health = SetHealth;
            _Move = SetMove;
            _Speed = SetSpeed;

            Health.PlayerDeath += DeadPlayer;
        }
        
        private void DeadPlayer() {
            Debug.Log("Player is dead!");
        }
    }
}
