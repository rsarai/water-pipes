using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanosScript : MonoBehaviour {
	private bool isDrag;
	public GameObject[] prefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Draging ();
	}

	public void Instanciar(){
		transform.GetComponent<Image> ().sprite = prefab [Random.Range (0, prefab.Length)].GetComponent<Image> ().sprite;
	}

	void Draging(){
		if (isDrag == true) {
			transform.position = Input.mousePosition;
		}
	}

	public void IsDrag(){
		isDrag = true;
	}

	public void EndDrag(){
		isDrag = false;
	}
}
