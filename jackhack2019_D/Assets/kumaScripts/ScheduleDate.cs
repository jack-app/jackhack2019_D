using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ScheduleDate : MonoBehaviour
{
    protected TimeSpan spendtime;
    protected string title;
    protected string category;
    protected string memo;
    protected bool needanounce;

    public Text titlebox;
    public Text categorybox;
    public Text memobox;
    public Toggle anouncebox;
    public Dropdown hour;
    public Dropdown minutes;

    public void SetTitle()
    {
        title = titlebox.text;
    }

    public void SetCategory()
    {
        category = categorybox.text;
    }

    public void WriteMemo()
    {
        memo = memobox.text;
    }

    public void SetAnounce()
    {
        needanounce = anouncebox.isOn;
    }

    public void SetTime()
    {
        spendtime = new TimeSpan(hour.value, minutes.value, 0);
    }
}
