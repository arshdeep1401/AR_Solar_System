using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoreViewSwitch : MonoBehaviour
{
    public void coreView()
    {
        SceneManager.LoadScene("EarthCoreScene"); 
    }
}
