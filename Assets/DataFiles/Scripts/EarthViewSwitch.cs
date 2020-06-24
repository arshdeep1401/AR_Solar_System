using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EarthViewSwitch : MonoBehaviour
{
    public void earthView()
    {
        SceneManager.LoadScene("AR_SolarSystem");
    }
}
