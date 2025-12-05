using UnityEngine;

namespace Project.Code.Players {
    [SerializeField]
    public class Movement {
        private float _Move;
        private float _Speed;

        private Rigidbody2D Player;

        public Movement(float Speed,float Move,Rigidbody2D Rigidbody2D) {
            _Speed = Speed;
            _Move = Move;
        }
    }
}
