using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Click : MonoBehaviour
{
    public GameObject map;
    public VirtualButtonBehaviour Vb;

    // Use this for initialization
    void Start()
    {
        //map = GameObject.Find("Map");
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);

        map.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        map.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        map.SetActive(false);
    }
}
