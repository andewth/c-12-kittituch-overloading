using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    int health = 10;
    public int Health => health;

    float strength = 1.0f;
    public float Strength => strength;


    float speed = 5.0f;
    public float Speed => speed;



    float originalSpeed;
    float speedBoostDuration = 0.0f;
    float speedBoostTimer = 0.0f;
    bool isSpeedBoostActive = false;


    [SerializeField] TextMeshProUGUI healthTxt, strengthTxt, speedTxt;


    void Start()
    {
        originalSpeed = speed;

        UpdateHealthText();
        UpdateStrengthText();
        UpdateSpeedText();
    }


    void Update()
    {
        UpdateSpeedBoostTimer();
    }


    void UpdateSpeedBoostTimer()
    {
        if (isSpeedBoostActive)
        {
            speedBoostTimer += Time.deltaTime;
            Debug.Log($"+++ Speed Boost +++");
            if ( speedBoostTimer > speedBoostDuration ) 
            {
                speed = originalSpeed;
                isSpeedBoostActive = false;
                Debug.Log($"Speed boost ended. Speed reset.");
            }
        }
    }


    public void PowerUp(int healthIncrease)
    {
        health += healthIncrease;
        Debug.Log($"Health increased by {healthIncrease}. New health: {health}");
        UpdateHealthText();
    }


    public void PowerUp(float strengthMultiplier)
    {
        strength += strengthMultiplier;
        Debug.Log($"Strength increased by {strengthMultiplier * 100}%.  New Strength: {strength}");
        UpdateStrengthText();
    }


    public void PowerUp(float strengthMultiplier, float duration)
    {
        speed *= strengthMultiplier;
        isSpeedBoostActive = true;
        speedBoostDuration = duration;
        speedBoostTimer = 0.0f;
        Debug.Log($"Speed boosted by {strengthMultiplier * 100}%.  for {duration} seconds.");
        UpdateSpeedText();
    }


    void UpdateHealthText()
    {
        healthTxt.text = $"Health : {Health}";
    }

    void UpdateStrengthText()
    {
        strengthTxt.text = $"Strength : {strength}";
    }

    void UpdateSpeedText()
    {
        speedTxt.text = $"Speed : {speed}";
    }

}
