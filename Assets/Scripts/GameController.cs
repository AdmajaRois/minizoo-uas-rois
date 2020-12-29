using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject buttonHarimau;
    public GameObject buttonIguana;
    public GameObject buttonCat;
    public GameObject buttonElang;
    public GameObject buttonExit;
    public GameObject panel;
    public GameObject closePanel;

    public Text title;
    public Text description;

    //blok fungsi untuk menampilkan tombol

    public void showButtonHarimau() {
        buttonHarimau.SetActive(true);
    }

    public void showButtonIguana() {
        buttonIguana.SetActive(true);
    }

    public void showButtonCat() {
        buttonCat.SetActive(true);
    }

    public void showButtonElang() {
        buttonElang.SetActive(true);
    }

    //blok fungsi untuk menyembunyikan tombol jika gambar tidak diperlihatkan

    public void hideButtonElang() {
        buttonElang.SetActive(false);
    }  

     public void hideButtonHarimau() {
        buttonHarimau.SetActive(false);
    }  

     public void hideButtonIguana() {
        buttonIguana.SetActive(false);
    }  

     public void hideButtonCat() {
        buttonCat.SetActive(false);
    }  

    //Keluar dari game kembali ke menu utama
    public void exitButton() {
        SceneManager.LoadScene("intro");
    }

    //menambahkan panel deskripsi pada game

    public void showPanelHarimau() {
        title.text = "Harimau";
        description.text = "Harimau adalah hewan yang tergolong dalam filum Chordata, subfilum vertebrata, kelas mamalia, pemakan daging, keluarga felidae, genus panthera, dan tergolong dalam spesies tigris";
        showPanel();
    }

    public void showPanelCat() {
        title.text = "Kucing";
        description.text = "Kucing disebut juga kucing domestik atau kucing rumah adalah sejenis mamalia karnivora dari keluarga Felidae";
        showPanel();
    }

    public void showPanelIguana() {
        title.text = "Iguana";
        description.text = "Iguana adalah marga kadal yang hidup di daerah tropis Amerika Tengah, Amerika Selatan, dan kepulauan Karibia.";
        showPanel();
    }

    public void showPanelElang() {
        title.text = "Elang";
        description.text = "Elang merupakan salah satu dari hewan yang terdapat di seluruh Indonesia.";
        showPanel();
    }

    //menampilkan panel
    public void showPanel() {
        panel.SetActive(true);
        closePanel.SetActive(true);
    }

    //menutup panel
    public void hidePanel() {
        panel.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
