using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Item : MonoBehaviour
{
    // Para abrir a tela de opções
    // no momento está sendo objetos para cada componente e isto não é interessante
    //GameObject ScreenOptions;
    //private GameObject VamosLa;
    //private bool Entrou = false;
    //public static GameObject ObejteExibr;

    void Start()

    {

    }

    // Update is called once per frame
    void Update()
    {


        ////if (Input.touchCount > 0)
        //if (Input.GetMouseButtonDown(0) && !Entrou)
        //{
        //    Entrou = true;
        //    //Vector2 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        //    Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //    Collider2D[] col = Physics2D.OverlapPointAll(pos);

        //    if (col.Length > 0)
        //    {
        //        Collider2D select = null;
        //        foreach (Collider2D c in col)
        //        {
        //            if (c.CompareTag("Vase"))
        //            {

        //                select = c;
        //                Debug.Log("EntrouNoVase");
        //            }
        //            if (c.CompareTag("Bottle"))
        //            {

        //                select = c;
        //                Debug.Log("EntrouNoBottle");
        //            }

        //        }
        //        // VER SE ESTE CODIGO ESTÁ FAZENDO Ñ ENTRAR 
        //        if (select != null)
        //        {

        //            //// Para abrir a tela de opções
        //            //ScreenOptions = Resources.Load("CanvasScreenOptions") as GameObject;
        //            //float fx = 0f;
        //            //float fy = 0f;
        //            //ScreenOptions.transform.position = new Vector3(fx, fy, 0);
        //            //Instantiate(ScreenOptions);

        //            //Entrou = false;
        //            ////ObjectSelectedName = select.tag;
        //            //// essas linha duplicar problama
        //            //VamosLa = select.gameObject;
        //            ////VamosLa.layer = 2;
        //            ////----------------------
        //            //// Options.TesteExibir = select.gameObject;
        //            //Options.TesteExibir = VamosLa;
        //        }
        //    }

        //}
    }


}
