using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title2Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager.UnloadScene("Main");

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Main");
        }
	}
}
