using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class FixSchedule : ScheduleDate
{
    private TimeSpan starttime;
    private DayOfWeek daze;
    private Repeat repeat;
    public Dropdown dropdown;
    public Dropdown hourend;
    public Dropdown minutesend;
    public Dropdown week;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void SetRepeat()
    {
        repeat = (Repeat)dropdown.value;
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

public enum Repeat
{
    day = 0,
    week = 1,
    month = 2
}

