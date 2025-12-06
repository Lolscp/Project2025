using System;
using System.Collections.Generic;

namespace Project.Code.Pattern.FSM {
    public class Fsm {
        private Dictionary<Type, FsmState> _State;
        private FsmState _StateCurrent;

        public void Update() => _StateCurrent?.Update();

        public void SetState<T>() where T : FsmState { 
            var type = typeof(T);
            
            if (_StateCurrent != null && _StateCurrent.GetType() == type ) {  return; }
            if (_State.TryGetValue(type, out var NewState)) {
                _StateCurrent?.Exit();
                _StateCurrent = NewState;
                _StateCurrent.Enter();
            }
        }
        public void AddState(FsmState state) {
            _State.Add(state.GetType(), state);
        }
        public Fsm() {
            _State = new Dictionary<Type, FsmState>();
        }
    }
}