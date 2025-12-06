using Project.Code.Input;
using UnityEngine;

namespace Project.Code.Player {
    public class Player : MonoBehaviour {
        [Header("Components")]
        [SerializeField] private Rigidbody2D player;

        private Health _Health;
        private Movement _Movement;
        private EffectsStat _Effects;

        private InputGameplay _inputActions;

        public void FixedUpdate() {
            _Movement?.Update();
        }

        private void Inti() {
            _inputActions = new InputGameplay();

            _Movement = new Movement(player,6f,4f, _inputActions);
            _Health = new Health(100f, 250f);

        }
        private void OnDisable() {
            _inputActions.Disable();
        }
        private void OnEnable() {
            _inputActions.Enable();
        }
    }
}