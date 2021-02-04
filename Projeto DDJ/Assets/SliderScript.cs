using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{

    public GameObject greenBird;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = greenBird.GetComponent<Green_Bird_Script>().maxHP;
        slider.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = greenBird.GetComponent<Green_Bird_Script>().hp;
    }
}
