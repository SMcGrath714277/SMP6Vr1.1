using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameObject hourHand;
    public GameObject minuteHand;
    public GameObject secondHand;
    private System.DateTime realTime;
    float hourAngle;
    float minuteAngle;
    float secondAngle;
    float hourRotationSpeed = 360f / 12f / 60f / 60f;
    float minuteRotationSpeed = 360f / 60f / 60f;
    float secondRotationSpeed = 360f / 60f;

    void Start()
    {
             
    }

    void Update()
    {
        realTime = System.DateTime.Now;
        UpdateHand();
    }

    void UpdateHand()
    {
        hourAngle = realTime.Hour * 30f + realTime.Minute * 0.5f;
        minuteAngle = realTime.Minute * 6f;
        secondAngle = realTime.Second * 6f;

        hourHand.transform.localRotation = Quaternion.Euler(hourAngle + Time.deltaTime * hourRotationSpeed, 0, 0);
        minuteHand.transform.localRotation = Quaternion.Euler(minuteAngle + Time.deltaTime * minuteRotationSpeed, 0, 0);
        secondHand.transform.localRotation = Quaternion.Euler(secondAngle + Time.deltaTime * secondRotationSpeed, 0, 0);
    }
}
