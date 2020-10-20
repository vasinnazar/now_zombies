using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using GoogleMobileAds.Api;

public class Adds2 : MonoBehaviour
{
    private BannerView adBanner;
    private InterstitialAd adInterstitial;
    private RewardBasedVideoAd adReward;
    public int points;
    //public bool boolean = true;
    //public GameObject texter;
    //public TextMesh te;
    //public GameObject other;
    //public GameObject rock;

    private string idApp, idBanner, idInterstitial, idReward;

    [SerializeField] Button BtnInterstitial;
    //[SerializeField] Button BtnReward;
    //[SerializeField] Text TxtPoints;


    void Start()
    {
        BtnInterstitial.interactable = false;

        idApp = "ca-app-pub-4769109696867378~6434824569";
        idInterstitial = "ca-app-pub-4769109696867378/5538328258";//ca-app-pub-4769109696867378~6434824569



        MobileAds.Initialize(idApp);

       
        RequestInterstitialAd();
        //points = PlayerPrefs.GetInt("S");
    }
    void Update()
    {
        //int points = int.Parse(TxtPoints.text);
        //TxtPoints.text = points.ToString();
        //te = texter.GetComponent<TextMesh>();
        //te.text = points.ToString();
        
        //PlayerPrefs.SetInt("S", points);
    }


    

    #region Interstitial methods ---------------------------------------------

    public void RequestInterstitialAd()
    {
        adInterstitial = new InterstitialAd(idInterstitial);
        AdRequest request = AdRequestBuild();
        adInterstitial.LoadAd(request);
       

        //attach events
        adInterstitial.OnAdLoaded += this.HandleOnAdLoaded;
        adInterstitial.OnAdOpening += this.HandleOnAdOpening;
        adInterstitial.OnAdClosed += this.HandleOnAdClosed;
    }

    public void ShowInterstitialAd()
    {
        if (adInterstitial.IsLoaded())
            adInterstitial.Show();
    }

    public void DestroyInterstitialAd()
    {
        adInterstitial.Destroy();
    }

    //interstitial ad events
    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        //this method executes when interstitial ad is Loaded and ready to show
        BtnInterstitial.interactable = true; //button is ready to click (enabled)
            Debug.Log("Stranici");
            ShowInterstitialAd();
       
        
    }

    public void HandleOnAdOpening(object sender, EventArgs args)
    {
        //this method executes when interstitial ad is shown
        BtnInterstitial.interactable = false; //disable the button
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        //this method executes when interstitial ad is closed
        adInterstitial.OnAdLoaded -= this.HandleOnAdLoaded;
        adInterstitial.OnAdOpening -= this.HandleOnAdOpening;
        adInterstitial.OnAdClosed -= this.HandleOnAdClosed;

        //RequestInterstitialAd(); //request new interstitial ad after close
        Application.LoadLevel(25);
    }

    #endregion

    #region Reward video methods ---------------------------------------------

    
    
    //events
    public void HandleOnRewardedAdLoaded(object sender, EventArgs args)
    {//ad loaded
       
        
        //other.GetComponent<PayPoints>().Money();
    }

    public void HandleOnAdRewarded(object sender, EventArgs args)
    {//user finished watching ad
        //int points = int.Parse(TxtPoints.text);
        //points += 50; //add 50 points
        //TxtPoints.text = points.ToString();
    }

    public void HandleOnRewardedAdClosed(object sender, EventArgs args)
    {//ad closed (even if not finished watching)
       

    }
    #endregion

    //other functions
    //btn (more points) clicked
    public void OnGetMorePointsClicked()
    {
        //BtnReward.interactable = false;
        //BtnReward.GetComponentInChildren<Text>().text = "Loading...";
        
        //points += 100; //add 50 points
    }

    //------------------------------------------------------------------------
    AdRequest AdRequestBuild()
    {
        return new AdRequest.Builder().Build();
    }

    void OnDestroy()
    {
       
        DestroyInterstitialAd();

        //dettach events
        adInterstitial.OnAdLoaded -= this.HandleOnAdLoaded;
        adInterstitial.OnAdOpening -= this.HandleOnAdOpening;
        adInterstitial.OnAdClosed -= this.HandleOnAdClosed;


        

    }

}
