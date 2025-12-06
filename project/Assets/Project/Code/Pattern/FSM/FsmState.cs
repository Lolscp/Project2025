namespace Project.Code.Pattern.FSM {
    public abstract class FsmState {
        protected readonly Fsm fsm;

        public FsmState(Fsm Fsm) {
            fsm = Fsm;
        }
        public abstract void Enter();
        public abstract void Exit();
        public abstract void Update();
    }
}