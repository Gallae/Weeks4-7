using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour
{
    public Slider healthbarSlider;
    public float maxHealth = 100;
    public float minimumHealth;
    public float damage;

    private float currentHealth;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbarSlider.value = currentHealth / maxHealth; //set it to maxHealth

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Handle what happens when we get to zero
    public void OnDamageClick()
    {
        currentHealth -= damage;
        healthbarSlider.value = currentHealth / maxHealth;
    }

    public void OnHealthChanged()
    {
        Debug.Log("Health has changed - " + healthbarSlider.value.ToString());
    }


}
