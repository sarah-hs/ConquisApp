using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InterfazUsuario : MonoBehaviour{
    public GameObject menu;
    public GameObject menuGanador;
    public Slider sliderDificultad;
    public Text textoDificultad;

    public bool menuMostrado;
    public bool menuMostradoGanador;
    public int dificultad;

    void Start() {
        CambiarDificultad();
    }

    public void MostrarMenu(){
        menu.SetActive(true);
        menuMostrado = true;
    }

    public void EsconderMenu(){
        menu.SetActive(false);
        menuMostrado = false;
    }

    public void MostrarMenuGanador(){
        menuGanador.SetActive(true);
        menuMostradoGanador = true;
    }

    public void EsconderMenuGanqador(){
        menuGanador.SetActive(false);
        menuMostradoGanador = false;
    }

    public void CambiarDificultad(){
        dificultad = (int)sliderDificultad.value * 2;
        textoDificultad.text = "Dificultad: " + dificultad;
    }
}
