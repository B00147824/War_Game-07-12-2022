using System. Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using TMPro;

public class gameflow : MonoBehaviour
{

           
        public GameObject[] tank; 
        private int whichTank; 
        
        
        void Start()
        {
                     //call the methode
        StartCoroutine(spawnTimer());
        }

        void Update()

        {

        }
        IEnumerator spawnTimer ()
        {
        // wait enamy tank by 4 min after
        yield return new WaitForSeconds(2);
          // the number of the tanks are 3 rang
         whichTank =Random.Range(0,3);
         // two tank at a time
          Instantiate(tank [ whichTank ]); 
          whichTank =Random. Range(0,3); 
          Instantiate(tank[whichTank]);
          //Keep repating it self
        StartCoroutine(spawnTimer());
        }
}