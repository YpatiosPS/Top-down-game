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
    private Transform bulletTransform;
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
  //      bulletTransform = bulletInstance.transform;
    //    bulletTransform.eulerAngles = new Vector3(bulletTransform.rotation.x, bulletTransform.rotation.y, bulletSpawnpoint.rotation.z + 45);
        bulletRb = bulletInstance.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(bulletSpawnpoint.right * bulletForce, ForceMode2D.Impulse);
        Destroy(bulletInstance, 2);
    }
}
