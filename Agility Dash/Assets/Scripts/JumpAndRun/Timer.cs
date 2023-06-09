using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;

    private bool active = false;

    // Start is called before the first frame update
    void Start()
    {
        timerText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(active) 
        {
            currentTime = currentTime += Time.deltaTime;
            SetTimerText();

        }
        
    }

    public void StartTimer()
    {
        timerText.gameObject.SetActive(true);
        active = true;
    }

    public void StopTimer()
    {
        timerText.gameObject.SetActive(false);
        active = false;
    }

    private void SetTimerText()
    {
        timerText.text = currentTime.ToString("0.00");
    }
}
