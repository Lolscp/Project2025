using Project.Code.Input;
using Project.Code.Pattern.FSM;
using UnityEngine;

namespace Project.Code.Player.FSM {
    public class Aim : MovementFSM {
        public Aim(Rigidbody2D rigidbody, InputGameplay inputActions, Movement movement, Fsm Fsm) : base(rigidbody, inputActions, movement, Fsm) { }
        
        public override void Update() {
            if (inputActions.Player.Aim.ReadValue<bool>() == false) fsm.SetState<Idle>();

            Move(movement._Move * 0.53f);
        }
    }
}
