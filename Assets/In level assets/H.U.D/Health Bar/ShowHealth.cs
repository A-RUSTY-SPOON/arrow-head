using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHealth : MonoBehaviour
{
    public GameObject Player;
    public GameObject fullHealth;
    public GameObject threeHealth;
    public GameObject halfHealth;
    public GameObject oneHealth;
    public GameObject noHealth;
    // Start is called before the first frame update
    void Start()
    {
        StartLevel();
    }

    // Update is called once per frame
    void Update()
    {
        var healthScript = Player.GetComponent<HitDetector>();
        int PlayerHealth = healthScript.health;

        if (PlayerHealth == 4)
        {
            fullHealth.SetActive(true);
            threeHealth.SetActive(false);
            halfHealth.SetActive(false);
            oneHealth.SetActive(true);
            noHealth.SetActive(false);
        }
        if (PlayerHealth == 3)
        {
            fullHealth.SetActive(false);
            threeHealth.SetActive(true);
            halfHealth.SetActive(false);
            oneHealth.SetActive(false);
            noHealth.SetActive(false);
        }
        if (PlayerHealth == 2)
        {
            fullHealth.SetActive(false);
            threeHealth.SetActive(false);
            halfHealth.SetActive(true);
            oneHealth.SetActive(false);
            noHealth.SetActive(false);
        }
        if (PlayerHealth == 1)
        {
            fullHealth.SetActive(false);
            threeHealth.SetActive(false);
            halfHealth.SetActive(false);
            oneHealth.SetActive(true);
            noHealth.SetActive(false);
        }
        if (PlayerHealth == 0)
        {
            fullHealth.SetActive(false);
            threeHealth.SetActive(false);
            halfHealth.SetActive(false);
            oneHealth.SetActive(false);
            noHealth.SetActive(true);
        }
    }
    
    void StartLevel()
    {
        fullHealth.SetActive(false);
        threeHealth.SetActive(false);
        halfHealth.SetActive(false);
        oneHealth.SetActive(false);
        noHealth.SetActive(false);
    }
}
