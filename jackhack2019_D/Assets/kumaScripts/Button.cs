using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    //変数宣言
    public List<GameObject> ObjectToActivate, ObjectToInactivate;

    // 有効化
    public void Activate (){
        ObjectToActivate.AddRange(GameObject.FindGameObjectsWithTag(""));
        foreach(GameObject act in ObjectToActivate){
            act.SetActive(true);
        }
    }

    // 無効化
    public void Inactivate (){
        ObjectToActivate.AddRange(GameObject.FindGameObjectsWithTag(""));
        foreach (GameObject inact in ObjectToInactivate){
            inact.SetActive(false);
        }
    }
}