using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth { get; private set; }

    [SerializeField] private float startingHealth;

    private bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            //player is hurt
            Debug.Log("oops, lost a life");
        }
        else
        {
            if (!dead)
            {
                //player dies
                GetComponent<Playercontrol>().enabled = false;
                dead = true;

            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
