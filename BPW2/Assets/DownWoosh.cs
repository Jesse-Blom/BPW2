using UnityEngine;

public class DownWoosh : MonoBehaviour

{
    int downorup = 1; 
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //Get Animator component
        animator = GetComponent<Animator>();
        //int downorup = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Play spin animation on key press
        if (Input.GetKeyDown(KeyCode.Q) && downorup == 1)
        {
            animator.SetTrigger("WooshTrigger");
            downorup = 2;
        }

        else if (Input.GetKeyDown(KeyCode.Q) && downorup == 2)
            {
                animator.SetTrigger("WeeeTrigger");
                downorup = 1;
            }
    }
}