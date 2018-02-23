using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text gameFinishText;
    public GameObject mainCanvas;
    public GameObject gameFinishCanvas;
    public GameObject mobileSingleStickControl;

    float countTime = 100;

	// Use this for initialization
	void Start () {
        gameFinishText.text = "";
    }

    // Update is called once per frame
    void Update () {

        if (countTime > 0.00)
        {
            //スタートしてからの秒数を格納
            countTime -= Time.deltaTime;

            //小数2桁にして表示
            GetComponent<Text>().text = countTime.ToString("F0");
        }
        else {
            //GameOver
            gameFinishText.text = "Time Up!";
            mainCanvas.SetActive(false);
            gameFinishCanvas.SetActive(true);
            mobileSingleStickControl.SetActive(false);
        }
    }
}
