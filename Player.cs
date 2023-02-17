using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static Vector3 lastCheckPointPos = new Vector3(0,3,0);

    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
    }
}
