using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimPower : MonoBehaviour
{
    public GameObject gunModel;
    public GameObject bulletPrefab;
    public float bulletSpeed = 100f;
    // public AudioClip shootingSound;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab, gunModel.transform.position, gunModel.transform.rotation);
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = gunModel.transform.forward * bulletSpeed;
            // AudioSource.PlayClipAtPoint(shootingSound, transform.position);
            Debug.Log("hello");
        }
    }
}
