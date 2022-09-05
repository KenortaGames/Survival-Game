using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    [Header("Health & Stamina")]
    public float energy;
    public float maxEnergy;
    public float stamina;
    
    [Header("Survival")]
    public float hunger;
    float maxHunger = 100f;
    public float thirst;
    float maxThirst = 100f;
    public float sleep;
    float maxSleep = 100f;

    [Header("Debug Texts")]
    public TMP_Text hungerText;
    public TMP_Text sleepText;
    public TMP_Text energyText;
    public TMP_Text staminaText;
    public TMP_Text thirstText;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Resets Values of Stats to Max
        hunger = maxHunger;
        thirst = maxThirst;
        sleep = maxSleep;
        energy = maxEnergy;
        stamina = maxEnergy;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug Texts
        hungerText.text = "Hunger: " + hunger.ToString();
        sleepText.text = "Sleep: " + sleep.ToString();
        energyText.text = "Energy: " + energy.ToString();
        staminaText.text = "Stamina: " + Mathf.Round(stamina).ToString();
        thirstText.text = "Thirst: " + thirst.ToString();

        //Controls Stats Values
        if(hunger > maxHunger){
            hunger = maxHunger;
        }
        if(hunger < 0){
            hunger = 0;
        }

        if(sleep > maxSleep){
            sleep = maxSleep;
        }
        if(sleep < 0){
            sleep = 0;
        }

        if(stamina > maxEnergy){
            stamina = maxEnergy;
        }
        if(stamina < 0){
            stamina = 0;
        }
        
        if(thirst > maxThirst){
            thirst = maxThirst;
        }
        if(thirst < 0){
            thirst = 0;
        }
    }
}
