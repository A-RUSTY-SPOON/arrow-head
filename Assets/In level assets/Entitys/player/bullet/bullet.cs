using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    public int damage = 2;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
        StartCoroutine(DespawnTime());

    }

    void Update()
    {

    }
    // Update is called once per frame
    private IEnumerator DespawnTime()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
        Destroy(this);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
