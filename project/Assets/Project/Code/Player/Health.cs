using System;
using UnityEngine;

namespace Project.Code.Player {
    [SerializeField]
    public sealed class Health { 
        private float _currentHealth;
        private float _MaxHealth;

        public Health(float Health,float MaxHealth) {
            _currentHealth = Health;
            _MaxHealth = MaxHealth;
        }
        public void TakeDamage(float damage) {
            _currentHealth -= damage;
            if (_currentHealth < 0) DeathPlayer?.Invoke();
        }
        public void Heal(float heal) {
            _currentHealth += heal;
            if (_currentHealth > _MaxHealth) _currentHealth = _MaxHealth;
        }

        public event Action DeathPlayer;
    }
}