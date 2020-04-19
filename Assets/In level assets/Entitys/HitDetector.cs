using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{
    public int health = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var ThingHit = collision.GetComponent<AttackDetails>();
        var followPlayer = gameObject.GetComponent<FollowPlayer>();
        var dontBounce = collision.GetComponent<bullet>();
        if (ThingHit != null)
        {
            health -= ThingHit.strength;
            Debug.Log(health);
            if (health <= 0)
            {
                Destroy(gameObject);
                Destroy(this);
            }
        }
        if (dontBounce == null)
        {
            if (followPlayer != null)
            {
                followPlayer.StartCoroutine(followPlayer.JustHit());
            }
        }
        if (dontBounce != null)
        {
            
        }
    }

}
