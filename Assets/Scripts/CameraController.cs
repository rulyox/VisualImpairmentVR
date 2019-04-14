using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public WebCamTexture mCamera = null;
	public GameObject Plane;

	void Start () {
		Plane = GameObject.FindWithTag ("Player");

		mCamera = new WebCamTexture ();
		Plane.GetComponent<Renderer>().material.mainTexture = mCamera;
		mCamera.Play ();

	}

}