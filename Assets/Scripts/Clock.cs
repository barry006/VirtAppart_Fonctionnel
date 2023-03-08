using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    /// <summary>
    /// done from OXMOND Tech
    /// </summary>
    [SerializeField] private GameObject hourHand;
    [SerializeField] private GameObject minuteHand;
    [SerializeField] private GameObject secondHand;
    [SerializeField] private string axe; // axe de rotation des aigilles
    [SerializeField] private int sens; // 1 ou -1

    private string oldSecond;
    private void Start()
    {
        oldSecond = System.DateTime.UtcNow.ToString("ss");
    }

    // Update is called once per frame
    void Update()
    {
        string seconds = System.DateTime.UtcNow.ToString("ss");

        if (seconds != oldSecond)
        {
            UpdateTimer();
        }
        oldSecond = seconds;
    }

    private void UpdateTimer()
    {
        int secondsInt = int.Parse(System.DateTime.UtcNow.ToString("ss"));
        int minutesInt = int.Parse(System.DateTime.UtcNow.ToString("mm"));
        int hoursInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("hh"));
        // print(hoursInt + " : " + minutesInt + " : " + secondsInt);
        // iTween asset from unity
        iTween.RotateTo(secondHand, iTween.Hash(axe, secondsInt * 6 * sens, "time", 1, "easetype", "easeOutQuint"));
        iTween.RotateTo(minuteHand, iTween.Hash(axe, minutesInt * 6 * sens, "time", 1, "easetype", "easeOutElastic"));
        float hourDistance = (float)(minutesInt) / 60f;
        iTween.RotateTo(hourHand, iTween.Hash(axe, (hoursInt + hourDistance) * 360 * sens / 12, "time", 1, "easetype", "easeOutQuint"));
    }
}
