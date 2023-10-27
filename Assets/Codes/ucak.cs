using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ucak : MonoBehaviour
{
    public float hiz, yukselisHizi,mesafe,skormesafe;
    public Transform baslangicNoktasi;
    public Text mesafeYazi,oyunSonuMesafeYazi,skorMesafeYazi;
    public GameObject baslangicPanel, oyunsonuPanel, oyunPanel;
    void Start()
    {
        baslangicPanel.SetActive(true);
        oyunPanel.SetActive(false);
        oyunsonuPanel.SetActive(false);
        hiz = 0;
        yukselisHizi = 0;
        GetComponent<Rigidbody2D>().gravityScale = 0;
        
    }

    void Update()

    {
        mesafeYazi.text = (int)mesafe + "M";

        // ucagin bulunduğu konum ile kendi konumu arasındaki mesafeyi ölçme
        mesafe = Vector2.Distance(baslangicNoktasi.position, transform.position);
    
        transform.Translate(hiz*Time.deltaTime,0,0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * yukselisHizi);
        }
    }

    void OnTriggerEnter2D(Collider2D nesne)
    {
        if (nesne.gameObject.tag == "Gecis")
        {
            nesne.gameObject.transform.root.gameObject.GetComponent<yol> ().aktif = true;
        }
    }

    void OnCollisionEnter2D(Collision2D nesne)
    {
        if (nesne.gameObject.tag == "Engel")
        {
            Time.timeScale = 0;
            OyunSonu();
        }
    }

    public void Butonlar(int i)
    {
        if(i == 0)
        {
            hiz = 5;
            yukselisHizi = 300;
            GetComponent<Rigidbody2D>().gravityScale = 1;
            oyunPanel.SetActive(true);
            baslangicPanel.SetActive(false);
        }
    }

    public void OyunSonu()
    {
        oyunPanel.SetActive(false);
        oyunsonuPanel.SetActive(true);
        oyunSonuMesafeYazi.text = "Mesafe : " + (int)mesafe + " M ";

        skormesafe = PlayerPrefs.GetFloat("SkorMesafemiz");
        if (skormesafe > mesafe)
        {
            skorMesafeYazi.text = "Skor Mesafe : " + (int)skormesafe + "M";
        }
        else
        {
            skormesafe = mesafe;
            PlayerPrefs.SetFloat("SkorMesafemiz", skormesafe);
            skorMesafeYazi.text = "Skor Mesafe : " + (int)skormesafe + "M";

        }
    }
}
