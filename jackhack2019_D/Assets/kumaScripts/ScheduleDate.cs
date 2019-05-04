using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ScheduleDate : MonoBehaviour
{
    public TimeSpan spendtime;
    public string title;
    public string memo;
    public int haveto;

    public void SetTitle(Text titlebox)
    {
        title = titlebox.text;
    }

    public void WriteMemo(Text memobox)
    {
        memo = memobox.text;
    }


    public void SetTime(Dropdown hour,Dropdown minutes)
    {
        spendtime = new TimeSpan(hour.value, minutes.value, 0);
    }

    public ScheduleDate SetAll(OneScheduleForm form)
    {
        haveto = 2;
        SetTitle(form.titlebox);
        WriteMemo(form.memobox);
        SetTime(form.hour, form.minutes);

        return this;
    }
}
