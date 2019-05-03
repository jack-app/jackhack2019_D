using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class OneFixSchedule : ScheduleDate
{
    public TimeSpan starttime;
    public DayOfWeek daze;
   

    public void SetTime(Dropdown hour,Dropdown minutes, Dropdown hourend,Dropdown minutesend)
    {
        starttime = new TimeSpan(hour.value, minutes.value, 0);
        spendtime = starttime - new TimeSpan(hourend.value, minutesend.value, 0);
    }

    public void SetWeek(Dropdown week)
    {
        daze = (DayOfWeek)week.value;
    }

    public OneFixSchedule SetAll(OneFixScheduleForm form)
    {
        SetTime(form.hour, form.minutes, form.hourend, form.minutesend);
        SetWeek(form.week);
        SetTitle(form.titlebox);
        SetCategory(form.categorybox);
        SetAnounce(form.anouncebox);
        WriteMemo(form.memobox);

        return this;
    }
}
