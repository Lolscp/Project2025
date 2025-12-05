using UnityEngine;

namespace Project.Code.Player {
    public class Player : MonoBehaviour {
        private Movement _Movement;

        private Rigidbody2D player;

        private void Inti() {
            _Movement = new Movement(player,6f,17f);
        }
    }
}