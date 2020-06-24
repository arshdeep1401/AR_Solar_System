using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScale : MonoBehaviour
{
    public Slider ScaleSlider;
    // Start is called before the first frame update
    void Start()
    {
        ScaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AdjustScale(float newScale)
    {
        transform.localScale = new Vector3(newScale*ScaleSlider.value, newScale*ScaleSlider.value, newScale*ScaleSlider.value);
    }
}
