using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChangeValue : MonoBehaviour
{
    public float defaultValue;
    public float lowerLimit;
    public float upperLimit;

    public abstract void Change(float newValue);
}
