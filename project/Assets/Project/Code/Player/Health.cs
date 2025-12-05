using UnityEngine;
using System;

namespace Project.Code.Players {
    [SerializeField]
    public class Health {
        private float CurrentHealth;
        private float MaxHealth;

        public event Action PlayerDeath;

        public Health(float Health, float MaxHealthValue) {
            MaxHealth = MaxHealthValue;
            CurrentHealth = Health;
        }
        public void TakeDamage(float damage) {
            CurrentHealth -= damage;
            if (CurrentHealth < 0) CurrentHealth = 0;
            PlayerDeath?.Invoke();
        }
        public void Heal(float amount) {
            CurrentHealth += amount;
            if (CurrentHealth > MaxHealth) CurrentHealth = MaxHealth;
        }
        public float GetCurrentHealth() => CurrentHealth;
        public float GetMaxHealth() => MaxHealth;
    }
}