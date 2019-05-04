using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Button : MonoBehaviour
{
    //変数宣言
    public List<GameObject> ObjectToActivate, ObjectToInactivate;
    //public string ActTag, InactTag;


    // 有効化
    public void Activate (){
        //ObjectToActivate.AddRange(GameObject.FindGameObjectsWithTag(ActTag).ToList());
        //Debug.Log(GameObject.FindGameObjectsWithTag(ActTag).ToList().Count);
        //Debug.Log(ActTag);
        foreach(GameObject act in ObjectToActivate){
            Debug.Log(act);
            act.SetActive(true);
        }
    }

    // 無効化
    public void Inactivate (){
        //ObjectToActivate.AddRange(GameObject.FindGameObjectsWithTag(InactTag).ToList());
        //Debug.Log(GameObject.FindGameObjectsWithTag(InactTag).ToList().Count);
        //Debug.Log(InactTag);
        foreach (GameObject inact in ObjectToInactivate){
            Debug.Log(inact);
            inact.SetActive(false);
        }
    }
}