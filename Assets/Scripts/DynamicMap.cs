using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DynamicMap : MonoBehaviour {

    // Use this for initialization
    private bool SalaLimpa;
    private bool BanheiroLimpo;
    private bool QuintalLimpo;
    public static bool Fim= false;
    private AudioSource audioSource;
    public AudioClip Scored;

    private AudioSource audioSource_5;
    public AudioClip Music;

    public Animator CenSala;
    public Animator CenBanheiro;
    public Animator CenQuintal;
    public GameObject GameBanheiro;
    public GameObject GameQuintal;
    public GameObject GameSala;
    public GameObject TroufeuCem;
    private bool ReiDyna;
    void Start()
    {
        ReiDyna = change.Reiniciar;
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Scored;

        audioSource_5 = GetComponent<AudioSource>();
        audioSource_5.clip = Music;
        CenBanheiro.GetComponent<Animator>().enabled = false;
        CenQuintal.GetComponent<Animator>().enabled = false;
        CenSala.SetBool("Pronto", false);
        GameBanheiro.GetComponent<Collider2D>().enabled = false;
        CenBanheiro.SetBool("Pronto", false);
        GameQuintal.GetComponent<Collider2D>().enabled = false;
        CenQuintal.SetBool("Pronto", false);
        if (ReiDyna)
        {
            Scene.OkBackyard = false;
            Scene.OkBathroom = false;
            Scene.OkRoom = false;
        }
        
        SalaLimpa = false;
        BanheiroLimpo = false;
        QuintalLimpo = false;
        
       
    }

    // Update is called once per frame
    void Update()
    {
        SalaLimpa = Scene.OkRoom;
        BanheiroLimpo = Scene.OkBathroom;
        QuintalLimpo = Scene.OkBackyard;
        desbolquear();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Home");
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D[] col = Physics2D.OverlapPointAll(pos);

            if (col.Length > 0)
                foreach (Collider2D c in col)
                {
                    //Para abrir o cômodo sala
                    if (c.CompareTag("LoadRoom"))
                    {
                        audioSource.Play();
                        Application.LoadLevel("Room");
                        SalaLimpa = true;
                    }
                    if (c.CompareTag("LoadBathroom"))
                    {
                        // ver se a sala já foi clicada
                        audioSource.Play();
                        Application.LoadLevel("Bathroom");
                        BanheiroLimpo = true;
                   
                    }
                    if (c.CompareTag("LoadBackyard"))
                    {
                        audioSource.Play();
                        Application.LoadLevel("Backyard");

                    }
                }


           
        }
    }
    void desbolquear()
    {
        if (SalaLimpa)
        {
            GameSala.GetComponent<Collider2D>().enabled = false;
            CenSala.SetBool("Pronto",true);
           // GameSala.GetComponent<Animator>().enabled = false;
            CenBanheiro.SetBool("Pronto", false);
            GameBanheiro.GetComponent<Collider2D>().enabled = true;
            GameBanheiro.GetComponent<Animator>().enabled = true;
        }
        if (BanheiroLimpo)
        {
            GameBanheiro.GetComponent<Collider2D>().enabled = false;
            CenBanheiro.SetBool("Pronto", true);
            CenQuintal.SetBool("Pronto", false);
            GameQuintal.GetComponent<Collider2D>().enabled = true;
            GameQuintal.GetComponent<Animator>().enabled = true;
        }
        if (QuintalLimpo)
        {
            GameQuintal.GetComponent<Collider2D>().enabled = false;
            CenQuintal.SetBool("Pronto", true);
          
            GameQuintal.GetComponent<Collider2D>().enabled = false;
            Invoke("FimJogo", 3f);
        }

    }
    private void FimJogo()
    {
        change.Reiniciar = true;
        Application.LoadLevel("Home");

    }
}
