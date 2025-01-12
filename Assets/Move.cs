using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject can;
    public Text cName;
    public Text namesh;
    public Text cont;
    string[] characterOrder = {"chikako", "red chikako", "green chikako", "torquoise chikako",
     "black chikako", "white chikako",
        "chikako", "red chikako", "green chikako", "chikako",
        "red chikako", "green chikako", "torquoise chikako", "black chikako",
        "white chikako", "chikako", "freerome"};
    string[] contents = {"We are here to talk about a problem I think we all can feel the impact of. We are just wayyyy too BEAUTIFUL to live on this ugly planet. So, what are we saying, girls?",
        "I’m saying I looked at a mirror, and it reflected someone else’s face for a second. Like, it couldn’t handle mine.",
        "I smiled at myself, and my reflection just smiled back like, “Yeah, we both know I’m amazing.”",
        "I walked past a florist, and the roses just quit. No petals. No hope. Just stems and despair.",
        "I made eye contact with a guy, and he said, “Thank you.” I wasn’t even talking to him.",
        "I waved at a pigeon, and it saluted me. A pigeon.",
        "Exactly! The world can’t handle us.",
        "So what do we do?",
        "We turn it up. Brighter lights. Bigger mirrors. Public service announcements.",
        "And if they can’t handle it?",
        "Then they suffer.",
        "Beautifully.",
        "With dignity.",
        "And emotional scars.",
        "…And a saluting pigeon.",
        "Let’s go melt some hearts.", "freerome"
    };
    int dialogIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        change_char(characterOrder[0]);
        cont.text = contents[dialogIndex];
    }

    // Update is called once per frame
    void Update()
    {
        bool skip = Input.GetKeyDown(KeyCode.Return);
        if(skip) nextdialog();
    }

    // To update both name and shadow of the name at the same time
    void change_char(string s) {
        switch(s) {
            case "chikako":
                can.SetActive(true);
                transform.position = new Vector3(-0.72f, 0.49f, 0f);
                transform.rotation = degreeQ(0f, 90f, 0f);
                cName.color = new Color(96f/255f, 15f/255f, 152f/255f);
                namesh.color = new Color(149f/255f, 0f, 1f);
                cName.text = s;
                namesh.text = s;
                break;
            case "red chikako":
                can.SetActive(true);      
                transform.position = new Vector3(-0.89f, 0.49f, -2.05f);
                transform.rotation = degreeQ(0f, 180f, 0f);
                cName.color = new Color(224f/255f, 2f/255f, 32f/255f);
                namesh.color = new Color(145f/255f, 3f/255f, 22f/255f);
                cName.text = s;
                namesh.text = s;
                break;
            case "green chikako":
                can.SetActive(true);
                transform.position = new Vector3(-0.83f, 0.41f, 0.41f);
                transform.rotation = degreeQ(0f, 0f, 0f);
                cName.color = new Color(77f/255f, 222f/255f, 51f/255f);
                namesh.color = new Color(46f/255f, 135f/255f, 30f/255f);
                cName.text = s;
                namesh.text = s;
                break;
            case "torquoise chikako":
                can.SetActive(true);
                transform.position = new Vector3(-1.05f, 0.49f, 0.17f);
                transform.rotation = degreeQ(0f, 270f, 0f);
                cName.color = new Color(19f/255f, 207f/255f, 203f/255f);
                namesh.color = new Color(11f/255f, 135f/255f, 133f/255f);
                cName.text = s;
                namesh.text = s;
                break;
            case "black chikako":
                can.SetActive(true);
                transform.position = new Vector3(-0.66f, 0.49f, -1.24f);
                transform.rotation = degreeQ(0f, 90f, 0f);
                cName.color = new Color(87f/255f, 87f/255f, 87f/255f);
                namesh.color = new Color(33f/255f, 33f/255f, 33f/255f);
                cName.text = s;
                namesh.text = s;
                break;
            case "white chikako":
                can.SetActive(true);
                transform.position = new Vector3(-1.05f, 0.49f, -1.24f);
                transform.rotation = degreeQ(0f, 270f, 0f);
                cName.color = new Color(224f/255f, 224f/255f, 224f/255f);
                namesh.color = new Color(191f/255f, 191f/255f, 191f/255f);
                cName.text = s;
                namesh.text = s;
                break;
            default:
                transform.position = new Vector3(-3.4f, 0.6f, -4.0f);
                transform.rotation = degreeQ(5.33f, 38.07f, 0f);
                can.SetActive(false);
                break;
        }
    }

    //converts degrees to quaternion
    Quaternion degreeQ(float x, float y, float z) {
        Quaternion nQuat;
        nQuat = Quaternion.Euler(x, y, z);
        return nQuat;
    }

    void nextdialog() {
        dialogIndex++;
        try{
            cont.text = contents[dialogIndex];
            change_char(characterOrder[dialogIndex]);
        }
        catch {
            Debug.Log("uhm out of character or dialog");
        }
    }
}
