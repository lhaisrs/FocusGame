using UnityEngine;
using System.Collections;

public class change : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip Scored;

    private AudioSource audioSource_5;
    public AudioClip Music;
    public static bool Reiniciar;

    // Use this for initialization
    void Start () {
       
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Scored;

        audioSource_5 = GetComponent<AudioSource>();
        audioSource_5.clip = Music;

        audioSource_5.Play();
      
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D[] col = Physics2D.OverlapPointAll(pos);

            if (col.Length > 0)
                foreach (Collider2D c in col)
                {
                    if (c.CompareTag("Play"))
                    {
                        
                       
                        audioSource.Play();
                       Application.LoadLevel("HouseMap");  
                    }
                       

                 if (c.CompareTag("Options"))
                    {
                        //audioSource.Play();
                        //Application.LoadLevel("Configurations");
                    }

                    if (c.CompareTag("About"))
                    {
                        audioSource.Play();
                        Application.LoadLevel("ScreenAbout");
                    }
                }

            
            }
        }

   


}
