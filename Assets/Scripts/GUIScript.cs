using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIScript : MonoBehaviour
{
    

    
    public void onrestart()
    {
        SceneManager.LoadScene(0);
    }
   
}
