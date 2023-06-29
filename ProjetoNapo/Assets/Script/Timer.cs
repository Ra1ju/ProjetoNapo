using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    
    [Header("Timer Settings")]
    [SerializeField] private float currentTime;
    [SerializeField] private int goldTime = 25;
    [SerializeField] private int silverTime = 50;
    [SerializeField] private string timerTextIndicator;

    private void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= goldTime)
        {
            ChangeTextColor(currentTime);
        }
        
        timerText.text = timerTextIndicator + " " +  currentTime.ToString("0.00").Replace(",",".");
    }

    private void ChangeTextColor(float time)
    {
        if (time >= goldTime && time < silverTime)
        {
            if(timerText.color != Color.gray)
            timerText.color = Color.gray;
        }
        else if (time >= silverTime)
        {
            if(timerText.color != Color.red)
            timerText.color = Color.red;
        }
    }
}
