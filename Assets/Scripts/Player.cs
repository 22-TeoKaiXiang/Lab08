using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public GameObject gamelose;
    

    // Start is called before the first frame update
    void Start()
    {
        gamelose.SetActive(false);
        
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        if(transform.position.y >= 6.5)
        {
            transform.position = new Vector3(-7.84f, 6.5f, 0.008284654f);
        }
        if (transform.position.y <= -4)
        {
            transform.position = new Vector3(-7.84f, -4f, 0.008284654f);
        }
        
        

    }
    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Obstacle"))
        {
            gamelose.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
