using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using AdvancedInputFieldPlugin;
using System;


public class InputValidation : MonoBehaviour
{
    private float value;
    private float lowerLimit;
    private float upperLimit;
    private AdvancedInputField inputField;
    private ChangeValue changeValue;

    private void Start()
    {
        changeValue = GetComponent<ChangeValue>();
        lowerLimit = changeValue.lowerLimit;
        upperLimit = changeValue.upperLimit;
        inputField = transform.GetComponent<AdvancedInputField>();

        value = changeValue.defaultValue;
        OnValueChanged();
    }

    public void OnValueChanged()
    {
        if (!string.IsNullOrEmpty(inputField.Text))
        {
            string st = inputField.Text;

            st = st.Replace(".", ",");
            Debug.Log(st);
            value = (float)Convert.ToDouble(st);

            if (value < lowerLimit)
                value = lowerLimit;
            if (value > upperLimit)
                value = upperLimit;
        }

        inputField.Text = value.ToString();

        changeValue.Change(value);
    }
}
