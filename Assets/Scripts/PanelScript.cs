using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PanelScript : MonoBehaviour {
	public GameObject slot1; 
	public GameObject slot2; 
	public GameObject slot3; 
	public GameObject slot4; 
	public GameObject[] prefab;


	// Use this for initialization
	void Start () {
		slot1.GetComponent<Image> ().sprite = prefab [Random.Range (0, prefab.Length)].GetComponent<Image> ().sprite;
		slot2.GetComponent<Image> ().sprite = prefab [Random.Range (0, prefab.Length)].GetComponent<Image> ().sprite;
		slot3.GetComponent<Image> ().sprite = prefab [Random.Range (0, prefab.Length)].GetComponent<Image> ().sprite;
		slot4.GetComponent<Image> ().sprite = prefab [Random.Range (0, prefab.Length)].GetComponent<Image> ().sprite;
	}
	
	// Update is called once per frame
	void Update () {
		Ordenar ();
	}

	void Ordenar(){
		if(slot1.GetComponent<Image>().sprite == null){
			slot1.GetComponent<Image> ().sprite = slot2.GetComponent<Image> ().sprite;
			slot2.GetComponent<Image> ().sprite = slot3.GetComponent<Image> ().sprite;
			slot3.GetComponent<Image> ().sprite = slot4.GetComponent<Image> ().sprite;
			slot4.GetComponent<Image> ().sprite = prefab [Random.Range (0, prefab.Length)].GetComponent<Image> ().sprite;
		}
	}
}
