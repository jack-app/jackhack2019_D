using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TodayTaskView : MonoBehaviour
{

    public bool active = false;
    public ScheduleDate date = null;
    public FixSchedule date1 = null;
    public OneFixSchedule date2 = null;
    public GameObject child1;
    public GameObject child2;
    public Text child2_title;
    public Text resttime;
    public GameObject banana1;
    public GameObject banana2;
    public GameObject banana3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetContents()
    {
        if (date != null)
        {
            child1.GetComponentInChildren<Text>().text = date.title;
            child2_title.text = date.title;
        }
        else if (date1 != null)
        {
            child1.GetComponentInChildren<Text>().text = date1.title;
            child2_title.text = date1.title;
            resttime.text = (date1.starttime + date1.spendtime - new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)).ToString();
            if(date1.haveto == 1)
            {
                banana1.SetActive(true);
            }
            if (date1.haveto == 2)
            {
                banana2.SetActive(true);
            }
            if (date1.haveto == 3)
            {
                banana3.SetActive(true);
            }
        }
        else if (date2 != null)
        {
            child1.GetComponentInChildren<Text>().text = date2.title;
            child2_title.text = date2.title;
            resttime.text = (date2.starttime + date2.spendtime - new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)).ToString();
            if (date2.haveto == 1)
            {
                banana1.SetActive(true);
            }
            if (date2.haveto == 2)
            {
                banana2.SetActive(true);
            }
            if (date2.haveto == 3)
            {
                banana3.SetActive(true);
            }
        }

    }


    public void Onclick()
    {
        active = !active;
        if (active)
        {
            gameObject.GetComponent<RectTransform>().sizeDelta =
                new Vector2((gameObject.GetComponent<RectTransform>().sizeDelta.x), 2 * gameObject.GetComponent<RectTransform>().sizeDelta.y);
            child1.SetActive(false);
            child2.SetActive(true);
        }
        else
        {
            gameObject.GetComponent<RectTransform>().sizeDelta =
                new Vector2((gameObject.GetComponent<RectTransform>().sizeDelta.x), gameObject.GetComponent<RectTransform>().sizeDelta.y / 2);
            child1.SetActive(true);
            child2.SetActive(false);
        }
    }

    public void Finish()
    {
        Destroy(gameObject);
    }

    
}
