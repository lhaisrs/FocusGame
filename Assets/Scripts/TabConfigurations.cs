using UnityEngine;
using System.Collections;

public class TabConfigurations : MonoBehaviour {

    public GameObject ScreenConfigurations;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D[] col = Physics2D.OverlapPointAll(pos);

            if (col.Length > 0)
                foreach (Collider2D c in col)
                {
                    if (c.CompareTag("BackMenu"))
                    {
                        Application.LoadLevel("HouseMap");
                    }


                    if (c.CompareTag("Restart"))
                    {
                     
                        Application.LoadLevel("Home");
                    }

                    if (c.CompareTag("BackScreenPause"))
                    {
                        Destroy(ScreenConfigurations);
                        
                    }
                }


        }
    
}
}
