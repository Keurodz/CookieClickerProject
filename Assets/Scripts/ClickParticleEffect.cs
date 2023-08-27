using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickParticleEffect : MonoBehaviour
{
    public ParticleSystem clickParticles; // Reference to the Particle System
    public Button cookieButton; // Reference to the cookie button

    public int particleSortingOrder = 1; // Adjust this value to ensure particles render above the button

    private void Start()
    {
        // Set the particle system's sorting order
        clickParticles.GetComponent<ParticleSystemRenderer>().sortingOrder = particleSortingOrder;

        // Subscribe to the button's click event
        cookieButton.onClick.AddListener(OnClickCookie);
    }

    private void OnClickCookie()
    {
        // Play the particle effect
        clickParticles.Play();
    }
}

