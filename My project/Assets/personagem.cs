using UnityEngine;

public class personagem : MonoBehaviour {
    
   public float jump_force;
   [SerializeField] bool isGrounded = false;

   Rigidbody2D RB;
   private void Awake() {
        RB = GetComponent<Rigidbody2D>();
    }


   void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(isGrounded == true) {
                RB.AddForce(Vector2.up * jump_force);
                isGrounded = false;
            }
        }
   }
   private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("chao")) {
            if(isGrounded == false) { 
                isGrounded = true;
            }

        }
    }

}
