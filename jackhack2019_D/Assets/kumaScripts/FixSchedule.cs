using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class FixSchedule : ScheduleDate
{
    public TimeSpan starttime;
    public DayOfWeek daze;
    public Repeat repeat;
    
    

    public void SetTime(Dropdown hour,Dropdown minutes,Dropdown hourend,Dropdown minutesend)
    {
        starttime = new TimeSpan(hour.value, minutes.value, 0);
        spendtime = starttime - new TimeSpan(hourend.value, minutesend.value, 0);
    }

    public void SetWeek(Dropdown week)
    {
        daze = (DayOfWeek)week.value;
    }
    public void SetRepeat(Toggle t)
    {
        if(t.isOn == false)
        {
            repeat = Repeat.day;
        }
        else
        {
            repeat = Repeat.week;
        }
    }

    public FixSchedule SetAll(FixScheduleForm form)
    {
        SetTime(form.hour, form.minutes, form.hourend, form.minutesend);
        if (repeat == Repeat.week)
        {
            SetWeek(form.week);
        }
        SetTitle(form.titlebox);

        if (form.memobox != null)
        {
            WriteMemo(form.memobox.text);
        }
        else
        {
            WriteMemo("");
        }

        return this;
    }
}

public enum Repeat
{
    day = 0,
    week = 1
}

