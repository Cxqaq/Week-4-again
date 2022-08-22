using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
        GameObject red = (GameObject)Instantiate(redObj, new Vector3(2, 0, 0), new Quaternion(0, 0, 0, 0));
        GameObject blue = (GameObject)Instantiate(blueObj, new Vector3(-2, 0, 0), new Quaternion(0, 0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
