using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class son : MonoBehaviour
{
    // Start is called before the first frame update

    int toplamhayvan = 4;
    int ilkhayvan = 0;
   public void levelson() {
        ilkhayvan++;
        if (ilkhayvan==toplamhayvan)
        {
            Debug.Log("OYUN BİTTİ");
        }
    
    }
}
