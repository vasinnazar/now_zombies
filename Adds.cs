using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using GoogleMobileAds.Api;

public class Adds : MonoBehaviour
{
    //public Text adStatus;
    string App_ID = "ca-app-pub-4769109696867378~6434824569";
    //string BennerAd_ID = "ca-app-pub-3940256099942544/6300978111";//ca-app-pub-4769109696867378~6434824569
    string PageAd_ID = "ca-app-pub-3940256099942544/1033173712";//ca-app-pub-4769109696867378~6434824569
    string PointsAd_ID = "ca-app-pub-3940256099942544/5224354917";//ca-app-pub-4769109696867378~6434824569
    // Start is called before the first frame update
    //private BannerView bannerView;
    private InterstitialAd interstitial;
    private RewardBasedVideoAd rewardbasedvideoad;
    public int foradds;
    void Start()
    {
        foradds = PlayerPrefs.GetInt("ad");
        foradds += 1;
        
        MobileAds.Initialize(App_ID);
        StartCoroutine(Advert());
    }
    void Update()
    {//foradds = PlayerPrefs.GetInt("ad");
        //PlayerPrefs.SetInt("ad", foradds);
       if (foradds == 2)
        {
            RequestInterstitial();
            //yield return new WaitForSeconds(3.0f);
            ShowInterstitialAd();
        }
        if (foradds == 3)
        {
            //ShowInterstitialAd();
            RequestRewardBAsedVideo();
            //yield return new WaitForSeconds(3.0f);
            ShowVideoRewardAd();
            PlayerPrefs.SetInt("ad", foradds);
        }
        if(foradds == 4)
        {
            foradds = 1;
        }
        PlayerPrefs.SetInt("ad", foradds);
    }
    private IEnumerator Advert()
    {
        yield return new WaitForSeconds(0.5f);
        
        
        /*if (foradds == 1)
        {
            RequestBanner();
            yield return new WaitForSeconds(3.0f);
            ShowBannerAD();
        }*/
        
    }
    /*public void RequestBanner()
    {

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(BennerAd_ID, AdSize.Banner, AdPosition.Top);
        // Called when an ad request has successfully loaded.
        this.bannerView.OnAdLoaded += this.HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.bannerView.OnAdFailedToLoad += this.HandleOnAdFailedToLoad;
        // Called when an ad is clicked.
        this.bannerView.OnAdOpening += this.HandleOnAdOpened;
        // Called when the user returned from the app after an ad click.
        this.bannerView.OnAdClosed += this.HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        this.bannerView.OnAdLeavingApplication += this.HandleOnAdLeavingApplication;
        Debug.Log("Banner is loaded");
    }

    // Update is called once per frame
    public void ShowBannerAD()
    {
        AdRequest request = new AdRequest.Builder().Build();
        this.bannerView.LoadAd(request);

        Debug.Log("Banner is shown");
    }*/
   public void RequestInterstitial()
    {
        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(PageAd_ID);
        // Called when an ad request has successfully loaded.
        this.interstitial.OnAdLoaded += HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.interstitial.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        // Called when an ad is shown.
        this.interstitial.OnAdOpening += HandleOnAdOpened;
        // Called when the ad is closed.
        this.interstitial.OnAdClosed += HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        this.interstitial.OnAdLeavingApplication += HandleOnAdLeavingApplication;

        AdRequest request = new AdRequest.Builder().Build();
        this.interstitial.LoadAd(request);
        Debug.Log("Inter is loaded");
    }

    public void ShowInterstitialAd()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
        Debug.Log("Inter is shown");
    }

    public void RequestRewardBAsedVideo()
    {
        rewardbasedvideoad = RewardBasedVideoAd.Instance;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded video ad with the request.
        this.rewardbasedvideoad.LoadAd(request, PointsAd_ID);
        Debug.Log("Video is loaded");
    }
    public void ShowVideoRewardAd()
    {
        if (rewardbasedvideoad.IsLoaded())
        {
            rewardbasedvideoad.Show();
        }
        Debug.Log("Video is shown");
    }
    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
                            + args.Message);
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }
}
