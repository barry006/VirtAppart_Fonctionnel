using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
    public class ClosetopencloseDoor : MonoBehaviour
    {

        public Animator Closetopenandclose;
        public bool open;
        public Transform Player;
        public bool b = true;
        public bool b2 = true;

        void Start()
        {
            open = false;
        }
        /*
        private void Update()
        {
            if (Player)
            {
               
                float dist = Vector3.Distance(Player.position, transform.position);
                if (dist < 6 && open == false)
                {
                    StartCoroutine(opening());
                }
                else if (dist > 6 && open == true)
                {
                    StartCoroutine(closing());
                }
            }
        }

        IEnumerator opening()
        {
            print("you are opening the door");
            Closetopenandclose.Play("ClosetOpening");
            open = true;
            yield return new WaitForSeconds(.5f);
        }

        IEnumerator closing()
        {
            print("you are closing the door");
            Closetopenandclose.Play("ClosetClosing");
            open = false;
            yield return new WaitForSeconds(.5f);
        }
        */


        public void OpenCLoseDoors()
        {

            if (b2)
            {
                if (b)
                {
                    b2 = false;
                    StartCoroutine(opening());
                    b = !b;
                }
                else
                {
                    b2 = false;
                    StartCoroutine(closing());
                    b = !b;
                }

            }
        }




        IEnumerator opening()
        {
            print("you are opening the door");
            Closetopenandclose.Play("ClosetOpening");
            open = true;
            yield return new WaitForSeconds(.5f);
            b2 = true;

        }

        IEnumerator closing()
        {
            print("you are closing the door");
            Closetopenandclose.Play("ClosetClosing");
            open = false;
            yield return new WaitForSeconds(.5f);
            b2 = true;


        }

    }
}