using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{
    private GetStatus getStatus;
    public GameObject selecter1;
    public GameObject selecter2;
    public GameObject selecter3;
    public GameObject selecter4;
    public GameObject selecter5;
    public GameObject selecter6;
    public GameObject selecter7;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject = GameObject.Find("戦闘処理");
        getStatus = gameObject.GetComponent<GetStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
