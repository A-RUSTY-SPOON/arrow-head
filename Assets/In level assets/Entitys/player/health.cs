using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    new int healthLeft = 4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        healthLeft = healthLeft - damage;
        if (healthLeft <= 0)
        {
            Destroy(gameObject);
        }
    }
}
