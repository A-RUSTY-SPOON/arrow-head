using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectHit : MonoBehaviour
{
    public int health = 4;
    public int damage = 30;
    public Transform target;
    public float speed = 5f;
    public Rigidbody2D rb;

    public void  DamageEnemey(int damage)
    {
        health = health - damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<health>();
        var movementEfect = gameObject.GetComponent<FollowPlayer>();
        var Obsticle = other.GetComponent<Identifyer>();
        if (player != null)
        {
            player.TakeDamage(this.damage);
            movementEfect.StartCoroutine(movementEfect.JustHit());
        }
        else
        {
            Debug.Log("player + null");
        }
        if (Obsticle != null)
        {
            SpinOut();
        }
        Debug.Log(other.name);


    }

    void SpinOut()
    {
        Vector2 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
        rb.velocity = transform.up * speed;
    }
    void Die()
    {
        Destroy(gameObject);
    }
}