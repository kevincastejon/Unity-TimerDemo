using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScaler : MonoBehaviour
{
    public void SetTimeScale(float newValue)
    {
        Time.timeScale = newValue;
    }
}
