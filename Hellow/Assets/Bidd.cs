using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bidd : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 _initialpos;
   [SerializeField] private float _launchpower= 300;
   private bool arebhaibhaibhai;
    private float _timesofar;

    private void Awake() {
                  _initialpos=transform.position;
            } 
                     
             private void OnMouseDown() {
                 GetComponent<SpriteRenderer>().color= Color.red;
                 GetComponent<LineRenderer>().enabled=true;
             }
             
             private void Update() {
                
                GetComponent<LineRenderer>().SetPosition(1,_initialpos);
                GetComponent<LineRenderer>().SetPosition(0,transform.position);

                 if(arebhaibhaibhai && GetComponent<Rigidbody2D>().velocity.magnitude<=0.1)
                 {
                     _timesofar+= Time.deltaTime;
                 }
                 
                 if(transform.position.y>10 || transform.position.x> 35 || _timesofar>3 || transform.position.y< -10)
                 {
                     string ScenetoLoad= SceneManager.GetActiveScene().name;
                     SceneManager.LoadScene(ScenetoLoad);
                 }
             }
             private void OnMouseUp() {
                 GetComponent<SpriteRenderer>().color= Color.white;
                 Vector2 directionToLaunch=  _initialpos - transform.position;
                 GetComponent<Rigidbody2D>().AddForce(directionToLaunch * _launchpower);
                 GetComponent<Rigidbody2D>().gravityScale=1;
                 arebhaibhaibhai=true;
                 GetComponent<LineRenderer>().enabled=false;
             }

             private void OnMouseDrag() {
                 Vector2 newPosition= Camera.main.ScreenToWorldPoint(Input.mousePosition);
                 transform.position= newPosition; 
             }
    
            

}
