using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneScheduleForm : MonoBehaviour
{

    public Text titlebox;
    public Text categorybox;
    public Text memobox;
    public Toggle anouncebox;
    public Dropdown hour;
    public Dropdown minutes;

    protected GameObject child;
    protected GameObject admin;

    void Start()
    {
        GameObject obj = (GameObject)Resources.Load("OneScheduleObj");
        child = Instantiate(obj, new Vector2(100, 0), new Quaternion());
        admin = GameObject.Find("Admin");
    }

    public void MakeSchedule()
    {
        var schedule = child.GetComponent<ScheduleDate>().SetAll(this);
        admin.GetComponent<RestoreSchedules>().date1.Add(schedule);
        Destroy(gameObject);
    }
   
}
