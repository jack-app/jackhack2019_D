using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixScheduleForm : OneScheduleForm
{
    public Dropdown hourend;
    public Dropdown minutesend;
    public Dropdown week;
    public ToggleGroup toggleGroup;
    
    
    void Start()
    {
        GameObject obj = (GameObject)Resources.Load("FixScheduleObj");
        child = Instantiate(obj, new Vector2(100, 0), new Quaternion());
        admin = GameObject.Find("Admin");
    }

    public new void MakeSchedule()
    {
        var schedule = child.GetComponent<FixSchedule>().SetAll(this);
        admin.GetComponent<RestoreSchedules>().date2.Add(schedule);
        Destroy(gameObject);
    } 
}
