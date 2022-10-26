using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderScript : MonoBehaviour
{
    private float score;
    public Text scoretxt;
    public GameObject gamewin;

    // Start is called before the first frame update
    void Start()
    {
        gamewin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(score >= 30)
        {
            gamewin.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Obstacle"))
        {
            score++;
            scoretxt.text = "Score : " + score;
        }
    }
}
