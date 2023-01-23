using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject muzzleFlashPrefab;
    [SerializeField] private float bulletForce = 20.0f;
    private Transform bulletSpawnpoint;
    private GameObject bulletInstance;
    private Rigidbody2D bulletRb;
    // Start is called before the first frame update
    void Start()
    {
        bulletSpawnpoint = GameObject.FindGameObjectWithTag("BulletSpawnpoint").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        bulletInstance = Instantiate(bulletPrefab, bulletSpawnpoint.position, bulletSpawnpoint.rotation);
        bulletRb = bulletInstance.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(bulletSpawnpoint.forward * bulletForce, ForceMode2D.Impulse);
    }
}
