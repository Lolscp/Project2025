namespace Project.Code.Pattern.FSM {
    public abstract class FsmState {
        public abstract void Enter();
        public abstract void Exit();
        public abstract void Update();
    }
}