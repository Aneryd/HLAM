using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dist : MonoBehaviour
{
    public Transform pers;
    public Transform tree;
    public GameObject prefab;
    public GameObject tre;
    private Animator anim;
    int i = 0;
    int col = 0;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void Update()
    {
        float dist = Vector3.Distance(pers.position, tree.position);
        // Debug.Log(dist);
        
        if(dist <= 20)
        {
            if(Input.GetMouseButtonDown(0))
            {
                // anim.SetBool("Kick", true);
                // anim.SetBool("Wait", false);
                // anim.SetBool("Right", false);
                // anim.SetBool("Left", false);
                // anim.SetBool("Forward", false);
                // anim.SetBool("Back", false);

                if (i == 3)
                {
                    // tre.transform.position = new Vector3(0, 2f * Time.deltaTime, 0);
                    Destroy(tre);
                    col = Random.Range(2, 6);
                    int y = 0;
                    while (y < col)
                    {
                        Instantiate(prefab);
                        prefab.transform.position = new Vector3(tre.transform.position.x, tre.transform.position.y + 15, tre.transform.position.z);
                        y++;
                    }
                }

                else
                {
                    i += 1;
                }
            }
        }
    }
}
