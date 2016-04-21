using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Options : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip Scored;

    private AudioSource audioSource_2;
    public AudioClip Hit;

    private AudioSource audioSource_3;
    public AudioClip Missed;

    private AudioSource audioSource_4;
    public AudioClip Win;

    private GameObject IntensNaTela;

    public static GameObject TesteExibir;
    public Button Limpar;
    public Button JogarFora;
    public Button Reparar;
    public Button Reciclar;
    public Button Tampar;
    public Button Guardar;
    public GameObject Certo1;
    public GameObject Certo2;
    public GameObject Certo3;
    public GameObject Erro1;
    public GameObject Erro2;
    public GameObject Erro3;
    
    int ObCertos = 0;
    int erro = 0;
    // Para fechar a Tela de Opções só que não está legal pois está chamando ela no inspector
    public GameObject ScreenOptions;
    //------

    //Para o panel:
    public static GameObject MessageTela;
    public static GameObject TrofeuB;
    public static GameObject TrofeuP;
    public static GameObject TrofeuO;

    // Use this for 
    void Start()
    {
        //colocar sons
        //click
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Scored;

        //acertar um abjeto
        audioSource_2 = GetComponent<AudioSource>();
        audioSource_2.clip = Hit;

        //Errar um objeto
        audioSource_3 = GetComponent<AudioSource>();
        audioSource_3.clip = Missed;

        // Ganhou troféu
        audioSource_4 = GetComponent<AudioSource>();
        audioSource_4.clip = Win;

        // Exibir Itens na Screen Options 
        float fx = -25.736f;
        float fy = 49.5f;
        IntensNaTela = (GameObject)Instantiate(TesteExibir, new Vector3(fx, fy, 0), Quaternion.identity);
       // string pacth = TesteExibir.name;
        //outra coisa
        // pacth.Replace("C", string.Empty);
        //string Prop = "_Prop";
        //string usada = "";
        //usada = "Item_" + pacth[5] + Prop;
        //Debug.Log(usada);
        // IntensNaTela = (GameObject)Resources.Load(usada);







        //outra coisa

        IntensNaTela.GetComponent<SpriteRenderer>().sortingOrder = 5;
        IntensNaTela.transform.SetParent(transform);
        // Instantiate(IntensNaTela);
        //IntensNaTela.transform.parent = transform;
        //IntensNaTela.transform.localPosition = new Vector3(-157f, 5.0f, 0.0f);
        IntensNaTela.transform.localPosition = new Vector3(6f, 24f, 0.0f);
        IntensNaTela.GetComponent<RectTransform>().sizeDelta = new Vector2(473, 668);
        
        IntensNaTela.transform.localScale = new Vector3(1, 1, 0);
        // pegar o nome de TesteExibir e carregar um pref dele com proporção
        IntensNaTela.GetComponent<RectTransform>().anchorMax = new Vector2(0.287f, 0.46762f);
        IntensNaTela.GetComponent<RectTransform>().anchorMin = new Vector2(0.287f, 0.46762f);
        IntensNaTela.GetComponent<Collider2D>().enabled = false;
       
        erro = 0;
        Scene.ScreenAberta = true;
        //---------
    }



    // Update is called once per frame
    void Update()
    {


    }
    public void OnClearButton()
    {
         audioSource.Play();
        if (TesteExibir.CompareTag("Vase"))
        {
            audioSource_2.Play();
            Scene.Acertos++;
            MessagemNaTela();
            AcertoNaScreen(ObCertos);
            IntensNaTela.GetComponent<Image>().sprite = Resources.Load("planta_limpi", typeof(Sprite)) as Sprite;
            TesteExibir.GetComponent<SpriteRenderer>().sprite = Resources.Load("planta_limpi", typeof(Sprite)) as Sprite;
            //IntensNaTela.GetComponent<Image>().sprite = 
            TesteExibir.GetComponent<Collider2D>().enabled = false;
          
        }
        else if (TesteExibir.CompareTag("Vase2"))
        {
            audioSource_2.Play();
            Scene.Acertos++;
            MessagemNaTela();
            AcertoNaScreen(ObCertos);
            IntensNaTela.GetComponent<Image>().sprite = Resources.Load("plantinha 2", typeof(Sprite)) as Sprite;
            TesteExibir.GetComponent<SpriteRenderer>().sprite = Resources.Load("plantinha 2", typeof(Sprite)) as Sprite;
            //TesteExibir.GetComponent<Collider2D>().enabled = false;
           
        }
        else if (TesteExibir.CompareTag("Vase3"))
        {
            Scene.Acertos++;
            audioSource_2.Play();
            MessagemNaTela();
            AcertoNaScreen(ObCertos);
            IntensNaTela.GetComponent<Image>().sprite = Resources.Load("plantipsicodelica", typeof(Sprite)) as Sprite;
            TesteExibir.GetComponent<SpriteRenderer>().sprite = Resources.Load("plantipsicodelica", typeof(Sprite)) as Sprite;

        }
        else if (TesteExibir.CompareTag("PocAgua"))
        {
            audioSource_2.Play();
            Scene.Acertos++;
            IntensNaTela.GetComponent<Image>().sprite = Resources.Load("5", typeof(Sprite)) as Sprite;
            MessagemNaTela();
            AcertoNaScreen(ObCertos);
            // IntensNaTela.GetComponent<Animator>().SetBool("Limpando", true);
          
            TesteExibir.GetComponent<Animator>().SetBool("Limpando", true);
        }
        else if (TesteExibir.CompareTag("Copo"))
        {
            audioSource_2.Play();
            Scene.Acertos++;
            MessagemNaTela();
            AcertoNaScreen(ObCertos);
            IntensNaTela.GetComponent<Image>().sprite = Resources.Load("copi sem dengue", typeof(Sprite)) as Sprite;
            TesteExibir.GetComponent<SpriteRenderer>().sprite = Resources.Load("copi sem dengue", typeof(Sprite)) as Sprite;

          
        }
        else if (TesteExibir.CompareTag("CopoEscova"))
        {
            audioSource_2.Play();
            Scene.Acertos++;
            MessagemNaTela();
            AcertoNaScreen(ObCertos);
            IntensNaTela.GetComponent<Image>().sprite = Resources.Load("CopoEscovaLimpo", typeof(Sprite)) as Sprite;
            TesteExibir.GetComponent<SpriteRenderer>().sprite = Resources.Load("CopoEscovaLimpo", typeof(Sprite)) as Sprite;
        }
        else if (TesteExibir.CompareTag("Sheets"))
        {
            audioSource_2.Play();
            Scene.Acertos++;
            MessagemNaTela();
            AcertoNaScreen(ObCertos);
            IntensNaTela.GetComponent<Image>().sprite = Resources.Load("5", typeof(Sprite)) as Sprite;
            TesteExibir.GetComponent<SpriteRenderer>().sprite = Resources.Load("5", typeof(Sprite)) as Sprite;
        }
        else if (TesteExibir.CompareTag("ContainerCat"))
        {
            audioSource_2.Play();
            Scene.Acertos++;
            MessagemNaTela();
            AcertoNaScreen(ObCertos);
            IntensNaTela.GetComponent<Image>().sprite = Resources.Load("tigela do gatinho limpa", typeof(Sprite)) as Sprite;
            TesteExibir.GetComponent<SpriteRenderer>().sprite = Resources.Load("tigela do gatinho limpa", typeof(Sprite)) as Sprite;
        }
       
        else
        {
            erro++;
            ErroNaScreen(erro);
            Limpar.GetComponent<Button>().interactable = false;
            Limpar.interactable = false;
        }

    }

    public void OnRepairButton()

    {
        audioSource.Play();
        if (TesteExibir.CompareTag("Lampada"))
        {
            audioSource_2.Play();
            Scene.Acertos++;
            AcertoNaScreen(Scene.Acertos);
            IntensNaTela.GetComponent<Image>().sprite = Resources.Load("lampi boa", typeof(Sprite)) as Sprite;
            TesteExibir.GetComponent<SpriteRenderer>().sprite = Resources.Load("lampi boa", typeof(Sprite)) as Sprite;
            MessagemNaTela();
        }

        else
        {
            audioSource_3.Play();
            erro++;
            ErroNaScreen(erro);
            Reparar.GetComponent<Button>().interactable = false;
            Reparar.interactable = false;
        }
    }

    public void OnThrowAwayButton()
    {
        audioSource.Play();
        if (TesteExibir.CompareTag("teste"))
        {
            audioSource_2.Play();
            Scene.Acertos++;
            AcertoNaScreen(Scene.Acertos);
            IntensNaTela.GetComponent<Image>().sprite = Resources.Load("", typeof(Sprite)) as Sprite;
            TesteExibir.GetComponent<SpriteRenderer>().sprite = Resources.Load("", typeof(Sprite)) as Sprite;
            MessagemNaTela();
        }
        else if (TesteExibir.CompareTag("TinCan"))
        {
            audioSource_2.Play();
            Scene.Acertos++;
            MessagemNaTela();
            AcertoNaScreen(ObCertos);
            IntensNaTela.GetComponent<Image>().sprite = Resources.Load("5", typeof(Sprite)) as Sprite;
            TesteExibir.GetComponent<SpriteRenderer>().sprite = Resources.Load("5", typeof(Sprite)) as Sprite;
        }
        else
        {
            audioSource_3.Play();
            erro++;
            ErroNaScreen(erro);
            JogarFora.GetComponent<Button>().interactable = false;
            JogarFora.interactable = false;
        }
    }

    public void OnCoverButton()

    {
        audioSource.Play();
        if (TesteExibir.CompareTag("teste"))
        {
            audioSource_2.Play();
            Scene.Acertos++;
            AcertoNaScreen(Scene.Acertos);
            IntensNaTela.GetComponent<Image>().sprite = Resources.Load("", typeof(Sprite)) as Sprite;
            TesteExibir.GetComponent<SpriteRenderer>().sprite = Resources.Load("", typeof(Sprite)) as Sprite;
            MessagemNaTela();
        }

        else
        {
            audioSource_3.Play();
            erro++;
            ErroNaScreen(erro);
            Tampar.GetComponent<Button>().interactable = false;
            Tampar.interactable = false;
        }

    }

    public void OnRecycleButton()
    {
        audioSource.Play();
        if (TesteExibir.CompareTag("Bottle"))
        {
            audioSource_2.Play();
            Scene.Acertos++;
            AcertoNaScreen(Scene.Acertos);
            IntensNaTela.GetComponent<Image>().sprite = Resources.Load("garrafi limpi", typeof(Sprite)) as Sprite;
            TesteExibir.GetComponent<SpriteRenderer>().sprite = Resources.Load("garrafi limpi", typeof(Sprite)) as Sprite;
            MessagemNaTela();
        }

        else
        {
            audioSource_3.Play();
            erro++;
            ErroNaScreen(erro);
            Reciclar.GetComponent<Button>().interactable = false;
            Reciclar.interactable = false;
        }

    }

    public void OnSaveButton()

    {
        audioSource.Play();
        if (TesteExibir.CompareTag("teste"))
        {
            audioSource_2.Play();
            Scene.Acertos++;
            AcertoNaScreen(Scene.Acertos);
            IntensNaTela.GetComponent<Image>().sprite = Resources.Load("", typeof(Sprite)) as Sprite;
            TesteExibir.GetComponent<SpriteRenderer>().sprite = Resources.Load("", typeof(Sprite)) as Sprite;
            MessagemNaTela();
        }

        else
        {
            audioSource_3.Play();
            erro++;
            ErroNaScreen(erro);
            Guardar.GetComponent<Button>().interactable = false;
            Guardar.interactable = false;
        }

    }


    void TempoEspera()
    {
        MessageTela.SetActive(false);
        // para fechar a ScrrenOptions, não desturi desativar 


        Destroy(gameObject);

    }
    void MessagemNaTela()
    {
        Scene.ScreenAberta = false;
        TesteExibir.GetComponent<Collider2D>().enabled = false;
        MessageTela.SetActive(true);
        Invoke("TempoEspera", 3f);

    }
    void AcertoNaScreen(int acerto)
    {
        switch (erro)
        {
            case 0:
                Certo1.SetActive(true);
                break;
            case 1:
                Certo2.SetActive(true);
                break;
            case 2:
                Certo3.SetActive(true);
                break;
            
            default:
                break;
        }
        switch (Scene.Acertos)
        {
            case 2:
                //mostar trofeu
                Certo1.SetActive(true);
                audioSource_4.Play();
              //  Scene.TrofeuStB.SetActive(true);
                
                break;
            case 3:
                //mostar trofeu
                Certo2.SetActive(true);
                audioSource_4.Play();
              //  Scene.TrofeuStP.SetActive(true);
               
                break;
            case 5:
                //mostar trofeu
                Certo3.SetActive(true);
                audioSource_4.Play();
           //     Scene.TrofeuStO.SetActive(true);
              
                break;
            default:
                break;
        }
    }
    void ErroNaScreen(int erro)
    {
        switch (erro)
        {
            case 1:
                Erro1.SetActive(true);
                break;
            case 2:
                Erro2.SetActive(true);
                break;
            case 3:
                Erro3.SetActive(true);
                TesteExibir.GetComponent<Collider2D>().enabled = false;
                Scene.ScreenAberta = false;
                // só pra sumir
                Invoke("TempoEspera", 1f);
                //
                break;
            default:
                break;
        }
    }
    public static void TempoTrofeu(GameObject TrofeuAtual)
    {
       
        switch (Scene.Acertos)
        {
            case 2:
                //mostar trofeu
                //TrofeuB.SetActive(false);
                TrofeuB.SetActive(false);
                break;
            case 3:
                //mostar trofeu
                //TrofeuP.SetActive(false);
                break;
            case 5:
                //mostar trofeu
                /// TrofeuO.SetActive(false);
                break;
            default:
                break;
        }
    }

}

