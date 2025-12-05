using Project.Code.Pattern.FSM;
using UnityEngine;

namespace Project.Code.Player.FSM {
    public class Move : MovementFSM {

        public override void Enter() {
            fsm.SetState<Running>();
        }
        public override void Exit() {
            fsm.SetState<Idle>();
        }
        
        public Move(Rigidbody2D rigidbody, float speed, Fsm fsm) : base(rigidbody, speed, fsm) { }
    }
}