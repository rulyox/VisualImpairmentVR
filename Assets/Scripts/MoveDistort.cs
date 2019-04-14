using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveDistort : MonoBehaviour {

    float time = 0.0f;

    void Start() { }

    void Update() {

        time += Time.deltaTime;
        if (time >= 10.0f) SceneManager.LoadScene(3);

    }

}
