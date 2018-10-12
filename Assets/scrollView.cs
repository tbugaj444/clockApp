using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrollView : MonoBehaviour {
    public ScrollRect scrollV;
    public GameObject scrollContent;
    public GameObject prefabAN;
    public GameObject prefabDIG;

    private ArrayList list = new ArrayList();

	// Use this for initialization
	void Start () {
        generateAN();
       
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void generateAN() {
        GameObject clock = Instantiate(prefabAN);
        list.Add(clock);
        
        clock.transform.SetParent(scrollContent.transform, false);
        

    }
    public void generateDIG()
    {
        GameObject clock = Instantiate(prefabDIG);
        list.Add(clock);
        clock.transform.SetParent(scrollContent.transform, false);

    }
}
