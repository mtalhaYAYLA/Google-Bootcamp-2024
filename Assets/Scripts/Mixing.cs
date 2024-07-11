using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixing : MonoBehaviour
{

    public GameObject puppet;
    public GameObject colorpup;
    public Boil_It boil_It;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ELIXIR")
        {
            Debug.Log("Elixir: " + boil_It.elixir);
            Destroy(other.gameObject);
            MixIt();
        }
    }

    public void MixIt()
    {
        if (boil_It.elixir == 1)
        {
            puppet.transform.localScale += new Vector3(2, 2, 2);
            Debug.Log("Büyüme İksiri");
        }
        else if (boil_It.elixir == 2)
        {
            colorpup.GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("Renk Değiştirme İksiri");
        }
        else if (boil_It.elixir == 3)
        {
            puppet.transform.localScale += new Vector3(2, 2, 2);
            colorpup.GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("Hem büyüme hem renk değiştirme iksiri");
        }
        else if (boil_It.elixir == 4)
        {
            puppet.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
            Debug.Log("Küçülme iksiri");
        }
        else if (boil_It.elixir == 5)
        {
            puppet.transform.localScale += new Vector3(0, 2, 0);
            Debug.Log("Boy uzatma iksiri");
        }
        else if (boil_It.elixir == 6)
        {
            puppet.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
            colorpup.GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("Hem küçülme hem renk değiştirme iksiri");
        }
        else if (boil_It.elixir == 7)
        {
            Destroy(puppet);
            Debug.Log("Ölüm iksiri");
        }
    }

}
