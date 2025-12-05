using Project.Code.Pattern.FSM;
using UnityEngine;

namespace Project.Code.Player.FSM {
    public class Idle : FsmState {
        private Fsm _fsm;

        public override void Enter() { }
        public override void Exit() {
            _fsm.SetState<Move>();  
        }
        public override void Update() { }

        public Idle(Fsm fsm) {
            _fsm = fsm;
        }
    }
}
