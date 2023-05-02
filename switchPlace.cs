using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchPlace : MonoBehaviour
{
    public GameObject Place;
    public Material Material1;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // click Button and go to an other place
    void OnMouseDown() {
    this.gameObject.SetActive(false);
    Place.GetComponent<MeshRenderer>().material = Material1;
    this.button.SetActive(true);
    }
}
