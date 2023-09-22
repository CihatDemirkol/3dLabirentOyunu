using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void yenidenBasla()
    {
        SceneManager.LoadScene(0);

    }
    public void sonrakiOyun()
    {
        SceneManager.LoadScene(1);
    }


}
