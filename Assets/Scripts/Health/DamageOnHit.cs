using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    public float damageAmount;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject otherObject = collision.gameObject;

        PlayerPawn playerPawn = otherObject.GetComponent<PlayerPawn>();

        if (playerPawn != null)
        {
            Health health = playerPawn.GetComponent<Health>();

            if (health != null)
            {
                health.TakeDamage(damageAmount);
            }
        }
    }
}
