using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startmenu : MonoBehaviour
{
    public GameObject n1;
    public GameObject n2;
    public GameObject n3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(sleep());
    }

    IEnumerator sleep()
    {
        yield return new WaitForSeconds(2f);
        n1.SetActive(true);
        n2.SetActive(true);
        n3.SetActive(true);
        Destroy(gameObject);
    }
}
