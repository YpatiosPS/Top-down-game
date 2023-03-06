using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject deathEffect;
    private GameObject deathEffectInstance;
    [SerializeField] private int playerStartingHealth;
    public static int currentPlayerHealth;
    public static int playerMaxHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentPlayerHealth = playerStartingHealth;   
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentPlayerHealth);
        if (currentPlayerHealth <= 0)
        {
            deathEffectInstance = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(deathEffectInstance, 2.0f);
            Destroy(gameObject);
        }
    }
}
