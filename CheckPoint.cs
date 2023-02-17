using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Player.lastCheckPointPos = transform.position;
            
            Debug.Log("CheckPoint");
        }
    }
}
