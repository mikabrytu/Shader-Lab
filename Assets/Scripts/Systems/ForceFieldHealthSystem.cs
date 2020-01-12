using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mikabrytu.ShaderLab
{
    public class ForceFieldHealthSystem : IHealth
    {
        private Material material;
        private float maxHealth;
        private float currentHealth;

        public void Setup(float maxHealth, Material material)
        {
            this.maxHealth = maxHealth;
            this.material = material;
            
            Reset();
        }

        public void Reset()
        {
            currentHealth = maxHealth;
            SetMaterialColor();
        }

        public void Damage(float damage)
        {
            currentHealth -= damage;
            SetMaterialColor();
        }

        public float GetHealth()
        {
            return currentHealth;
        }

        public bool IsDead()
        {
            return currentHealth <= 0;
        }

        private void SetMaterialColor()
        {
            material.SetFloat("_ShieldHP", currentHealth / maxHealth);
        }
    }
}
