using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveOri : MonoBehaviour {

    void Start() { }

	void Update() {

        if (Input.GetMouseButtonDown(0)) SceneManager.LoadScene(1);

    }

}
