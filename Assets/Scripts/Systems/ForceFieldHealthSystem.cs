using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mikabrytu.ShaderLab
{
    public class ForceFieldHealthSystem : IHealth
    {
        private float maxHealth;
        private float currentHealth;

        public void Setup(float maxHealth)
        {
            this.maxHealth = maxHealth;
            Reset();
        }

        public void Reset()
        {
            currentHealth = maxHealth;
        }

        public void Damage(float damage)
        {
            currentHealth -= damage;
        }

        public float GetHealth()
        {
            return currentHealth;
        }

        public bool IsDead()
        {
            return currentHealth <= 0;
        }
    }
}
