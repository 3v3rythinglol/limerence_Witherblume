using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Canvas can;
    public Text name;
    public Text namesh;
    public Text cont;
    String[] contents = {"We are here to talk about a problem i think we all can feel the impact of", "we are just wayyyy to BEAUTIFUL to live on this ugly planet", "so what are we saying girls?"}

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool skip = Input.GetKeyDown(KeyCode.Return);
        if(skip)
    }

    // To update both name and shadow of the name at the same time
    void change_name(String s) {
        name.text = s;
        namesh.text = s;
    }
}
