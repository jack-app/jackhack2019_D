using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class RestoreSchedules : MonoBehaviour
{

    public List<ScheduleDate> date1 = new List<ScheduleDate>();
    public List<FixSchedule> date2 = new List<FixSchedule>();
    public List<OneFixSchedule> date3 = new List<OneFixSchedule>();
    public GameObject scroll;
    public State state;

    // Start is called before the first frame update
    void Start()
    {
        state = State.today;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AllScheduledate()
    {
        
        foreach(var sc in date1)
        {
            GameObject obj = (GameObject)Resources.Load("TodayTaskView");
            var child = Instantiate(obj, Vector2.zero, Quaternion.identity, scroll.transform);
            child.GetComponent<TodayTaskView>().date = sc;
        }
    }

    public void AllFixSchedule()
    {
       
        foreach (var sc in date2)
        {
            GameObject obj = (GameObject)Resources.Load("TodayTaskView");
            var child = Instantiate(obj, Vector2.zero, Quaternion.identity, scroll.transform);
            child.GetComponent<TodayTaskView>().date1 = sc;
        }
    }

    public void AllOneFixSchedule()
    {

        
        foreach (var sc in date3)
        {
            GameObject obj = (GameObject)Resources.Load("TodayTaskView");
            var child = Instantiate(obj, Vector2.zero, Quaternion.identity, scroll.transform);
            child.GetComponent<TodayTaskView>().date2 = sc;
        }
    }

    public void TodaySchedule(out List<ScheduleDate> schedules1, out List<FixSchedule> schedules2, out List<OneFixSchedule> schedules3)
    {

        schedules1 = new List<ScheduleDate>(); schedules2 = new List<FixSchedule>(); schedules3 = new List<OneFixSchedule>();
        schedules1 = date1;
        schedules2 = date2.Where((x) => x.daze == DateTime.Now.DayOfWeek || x.repeat == Repeat.day).ToList();
        schedules3 = date3.Where((x) => x.date == new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day)).ToList();

    }

    public void MakeTodayTask()
    {
        
        bool[] time = new bool[288];
        
        TodaySchedule(out List<ScheduleDate> schedules1, out List<FixSchedule> schedules2, out List<OneFixSchedule> schedules3);
        foreach(var sc in schedules2)
        {
            for(int i = 0; i < sc.spendtime.Hours * 12 + sc.spendtime.Minutes / 5; i++)
            {
                time[i + sc.starttime.Hours * 12 + sc.starttime.Minutes / 5] = true;
            }

            GameObject obj = (GameObject)Resources.Load("TodayTaskView");
            var child = Instantiate(obj, Vector2.zero, Quaternion.identity, scroll.transform);
            child.GetComponent<TodayTaskView>().date1 = sc;
        }

        foreach (var sc in schedules3)
        {
            for (int i = 0; i < sc.spendtime.Hours * 12 + sc.spendtime.Minutes / 5; i++)
            {
                time[i + sc.starttime.Hours * 12 + sc.starttime.Minutes / 5] = true;
            }

            GameObject obj = (GameObject)Resources.Load("TodayTaskView");
            var child = Instantiate(obj, Vector2.zero, Quaternion.identity, scroll.transform);
            child.GetComponent<TodayTaskView>().date2 = sc;
        }

        foreach (var sc in schedules1)
        {
            for(int i = 0; i < 288; i++)
            {
                for(int j = 0; j < sc.spendtime.Hours * 12 + sc.spendtime.Minutes / 5; j++)
                {
                    if(time[i + j] == true)
                    {
                        break;
                    }
                    if(j == sc.spendtime.Hours * 12 + sc.spendtime.Minutes / 5 - 1)
                    {
                        for (int k = 0; i < sc.spendtime.Hours * 12 + sc.spendtime.Minutes / 5; k++)
                        {
                            time[i + k] = true;
                        }
                        //TODO:生成コード書く & makedに登録
                        GameObject obj = (GameObject)Resources.Load("TodayTaskView");
                        var child = Instantiate(obj, Vector2.zero, Quaternion.identity, scroll.transform);
                        child.GetComponent<TodayTaskView>().date = sc;
                        goto Next;
                    }
                }
            }
            Next:;
        }
    }

}

public enum State
{
    today = 0,
    everyday = 1,
    want = 2,
    anounce = 3
}