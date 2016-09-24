using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AguaScript : MonoBehaviour {
	public Slider slider;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		slider.value += Time.deltaTime*0.01f;
	}
}
