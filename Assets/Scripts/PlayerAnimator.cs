using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string IS_WALKING = "IsWalking";
    private Animator animator;
    [SerializeField] private Player player; 
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
