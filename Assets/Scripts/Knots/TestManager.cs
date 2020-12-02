using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestManager : MonoBehaviour
{

    public Text tittle;
    public Text instruction;
    public ScrollRect scrollView;

    private string[] tils = { "1. DEFINE LOS SIGUIENTES TÉRMINOS",
                            "2. CÓMO CUIDAR LA CUERDA",
                            "3. CUERDA DE TRES FIBRAS Y CUERDA LISA (CON ALMA)",
                            "4. IDENTIFICA LAS SIGUIENTES CLASES DE CUERDA",
                            "5. LA CUERDA SINTÉTICA",
                            "6. IDENTIFICA LO SSIGUIENTES NUDOS"};

    private string[] ins = { "Relaciona cada definición con su concepto correspondiente:",
                            "Selecciona todas aquellas acciones que hacen referencia a un buen cuidado de las cuerdas.",
                            "¿Cuáles son las diferencias entre una cuerda lisa y la de 3 fibras?",
                            "Escoge entre Manila, Sisal, Nylon y Polipropileno",
                            "¿Cuáles son algunas de las ventajas de la cuerda sintética?",
                            "Elige el nombre del nudo en cada imagen."};

    public GameObject q1;
    public GameObject q2;
    public GameObject q3;
    public GameObject q4;
    public GameObject q5;
    public GameObject q6;
    public Button prev;
    public Button next;
    public GameObject panel_terminar;
    private GameObject current_question;
    private GameObject[] questions;
    private int i = -1;
    private float score = 0;


    // Start is called before the first frame update
    void Start()
    {
        current_question = GameObject.FindGameObjectWithTag("Panel");
        questions = new GameObject[tils.Length];
        questions[0] = q1;
        questions[1] = q2;
        questions[2] = q3;
        questions[3] = q4;
        questions[4] = q5;
        questions[5] = q6;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextQuestion()
    {
        if (i==-1) {
            scrollView.gameObject.SetActive(true);
            prev.gameObject.SetActive(true);
            next.gameObject.SetActive(true);
        }
        if (i+1 < tils.Length) {
            current_question.gameObject.SetActive(false);
            i += 1;
            tittle.text = tils[i];
            instruction.text = ins[i];
            current_question = questions[i];
            Debug.Log(current_question);
            current_question.gameObject.SetActive(true);
        } else {
            TestFinished();
        }
    }

    public void PrevQuestion()
    {
        if (i-1 >= 0) {
            current_question.gameObject.SetActive(false);
            i -= 1;
            tittle.text = tils[i];
            instruction.text = ins[i];
            current_question = questions[i];
            current_question.gameObject.SetActive(true);
        }
    }

    void TestFinished()
    {
        panel_terminar.gameObject.SetActive(true);
    }

    public void CancelFinished()
    {
        panel_terminar.gameObject.SetActive(false);
    }
}
