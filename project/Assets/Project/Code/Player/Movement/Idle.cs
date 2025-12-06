using Project.Code.Input;
using Project.Code.Pattern.FSM;
using UnityEngine;

namespace Project.Code.Player.FSM {
    public class Idle : FsmState {
        private InputGameplay _inputActions;

        public Idle(Fsm Fsm, InputGameplay _inputActions) : base(Fsm) {
            this._inputActions = _inputActions;
        }

        public override void Enter() { }
        public override void Exit() { }
        public override void Update() {
            if (_inputActions.Player.Movement.ReadValue<Vector2>() != Vector2.zero) fsm.SetState<Move>();
        }
        
    }
}
