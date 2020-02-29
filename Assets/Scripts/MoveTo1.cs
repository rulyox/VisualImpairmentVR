using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveTo1 : MonoBehaviour {

    void Start() { }

	void Update() {

        if (Input.GetMouseButtonDown(0)) SceneManager.LoadScene(1);

    }

}
