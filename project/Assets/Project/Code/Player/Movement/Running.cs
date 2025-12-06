using Project.Code.Input;
using Project.Code.Pattern.FSM;
using UnityEngine;

namespace Project.Code.Player.FSM {
    public class Running : MovementFSM {
        public Running(Rigidbody2D rigidbody, InputGameplay inputActions, Movement movement, Fsm Fsm) : base(rigidbody, inputActions, movement, Fsm) { }

        public override void Update() {
            if (inputActions.Player.Movement.ReadValue<Vector2>() == Vector2.zero) fsm.SetState<Idle>();
            if (inputActions.Player.Run.ReadValue<float>() == 0) fsm.SetState<Move>();

            Move(movement._Move + movement._speed);
        }
    }
}