using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
public GameObject Bullet;
public Transform Shooter;
bool isFired = false;

    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Z) && !isFired)
            {
                GameObject bullet = Instantiate(Bullet, Shooter.position, Quaternion.identity);
                Rigidbody rb = bullet.GetComponent<Rigidbody>();
                rb.AddForce(Shooter.TransformDirection(Vector3.forward * 500));
                Destroy(bullet, 2.0f);
            }
    }
}