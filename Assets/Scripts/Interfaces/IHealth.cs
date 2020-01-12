using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mikabrytu.ShaderLab
{
    public interface IHealth
    {
        void Setup(float maxHealth);
        void Reset();
        void Damage(float damage);
        float GetHealth();
        bool IsDead();
    }
}
