using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class topKontrol : MonoBehaviour
{
    private Rigidbody rg;
    public Button btn, btn2;
    public float hiz = 1.5f;
    public Text zaman, can,tamDurum;
    float sayac=20*2;
    int canCubuk=3*2;
    bool oyunDevamKe=true;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunDevamKe)
        {

        sayac -= Time.deltaTime;
        zaman.text = (int)sayac + "";
        }
        else if (!oyunDevamKe)
        {
            tamDurum.text = "Kaybettin GG EZ";
            btn.gameObject.SetActive(true);
        }


        if (sayac<0)
        {
            oyunDevamKe = false;
        }

    }

    void FixedUpdate()
    {
        if (oyunDevamKe)
        {

            float yatay = Input.GetAxis("Horizontal");
            float dikey = Input.GetAxis("Vertical");
            Vector3 kuvvet = new Vector3(yatay, 0, dikey);
            rg.AddForce(kuvvet * hiz);
        }
        else
        {
            rg.velocity = Vector3.zero;
            rg.angularVelocity = Vector3.zero;
        }
    }

    private void OnCollisionEnter(Collision cls)
    {
        string objeismi = cls.gameObject.name;
        if (objeismi.Equals("Bitis"))
        {
            tamDurum.text= "Bence Mukammal";
            btn.gameObject.SetActive(true);
            btn2.gameObject.SetActive(true);

        }
        else if (!objeismi.Equals("lavzemin") && !objeismi.Equals("zemin"))
        {
            canCubuk = canCubuk - 1;//c -= 1
            can.text = canCubuk + "";
            if (canCubuk==0)
            {
                oyunDevamKe = false;
                tamDurum.text = "Kaybettin GG EZ";

            }

        }
    }
}
