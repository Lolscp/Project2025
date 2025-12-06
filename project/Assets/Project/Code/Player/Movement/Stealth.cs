using Project.Code.Input;
using Project.Code.Pattern.FSM;
using UnityEngine;

namespace Project.Code.Player.FSM {
    public class Stealth : MovementFSM {
        public Stealth(Rigidbody2D rigidbody, InputGameplay inputActions, Movement movement, Fsm Fsm) : base(rigidbody, inputActions, movement, Fsm) { }

        public override void Update() {
             if (inputActions.Player.C.ReadValue<bool>() == false) fsm.SetState<Idle>();

             Move(movement._Move * 0.2f);
        }
    }
}
