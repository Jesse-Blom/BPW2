using UnityEngine;

public class AnimationTest : MonoBehaviour
{

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //Get Animator component
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Play spin animation on key press
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetTrigger("WooshTrigger");
        }
    }
}