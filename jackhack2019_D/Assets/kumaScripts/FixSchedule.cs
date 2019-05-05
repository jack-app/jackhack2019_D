using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;

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

    public void SetWeek(ToggleGroup week)
    {
        string temp = week.ActiveToggles().First().GetComponentInChildren<Text>().text;
        switch (temp) {
            case "日":  daze = DayOfWeek.Sunday;break;
            case "月": daze = DayOfWeek.Monday; break;
            case "火": daze = DayOfWeek.Tuesday;break;
            case "水": daze = DayOfWeek.Wednesday; break;
            case "木": daze = DayOfWeek.Thursday; break;
            case "金": daze = DayOfWeek.Friday; break;
            case "土": daze = DayOfWeek.Saturday; break;
        }
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

    public new void Comp()
    {
        GameObject.Find("Admin").GetComponent<RestoreSchedules>().date2.Remove(this);
        GameObject.Find("Admin").GetComponent<RestoreSchedules>().maked.Remove(gameObject);
        Destroy(gameObject);
    }
}

public enum Repeat
{
    day = 0,
    week = 1
}

