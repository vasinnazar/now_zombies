using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using GoogleMobileAds.Api;

public class Adds3 : MonoBehaviour
{
    //private BannerView adBanner;
    private InterstitialAd adInterstitial;
    public int points;
    //public bool boolean = false;
    public GameObject texter;
    public TextMesh te;
    public GameObject other;

    private string idApp,  idInterstitial;

    [SerializeField] Button BtnInterstitial;
    //[SerializeField] Text TxtPoints;


    void Start()
    {
        BtnInterstitial.interactable = false;

        idApp = "ca-app-pub-4769109696867378~6434824569";
        //idBanner = "ca-app-pub-3940256099942544/6300978111";//ca-app-pub-4769109696867378~6434824569
        idInterstitial = "ca-app-pub-4769109696867378/5538328258";//ca-app-pub-4769109696867378~6434824569



        MobileAds.Initialize(idApp);

        //RequestBannerAd();
        RequestInterstitialAd();
        //points = PlayerPrefs.GetInt("S");
    }
    void Update()
    {
        //if(other.activeSelf == true)
        //{
          //  boolean = true;
        //}
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
        Debug.Log("Stranici");
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
        //if (boolean == true)
        //{
            ShowInterstitialAd();
         //   boolean = false;
        //}
        
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

    

    //other functions
    //btn (more points) clicked
    public void OnGetMorePointsClicked()
    {
        
        //points += 100; //add 50 points
    }

    //------------------------------------------------------------------------
    AdRequest AdRequestBuild()
    {
        return new AdRequest.Builder().Build();
        Debug.Log("Banneres");
    }

    void OnDestroy()
    {
        //DestroyBannerAd();
        DestroyInterstitialAd();

        //dettach events
        adInterstitial.OnAdLoaded -= this.HandleOnAdLoaded;
        adInterstitial.OnAdOpening -= this.HandleOnAdOpening;
        adInterstitial.OnAdClosed -= this.HandleOnAdClosed;



    }

}
