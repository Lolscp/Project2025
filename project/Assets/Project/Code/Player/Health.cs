using UnityEngine;

namespace Project.Code.Player {
    [SerializeField]
    public class Health {
        private float CurrentHealth;
        private float MaxHealth;

        public Health(float Health, float MaxHealth) {
            this.MaxHealth = MaxHealth;
            this.CurrentHealth = Health;
        }
        public void TakeDamage(float damage) {
            CurrentHealth -= damage;
            if (CurrentHealth < 0) CurrentHealth = 0;
        }
        public void Heal(float amount) {
            CurrentHealth += amount;
            if (CurrentHealth > MaxHealth) CurrentHealth = MaxHealth;
        }
        public float GetCurrentHealth() => CurrentHealth;
        public float GetMaxHealth() => MaxHealth;
    }
}