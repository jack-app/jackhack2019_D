using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ScheduleDate : MonoBehaviour
{
    public TimeSpan spendtime;
    public string title;
    public string category;
    public string memo;
    public bool needanounce;

    public void SetTitle(Text titlebox)
    {
        title = titlebox.text;
    }

    public void SetCategory(Text categorybox)
    {
        category = categorybox.text;
    }

    public void WriteMemo(Text memobox)
    {
        memo = memobox.text;
    }

    public void SetAnounce(Toggle anouncebox)
    {
        needanounce = anouncebox.isOn;
    }

    public void SetTime(Dropdown hour,Dropdown minutes)
    {
        spendtime = new TimeSpan(hour.value, minutes.value, 0);
    }

    public ScheduleDate SetAll(OneScheduleForm form)
    {
        SetTitle(form.titlebox);
        SetCategory(form.categorybox);
        WriteMemo(form.memobox);
        SetAnounce(form.anouncebox);
        SetTime(form.hour, form.minutes);

        return this;
    }
}
