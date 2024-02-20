
using System;
using System.Collections;
namespace Pages;

public class Controller

{
    private readonly List<UserProfile>? UserProfiles = new List<UserProfile>();
    public UserProfile CurrentProfile;
    public bool ShowAddProfilePopup = false;
    public ThisMetricRow SelectedRow;
    public bool ShowThresholdPopup = false;
    public bool ShowEditMenu = false;
    public UserProfile SelectedProfile;
    public int EditingProfileId;
   
    int id = 1;
    

    

    public Controller()
    {

        InitialiseProfiles();
        setUserProfile(1);
    }

    public AddProfilePopupController getAddProfileController()
    {
        return new AddProfilePopupController(this);
    }

    public void AddProfileClicked()
    {
       
        ShowAddProfilePopup = true;
    }




    public void InitialiseProfiles()


    {
        
        UserProfiles.Add(new UserProfile { Profile = new ProfileInfo { Id = id, Name = "profile1", Notes = "", Metrics = new List<ThisMetricRow>(), PassRate = 75 } });

        id++;
        UserProfiles.Add(new UserProfile { Profile = new ProfileInfo { Id = id, Name = "profile2", Notes = "", Metrics = new List<ThisMetricRow>(), PassRate = 75 } });
        id++;

        this.CurrentProfile = UserProfiles[0];
        

    }

    public List<UserProfile> getProfiles()
    {
        return UserProfiles;
    }

    public UserProfile getCurrentProfile()
    {
        return CurrentProfile;
    }

    

    public void setUserProfile(int id)
    {


        this.CurrentProfile = UserProfiles.Find(x => x.Profile.Id == id);
        
        CurrentProfile.InitMetrics();
        
    }

    public void createProfile(int? profileID)

    {
        UserProfile profile = UserProfiles.First(userProfile => userProfile.Profile.Id == profileID);
        UserProfile newProfile = new UserProfile { Profile = new ProfileInfo { Id = id, Name = ("Copy of " + profile.Profile.Name.ToString()), Metrics = profile.CopyRow(profile.Profile.Metrics), Notes = profile.Profile.Notes.ToString(), PassRate = (profile.Profile.PassRate) } };
        UserProfiles.Add(newProfile);
        id++;
    }

    public void ThresholdButtonclicked(ThisMetricRow row)
    {
        this.SelectedRow = row;
        this.ShowThresholdPopup = true;
       


    }

    public ThresholdController GetThresholdController()
    {
        return new ThresholdController(SelectedRow.Metrics.ThresholdOne, SelectedRow.Metrics.ThresholdTwo, SelectedRow.Metrics.ThresholdThree);
    }

    public void CloseThresholdPopup()
    {
        ShowThresholdPopup = false;
    }

    public void UpdateThreshold(double thresholdOne, double thresholdTwo, double thresholdThree)
    {
        SelectedRow.Metrics.ThresholdOne = thresholdOne; SelectedRow.Metrics.ThresholdTwo = thresholdTwo; SelectedRow.Metrics.ThresholdThree = thresholdThree;
    }

    public void ClickedEditMenu(UserProfile profile)
    {
        ShowEditMenu = true;
        SelectedProfile = profile;

        
    }

    public EditMenuController GetEditMenuController()
    {
        return new EditMenuController();
    }

    public void DeleteProfile(UserProfile profile)
    {
        UserProfiles.Remove(profile);
    }

    public void CloseEditMenu()
    {
        ShowEditMenu = false;
    }

    public void EditProfileName(int ProfileID, string ProfileName)
    {
        UserProfiles.Find(x => x.Profile.Id == ProfileID).Profile.Name = ProfileName;
    }
    

    

    

    

   
}
