using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class custominput : MonoBehaviour
{
    [SerializeField] GameObject Canvas;
    public void onMenu() => Canvas.SetActive(!Canvas.activeInHierarchy);

    //public void onMenu()
    //{
    //    Debug.Log("Menu button has been pressed,yay!");

    //}
}
