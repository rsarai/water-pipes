using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SlotCarregar : MonoBehaviour {
	private bool isDrag;
	public GameObject slot1;
	public GameObject image;
	private GameController gc;
	// Use this for initialization
	void Start () {
		gc = FindObjectOfType (typeof(GameController)) as GameController;
	}

	// Update is called once per frame
	void Update () {
		Draging ();
	}

	public void Instanciar(){
		if (transform.GetComponent<Image> ().sprite == image.GetComponent<Image>().sprite) {
			transform.GetComponent<Image> ().sprite = slot1.GetComponent<Image> ().sprite;
			slot1.GetComponent<Image> ().sprite = null;
			gc.AddScore ();
		} else {
			transform.GetComponent<Image> ().sprite = slot1.GetComponent<Image> ().sprite;
			slot1.GetComponent<Image> ().sprite = null;
			gc.SubScore ();
		}
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
