using Project.Code.Input;
using Project.Code.Pattern.FSM;
using Project.Code.Player.FSM;
using UnityEngine;

namespace Project.Code.Player {
    public sealed class Movement {
        public float _speed { get; private set; }
        public float _Move { get; private set; }

        private Rigidbody2D _rigidbody;
        private InputGameplay _inputActions;
        private Fsm State;

        public void Update() {
            State?.Update();
        }
        public Movement(Rigidbody2D rigidbody,float Speed,float Move, InputGameplay inputActions) {
            _inputActions = inputActions;
            _rigidbody = rigidbody;
            _speed = Speed;
            _Move = Move;

            State = new Fsm();
            State.AddState(new Idle(State, _inputActions));
            State.AddState(new Move(_rigidbody, _inputActions, this, State));
            State.AddState(new Running(_rigidbody, _inputActions, this, State));
            State.AddState(new Aim(_rigidbody, _inputActions, this, State));
            State.AddState(new Stealth(_rigidbody, _inputActions, this, State));

            State.SetState<Idle>();
        }

    }
}