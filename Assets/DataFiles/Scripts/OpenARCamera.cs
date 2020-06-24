using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenARCamera : MonoBehaviour
{
    public void open()
    {
        SceneManager.LoadScene("AR_SolarSystem");
    }
}
