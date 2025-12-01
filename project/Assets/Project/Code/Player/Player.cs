using System;
using UnityEngine;
namespace Project.Code.Player {
    public class Player : MonoBehaviour {
        [SerializeField] public Health health { get; private set; }

        private void Start() {
            health = new Health(Health:100f ,MaxHealth: 250f);
        }
        

        public event Action PlayerDeath;
    }
}
