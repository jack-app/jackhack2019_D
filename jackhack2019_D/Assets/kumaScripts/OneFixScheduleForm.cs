using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneFixScheduleForm : OneScheduleForm
{
    public Dropdown hourend;
    public Dropdown minutesend;
    public Dropdown week;

    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = (GameObject)Resources.Load("OneFixScheduleObj");
        child = Instantiate(obj, new Vector2(100, 0), new Quaternion());
    }

    public new void MakeSchedule()
    {
        var schedule = child.GetComponent<OneFixSchedule>().SetAll(this);
        admin.GetComponent<RestoreSchedules>().date3.Add(schedule);
    } 
    
}
