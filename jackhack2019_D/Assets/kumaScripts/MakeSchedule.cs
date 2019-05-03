using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeSchedule : MonoBehaviour
{
    public void CriateScheduleForm(Dropdown dropdown)
    {
        GameObject obj = null;
        switch (dropdown.value)
        {
            case 0:
                obj = (GameObject)Resources.Load("FixForm"); break;
            case 1:
                obj = (GameObject)Resources.Load("OneFixForm"); break;
            case 2:
                obj = (GameObject)Resources.Load("OneForm");break;
        }
        Instantiate(obj,GameObject.Find("Canvas").transform);
    }
}
