using UnityEngine;

public class Enemy : MonoBehaviour
{ 
    [SerializeField] private GameObject _ParticlePrefab;
   void OnCollisionEnter2D(Collision2D collisionInfo)
   {
         //oncollison2d is necassary here!
         
             
       if(collisionInfo.collider.GetComponent<Bidd>()!=null)
       {
         
          
          Instantiate(_ParticlePrefab,transform.position, Quaternion.identity);
           Destroy(gameObject);
           return ;
       }
       
       //collisionInfo.collider will tell us whether the selected object is hit or not
       Enemy enemy= collisionInfo.collider.GetComponent<Enemy>();
       if(enemy!=null)
           return;
       


       //contacts is like a array stroing all the initial contacts of collison
       //contacts[0] means we are accessing first ever contact
       if(collisionInfo.contacts[0].normal.y < -0.5)
        {
           Instantiate(_ParticlePrefab,transform.position, Quaternion.identity);
          Destroy(gameObject);  
        } 
   }   
}
