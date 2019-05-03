using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class OneFixSchedule : ScheduleDate
{
    private TimeSpan starttime;
    private DayOfWeek daze;
    public Dropdown hourend;
    public Dropdown minutesend;
    public Dropdown week;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public new void SetTime()
    {
        starttime = new TimeSpan(hour.value, minutes.value, 0);
        spendtime = starttime - new TimeSpan(hourend.value, minutesend.value, 0);
    }

    public void SetWeek()
    {
        daze = (DayOfWeek)week.value;
    }
}
