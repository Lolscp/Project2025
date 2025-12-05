using Project.Code.Pattern.FSM;
using UnityEngine;

namespace Project.Code.Player.FSM {
    public class Running : MovementFSM {
        public Running(Rigidbody2D rigidbody, float speed, Fsm fsm) : base(rigidbody, speed, fsm)
        {
        }
    }

}