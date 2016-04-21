using UnityEngine;
using System.Collections;

public class ScreenPause : MonoBehaviour {

    public GameObject ScreenPause_;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {




    }

    //Não estão aparecendo no unity não sei porque
  public void OnBackPause ()
    {
        Destroy(ScreenPause_);
    }

  public void OnCofigurations()
    {
        //GameObject CanvasConfigurations = Resources.Load("CanvasConfigurations") as GameObject;
        //float fx = 0f;
        //float fy = 0f;
        //CanvasConfigurations.transform.position = new Vector3(fx, fy, 0);
        //Instantiate(CanvasConfigurations);
    }

  public void OnVolum()
    {
        //dfhdh
    }
  public void OnGoMap()
    {
        Application.LoadLevel("HouseMap");
    }
}
