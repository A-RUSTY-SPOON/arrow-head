using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public static bool inMenu = false;
    void Update()
    {
        GetComponent<DropDownButtons>();
        if (Input.GetButtonDown("Fire1") && DropDownButtons.GameIsPaused == false)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        var finalPostition = transform.position + transform.TransformDirection(new Vector3(-0.05f * 75, 0.61f * 75, 0));
        Instantiate(bulletPrefab, finalPostition, firePoint.rotation);
    }
}
