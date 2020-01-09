using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceFieldPower : MonoBehaviour
{
    [SerializeField] private float damage;

    private Material material;
    private float force = 0;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
        SetShieldForce();
    }

    public void DamageShield()
    {
        if (force >= 1)
        {
            Invoke("ResetShield", 2f);
            gameObject.SetActive(false);
        }

        force += damage;
        SetShieldForce();
    }

    public void ResetShield()
    {
        gameObject.SetActive(true);
        force = 0;
        SetShieldForce();
    }

    private void SetShieldForce()
    {
        material.SetFloat("_ShieldHP", force);
    }
}
