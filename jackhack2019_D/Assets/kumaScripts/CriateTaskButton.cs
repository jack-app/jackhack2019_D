using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


    class CriateTaskButton:MonoBehaviour
    {
        public RestoreSchedules admin;
        public GameObject parent;

        public void Onclick()
        {
            if(admin.state == State.everyday)
            {
                GameObject obj = (GameObject)Resources.Load("input_regularly");
                Instantiate(obj,parent.transform);
            }

            if(admin.state == State.today)
            {
                GameObject obj = (GameObject)Resources.Load("input_today");
                Instantiate(obj,parent.transform);
            }

            if(admin.state == State.want)
            {
            GameObject obj = (GameObject)Resources.Load("input_today");
            Instantiate(obj,parent.transform);
            }
        }
    }

