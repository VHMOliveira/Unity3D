using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
    //MeshRenderer obj;
    Material obj;
    Color baseColor;
	// Use this for initialization
	void Start () {
        obj = this.GetComponent<Renderer>().material;
        baseColor = obj.color;
	}

    public void changeColor() {
        obj.color = Color.white;
    }

    public void resetColor()
    {
        obj.color = baseColor;
    }
}
