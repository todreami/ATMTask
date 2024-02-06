using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class ATMCondition : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector]

    public float StartCash;
    public float MaxCash = 100000000;
    public float BasicCash = 100000;

    public void Add(float amount)
    {
        StartCash = Mathf.Min(BasicCash + amount, MaxCash);
    }

    public void Subtract(float amount)
    {
        StartCash = Mathf.Max(BasicCash - amount, 0.0f);
    }

    public float GetPercentage()
    {
        return StartCash / MaxCash;
    }



}
