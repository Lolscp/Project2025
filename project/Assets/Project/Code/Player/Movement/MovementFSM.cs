using Project.Code.Pattern.FSM;
using UnityEngine;

namespace Project.Code.Player.FSM {
    public class MovementFSM : FsmState {
        protected Rigidbody2D _rigidbody;
        protected float _speed;
        protected Fsm fsm;

        public override void Enter() { }
        public override void Update() {}
        public override void Exit() { }

        public MovementFSM(Rigidbody2D rigidbody, float speed,Fsm fsm) {
            _rigidbody = rigidbody;
            _speed = speed;
            this.fsm = fsm;
        }
    }
}