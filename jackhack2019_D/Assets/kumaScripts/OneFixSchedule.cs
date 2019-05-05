using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;

public class OneFixSchedule : ScheduleDate
{
    public TimeSpan starttime;
    public DateTime date;
   

    public void SetTime(Dropdown hour,Dropdown minutes, Dropdown hourend,Dropdown minutesend)
    {
        starttime = new TimeSpan(hour.value, minutes.value, 0);
        spendtime = starttime - new TimeSpan(hourend.value, minutesend.value, 0);
    }

    public void SetWeek(Dropdown month,Dropdown day)
    {

        date = new DateTime(DateTime.Now.Year,month.value + 1,day.value + 1);
        if(date < DateTime.Now)
        {
            date = new DateTime(DateTime.Now.Year + 1, month.value + 1, day.value + 1);
        }
    }

    

    public OneFixSchedule SetAll(OneFixScheduleForm form)
    {
        haveto = 4;
        SetTime(form.hour, form.minutes, form.hourend, form.minutesend);
        if (form.month != null)
        {
            SetWeek(form.month, form.day);
        }
        else
        {
            date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
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
