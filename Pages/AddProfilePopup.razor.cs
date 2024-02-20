namespace Pages;
using Microsoft.AspNetCore.Components;
using System;


public class AddProfilePopupController
{
    public UserProfile? SelectedProfile { get; set; }
    private Controller instance;

    public AddProfilePopupController(Controller instance)
    {
        this.instance = instance;
    }
    public void clickedOK()
    {
        if (SelectedProfile != null)
        {
            instance.createProfile(SelectedProfile.Profile.Id);
        }
        
        
        
        
        
        
    }
}
    

  

