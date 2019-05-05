using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


    class CriateTaskButton:MonoBehaviour
    {
        public RestoreSchedules admin;

        public void Onclick()
        {
            if(admin.state == State.everyday)
            {
                GameObject obj = (GameObject)Resources.Load("input_regularly");
                Instantiate(obj, Vector2.zero, Quaternion.identity);
            }

            if(admin.state == State.today)
            {
                GameObject obj = (GameObject)Resources.Load("input_today");
                Instantiate(obj, Vector2.zero, Quaternion.identity);
            }

            if(admin.state == State.want)
            {
            GameObject obj = (GameObject)Resources.Load("input_today");
            Instantiate(obj, Vector2.zero, Quaternion.identity);
            }
        }
    }

