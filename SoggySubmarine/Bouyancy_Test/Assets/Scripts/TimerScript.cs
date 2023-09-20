using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Add this script to a TMPro text object.

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI TimerText;    
    public float CurrentTime;

    void Update()
    {
        // Increments the time.
        CurrentTime = CurrentTime += Time.deltaTime;

        // Converts the current time to a string value.
        TimerText.text = CurrentTime.ToString();
        SetTimerText();

    }

    private void SetTimerText()
    {
        // Divides current time in seconds by 60 to find the minutes.
        string minutes = Mathf.FloorToInt(CurrentTime / 60f).ToString();

        // Uses modulus to show the remainder of minutes as seconds.
        string seconds = Mathf.FloorToInt(CurrentTime % 60f).ToString();

        // Adds an extra zero if the minutes are in the single digits.
        if(minutes.Length == 1)
        {
            minutes = "0" + minutes;
        }

        // Does the same for seconds.
        if(seconds.Length == 1)
        {
            seconds = "0" + seconds;
        }

        // Configures how the timer text will display.
        TimerText.text = string.Format(": {0}:{1}",minutes,seconds);



    }
}
