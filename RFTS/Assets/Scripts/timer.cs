using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {

    public TextMesh CountDownText;
    public GameObject destroyPlat;
    public BoxCollider phased;
    public float countDown = 100.0f;
    bool BeginCountDown;

	// Update is called once per frame
	void Update () 
	{
        CountDown();
        NumberToText();
	}

    private void OnCollisionEnter(Collision collision)
    {
        BeginCountDown = true;
    }

    void CountDown()
    {
        if (BeginCountDown)
        {
            countDown -= 60 * Time.deltaTime;
        }
        if (countDown <= 0.1f)
        {
            phased.isTrigger = true;
            if (phased.isTrigger == true)
            {
                Destroy(destroyPlat, 0.1f);
            }
        }
    }

    void NumberToText()
    {
        //string Text = countDown.ToString();
        CountDownText.text =(Mathf.Round(countDown/100)).ToString();
    }
}
