using Project.Code.Input;
using Project.Code.Pattern.FSM;
using UnityEngine;

namespace Project.Code.Player.FSM {
    public class MovementFSM : FsmState {
        protected Rigidbody2D _rigidbody;
        protected Movement movement;
        protected InputGameplay inputActions;

        public MovementFSM(Rigidbody2D rigidbody, InputGameplay inputActions, Movement movement,Fsm Fsm) : base(Fsm) {
            _rigidbody = rigidbody;
            this.movement = movement;
            this.inputActions = inputActions;
        }

        public override void Enter() { }
        public override void Update() {}
        public override void Exit() { }

        protected void Move(float move) {
            _rigidbody.MovePosition(_rigidbody.position += inputActions.Player.Movement.ReadValue<Vector2>() * (move * Time.deltaTime));
        }


    }
}