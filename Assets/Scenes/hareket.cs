using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    // Start is called before the first frame update
    Camera kamera;
    GameObject[] golgeler;
    Vector2 baslangic_pozisyon;
    son son_script;
    void Start()
    {
        kamera = GameObject.Find("camera").GetComponent<Camera>();
        golgeler = GameObject.FindGameObjectsWithTag("golge");
        baslangic_pozisyon = transform.position;
        
        son_script = GameObject.Find("son").GetComponent<son>() ;
    }
    private void OnMouseDrag()
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject golge in golgeler)
            {
                if (gameObject.name == golge.name) {
                    float mesafe = Vector3.Distance(golge.transform.position, transform.position);
                    if (mesafe <=3)
                    {
                        transform.position = golge.transform.position;
                        Destroy(this);
                        son_script.levelson();
                    }
                    else {
                        transform.position = baslangic_pozisyon;
                    }
                
                }
            }
        }

    }
}
