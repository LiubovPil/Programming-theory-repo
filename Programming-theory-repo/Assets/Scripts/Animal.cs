using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] protected Animator animator;
    [SerializeField] protected Rigidbody rb;

    private string animalName = string.Empty;

    //public string AnimalName
    //{
    //    get
    //    {
    //        return name;
    //    }
    //    set
    //    {
    //        if (value.Length <= 10)
    //        {
    //            name = value;
    //        }
    //        else
    //        {
    //            Debug.LogWarning("Animal name is too long!");
    //        }
    //    }
    //}

    //protected virtual void Jump()
    //{
    //    animator.SetTrigger("Jump");
    //}

    //protected virtual void Walk()
    //{
    //    animator.SetTrigger("Walk");
    //}

    //protected virtual void Talk()
    //{

    //}
}
