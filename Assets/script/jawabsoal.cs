using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jawabsoal : MonoBehaviour
{
    public GameObject feed_benar, feed_salah;
    public GameObject bintang1, bintang2, bintang3;
    // Start is called before the first frame update
    void Start(){
        
    }
    public void jawaban(bool jawab){
        int skor = PlayerPrefs.GetInt("skor");
        if(jawab){
            feed_benar.SetActive(false);
            feed_benar.SetActive(true);
            skor += 10;
            PlayerPrefs.SetInt("skor", skor);

        }else{
            feed_salah.SetActive(false);
            feed_salah.SetActive(true);

        }
        if(skor == 60 ){
            bintang1.SetActive(true);
            bintang2.SetActive(false);
            bintang3.SetActive(false);
        }else if(skor == 30 ){
            bintang1.SetActive(true);
            bintang2.SetActive(false);
            bintang3.SetActive(false);
        }
         else if(skor == 40 ){
            bintang1.SetActive(true);
            bintang2.SetActive(false);
            bintang3.SetActive(false);
        } else if(skor == 50 ){
            bintang1.SetActive(true);
            bintang2.SetActive(false);
            bintang3.SetActive(false);
        } else if(skor == 20 ){
            bintang1.SetActive(true);
            bintang2.SetActive(false);
            bintang3.SetActive(false);
        }else if(skor == 10 ){
            bintang1.SetActive(true);
            bintang2.SetActive(false);
            bintang3.SetActive(false);
        }
        
        else if (skor == 80) {
        bintang1.SetActive(true);
        bintang2.SetActive(true);
        bintang3.SetActive(false);

    } else if (skor == 70) {
        bintang1.SetActive(true);
        bintang2.SetActive(true);
        bintang3.SetActive(false);
    }
    else if(skor == 0){
        bintang1.SetActive(false);
        bintang2.SetActive(false);
        bintang3.SetActive(false);
    } 
    else {
        bintang1.SetActive(true);
        bintang2.SetActive(true);
        bintang3.SetActive(true);
    }
        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }

}