using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float launchForce = 10f;

    private void Update()
    {
        if (Input.GetKeyDown((KeyCode.Space)))
        {
            ShootProjectile();
        }
    }

    void ShootProjectile()
    {
        // Instantiate a new projectile
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        // Apply force to the projectile in the forward direction of the launcher
        Rigidbody projectileRigidbody = projectile.GetComponent<Rigidbody>();
        projectileRigidbody.AddForce(transform.forward * launchForce, ForceMode.Impulse);
        //float moveZ = Time.deltaTime *launchForce;
       // projectileRigidbody.transform.Translate(0,0,moveZ);
    }
}
