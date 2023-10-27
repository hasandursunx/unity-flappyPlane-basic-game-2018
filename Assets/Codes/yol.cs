using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yol : MonoBehaviour
{
    public bool aktif;
    public bool puanmi;
    public GameObject[] objeler; // objeler dizisi
    void Start()
    {

        float altsayi = Random.Range(0, 4); // 0 ile 2 arası rastgele sayı oluşturmak
        float ustsayi = Random.Range(0, 4); // 0 ile 2 arası rastgele sayı oluşturmak

        // alt dikenin rastgele sayılarla açık kapalı olmasını belirlemek
        if (altsayi == 1)
        {
            objeler[1].SetActive(false);
        }
        else
        {
            objeler[1].SetActive(true);
        }

        // üst dikenin rastgele sayılarla açık kapalı olmasını belirlemek
        if (ustsayi == 1)
        {
            objeler[2].SetActive(false);
        }
        else
        {
            objeler[2].SetActive(true);
        }


        if (altsayi == 1 && ustsayi == 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, Random.Range(-2.5f, 2.5f));
        }
        else if (altsayi == 1 && ustsayi != 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, Random.Range(-2.5f, 0));
        }
        else if (altsayi != 1 && ustsayi == 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, Random.Range(0,2.5f));
        }
        else if (altsayi != 1 && ustsayi != 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, 0);
        }


        // diken sarkıkların -3.5 ile 3.5 arasında oluşmasını sağlıyor
        objeler[0].transform.localPosition = new Vector2(Random.Range(-2.5f, 2.5f), 0);

      

        // yıldız oluşturur
        objeler[3].SetActive(true); 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (aktif == true)
        {
            if (puanmi == true)
            {
                objeler[3].SetActive(false); // yıldızları siler
            }
            Invoke("YoluTasi",3); // yoltasi komutunu 3 saniye sonra oluşturur
            aktif = false;
        }

      
        
    }

    void YoluTasi()
    {
        float altsayi = Random.Range(0, 4); // 0 ile 2 arası rastgele sayı oluşturmak
        float ustsayi = Random.Range(0, 4); // 0 ile 2 arası rastgele sayı oluşturmak

        // alt dikenin rastgele sayılarla açık kapalı olmasını belirlemek
        if (altsayi == 1)
        {
            objeler[1].SetActive (false);
        }
        else
        {
            objeler[1].SetActive(true);
        }

        // üst dikenin rastgele sayılarla açık kapalı olmasını belirlemek
        if (ustsayi == 1 )
        {
            objeler[2].SetActive(false);
        }
        else
        {
            objeler[2].SetActive(true);
        }

        if (altsayi == 1 && ustsayi == 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, Random.Range(-2.5f, 2.5f));
        }
        else if (altsayi == 1 && ustsayi != 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, Random.Range(-2.5f, 0));
        }
        else if (altsayi != 1 && ustsayi == 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, Random.Range(0, 2.5f));
        }
        else if (altsayi != 1 && ustsayi != 1)
        {
            objeler[3].transform.localPosition = new Vector2(0, 0);
        }


      
        objeler[0].transform.localPosition = new Vector2(Random.Range(2.5f, -2.5f), 0);
        
        // pozisyonu her 3 sn bir değişsin
        transform.position = transform.position + new Vector3(40.32f, 0, 0);

        // yıldız oluşturur
        objeler[3].SetActive(true); 
    }
}
