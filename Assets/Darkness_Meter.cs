using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Darkness_Meter : MonoBehaviour
{
    public GameObject healthbar;
    public Slider slider;
    public Image image;
    public float presetAlpha;
    void Start()
    {
        image = GetComponent<Image>();
        slider = healthbar.GetComponent<Slider>();
    }

	private void Update()
	{
        var newAlpha = image.color;
		newAlpha.a = 1 - (slider.value/100 - presetAlpha)*(slider.value / 100 - presetAlpha);
        image.color = newAlpha;
	}
}
