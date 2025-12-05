using Project.Code.Pattern.FSM;
using UnityEngine;
namespace Project.Code.Player {
    public sealed class Movement {
        private float _speed = 5f;
        private float _Move;

        private Rigidbody2D _rigidbody;
        private Fsm State;

        public void Update() {
            State.Update();
        }

        public Movement(Rigidbody2D rigidbody,float Speed,float Move) {
            _rigidbody = rigidbody;
            _speed = Speed;
            _Move = Move;
        }
    }
}