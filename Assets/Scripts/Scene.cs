using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour
{

    private AudioSource audioSource;
    public AudioClip Scored;

    private AudioSource audioSource_5;
    public AudioClip Music;


    private GameObject ScreenOptions;



    private GameObject VamosLa;
    public string NomeDaCena;
    public GameObject TestePanel;
    public GameObject TrofeuB;
    public GameObject TrofeuP;
    public GameObject TrofeuO;
    public TextMesh Teste;
    public GameObject TesteGame;
    public static bool OkRoom = false;
    public static bool OkBathroom = false;
    public static bool OkBackyard = false;
    public static GameObject TrofeuStB;
    public static GameObject TrofeuStP;
    public static GameObject TrofeuStO;
    public static bool end;

    public static int Acertos;
    public static bool ScreenAberta;
    private int QuantEntrada = 0;
    //Use this for back to map



    // Use this for initialization
    void Start()
    {
        audioSource_5 = GetComponent<AudioSource>();
        audioSource_5.clip = Music;

        // botao pause

        GameObject pause = Resources.Load("PauseCanvas") as GameObject;
        float flx = 0f;
        float fly = 0f;
        pause.transform.position = new Vector3(flx, fly ,0);
        Instantiate(pause);

        // colocar sons
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Scored;


        // carregar os objetos na tela
        TestePanel.SetActive(false);
        Acertos = 0;


        // carregar os objetos na tela
        if (NomeDaCena == "Room")
        {
            ItensRoom();
        }
        else if (NomeDaCena == "Badroom")
        {
      
        }
        else if (NomeDaCena == "Backyard")
        {
            ItensBackyard();
        }
        else if (NomeDaCena == "Bathroom")
        {
            ItensBathRoom();
        }
        else
        {
            Debug.Log("erro 404");
        }
        ScreenAberta = false;

        //carregando Trofeu
        TrofeuStB = TrofeuB;
        TrofeuStP = TrofeuP;
        TrofeuStO = TrofeuO;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
           // Application.LoadLevel("HouseMap");
        }
        if (end)
        {
            Application.LoadLevel("Home");
        }
        //string patch = Acertos.ToString();
        //   TesteGame.GetComponent<TextMesh>().text = patch + "/5";
        TestarComodo();
        if (Input.GetMouseButtonDown(0))
        {

            //Vector2 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D[] col = Physics2D.OverlapPointAll(pos);

            if (col.Length > 0)
            {
                Collider2D select = null;
                foreach (Collider2D c in col)
                {
                    if (ScreenAberta == false)
                    {
                        if (c.CompareTag("Vase"))
                        {
                            audioSource.Play();
                            QuantEntrada++;
                            select = c;
                            Debug.Log("EntrouNoVase");
                        }
                        if (c.CompareTag("Bottle"))
                        {
                            audioSource.Play();
                            QuantEntrada++;
                            select = c;
                            Debug.Log("EntrouNoBottle");
                        }
                        if (c.CompareTag("Vase2"))
                        {
                            audioSource.Play();
                            QuantEntrada++;
                            select = c;
                        }
                        if (c.CompareTag("Vase3"))
                        {
                            audioSource.Play();
                            QuantEntrada++;
                            select = c;
                        }
                        if (c.CompareTag("PocAgua"))
                        {
                            audioSource.Play();
                            QuantEntrada++;
                            select = c;
                        }
                        if (c.CompareTag("Copo"))
                        {
                            audioSource.Play();
                            QuantEntrada++;
                            select = c;

                        }
                        if (c.CompareTag("Lampada"))
                        {
                            audioSource.Play();
                            QuantEntrada++;
                            select = c;
                        }
                        if (c.CompareTag("CopoEscova"))
                        {

                            audioSource.Play();
                            QuantEntrada++;
                            select = c;
                        }
                        if (c.CompareTag("Sheets"))
                        {

                            audioSource.Play();
                            QuantEntrada++;
                            select = c;
                        }
                        if (c.CompareTag("ContainerCat"))
                        {

                            audioSource.Play();
                            QuantEntrada++;
                            select = c;
                        }
                        if (c.CompareTag("TinCan"))
                        {

                            audioSource.Play();
                            QuantEntrada++;
                            select = c;
                        }
                        if (select != null)
                        {

                            // Para abrir a tela de opções

                            ScreenOptions = Resources.Load("CanvasScreenOptions") as GameObject;
                            float fx = 0f;
                            float fy = 0f;
                            ScreenOptions.transform.position = new Vector3(fx, fy, 0);

                            Instantiate(ScreenOptions);

                            //ObjectSelectedName = select.tag;
                            // essas linha duplicar problama
                            VamosLa = select.gameObject;
                            //VamosLa.layer = 2;
                            //----------------------
                            // Options.TesteExibir = select.gameObject;
                            Options.MessageTela = TestePanel;
                            Options.TrofeuB = TrofeuB;
                            Options.TrofeuP = TrofeuP;
                            Options.TrofeuO = TrofeuO;
                            Options.TesteExibir = select.gameObject;
                        }
                        //if (QuantEntrada >= 5)//(select == null && QuantEntrada > 0)
                        //{
                        //    Application.LoadLevel("HouseMap");
                        //}
                    }//fim do if ScreenAberta


                }// fim do foreach

            }
        }
      //  VerifiTrofeu();

    }

    public static void Restart()
    {
        Application.LoadLevel("Home");
    }
    private void TestarComodo()
    {
        if (NomeDaCena == "Room")
        {
            if (QuantEntrada == 5)
            {
                Invoke("ReturnMapa",4f);
                OkRoom = true;
            }
        }
        else if (NomeDaCena =="Bathroom")
        {
            if (QuantEntrada == 3)
            {
                Invoke("ReturnMapa", 4f);
                OkBathroom = true;
            }
        }
        else if (NomeDaCena == "Backyard")
        {
            if (QuantEntrada == 3)
            {
                Invoke("ReturnMapa", 4f);
                OkBackyard = true;
            }

        }
    }
    private void ReturnMapa()
    {
        Application.LoadLevel("HouseMap");
    }

    //public  void TempoTrofeu()
    //{

    //    InvokeRepeating("VerifiTrofeu", 3f, 3f);
    //}
    private void ItensRoom()
    {
        for (int y = 1; y <= 5; y++)
        {
            //pesquisa se tem como pega o nome da cena
            GameObject go = Resources.Load("Item_" + y) as GameObject;
            //posição dos objeto
            switch (y)
            {
                case 1:
                    float fx = -0.26f;
                    float fy = 4.13f;
                    go.transform.position = new Vector3(fx, fy, 0);

                    break;

                case 2:
                    float fx2 = -0.1f;
                    float fy2 = -1.49f;
                    go.transform.position = new Vector3(fx2, fy2, 0);
                    break;
                case 3:
                    float fx3 = 6.3f;
                    float fy3 = -3.21f;
                    go.transform.position = new Vector3(fx3, fy3, 0);
                    break;
                case 4:
                    float fx4 = 0.12f;
                    float fy4 = -3.29f;
                    go.transform.position = new Vector3(fx4, fy4, 0);
                    // go.GetComponent<Animation>()
                    break;
                case 5:
                    float fx5 = 0.99f;
                    float fy5 = -1.35f;
                    go.transform.position = new Vector3(fx5, fy5, 0);
                    break;
                default:
                    Debug.Log("Não entrou");
                    break;
            }

            //instancia na tela
            Instantiate(go);
        }//fim do for

    }

    private void ItensBathRoom()
    {
        for (int y = 6; y <= 8; y++)
        {
            //pesquisa se tem como pega o nome da cena
            GameObject go = Resources.Load("Item_" + y) as GameObject;
            //posição dos objeto
            switch (y)
            {
                case 6:
                    float fx = -5.262f;
                    float fy = 3.73f;
                    go.transform.position = new Vector3(fx, fy, 0);
                    break;

                case 7:
                    float fx2 = -7.92f;
                    float fy2 = -0.82f;
                    go.transform.position = new Vector3(fx2, fy2, 0);
                    break;
                case 8:
                    float fx3 = 3.72f;
                    float fy3 = -3.71f;
                    go.transform.position = new Vector3(fx3, fy3, 0);
                    break;
                
                default:
                    Debug.Log("Não entrou");
                    break;
            }

            //instancia na tela
            Instantiate(go);
        }//fim do for

    }

    private void ItensBackyard()
    {
        for (int y = 9; y <= 11; y++)
        {
            //pesquisa se tem como pega o nome da cena
            GameObject go = Resources.Load("Item_" + y) as GameObject;
            //posição dos objeto
            switch (y)
            {
                case 9:
                    float fx = -0.53f;
                    float fy = -4.07f;
                    go.transform.position = new Vector3(fx, fy, 0);
                    break;

                case 10:
                    float fx2 = -4.94f;
                    float fy2 = -2.04f;
                    go.transform.position = new Vector3(fx2, fy2, 0);
                    break;
                case 8:
                    float fx3 = -6.2f;
                    float fy3 = -3.99f;
                    go.transform.position = new Vector3(fx3, fy3, 0);
                    break;

                default:
                    Debug.Log("Não entrou");
                    break;
            }

            //instancia na tela
            Instantiate(go);
        }//fim do for

    }
    //   public void VerifiTrofeu()
    //  {
    //    if (TrofeuStO.activeSelf == true)
    //    {
    //       Invoke("DesativarTO", 6f);
    //   }
    //    if (TrofeuStB.activeSelf == true)
    //    {
    //        Invoke("DesativarTB", 6f);
    //   }
    //    if (TrofeuStP.activeSelf == true)
    //    {
    //       Invoke("DesativarTP", 6f);
    //   }
    //   }
    //    public void DesativarTB()
    //  {
    //       TrofeuStB.SetActive(false);
    //  }
    //  public void DesativarTO()
    //  {
    //      TrofeuStO.SetActive(false);
    //  }
    //  public void DesativarTP()
    //   {
    //      TrofeuStP.SetActive(false);
    // }

    public void OnPauseButton()
    {


       GameObject ScreenPause = Resources.Load("ScreenPause_1") as GameObject;
        float fx = 0f;
        float fy = 0f;
        ScreenPause.transform.position = new Vector3(fx, fy, 0);
        Instantiate(ScreenPause);
    }
  }


