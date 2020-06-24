using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB_RotateEarth : MonoBehaviour,IVirtualButtonEventHandler
{
    public GameObject vbtn;
    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        vbtn=GameObject.Find("VButton");
        vbtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        ani.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        ani.Play("rotate_earth");
        Debug.Log("Button Pressed");
        
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        ani.Play("none");
        Debug.Log("Button Realeased");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
