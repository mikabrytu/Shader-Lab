﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mikabrytu.ShaderLab
{
    public class ForceFieldComponent : MonoBehaviour
    {
        [SerializeField] private float maxHealth;
        [SerializeField] private float damage;
        [SerializeField] private float respawnTime;

        private IHealth healthSystem;

        private Material material;

        private void Start()
        {
            healthSystem = new ForceFieldHealthSystem();
            healthSystem.Setup(maxHealth, GetComponent<Renderer>().material);
        }

        public void DamageForceField()
        {
            healthSystem.Damage(damage);

            if (healthSystem.IsDead())
            {
                Invoke("RestartShield", respawnTime);
                gameObject.SetActive(false);
            }   
        }

        private void RestartShield()
        {
            healthSystem.Reset();
            gameObject.SetActive(true);
        }
    }
}
