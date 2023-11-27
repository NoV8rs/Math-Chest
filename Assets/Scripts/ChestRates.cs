using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChestRates : MonoBehaviour
{
    public string chestAwarded;
    public string prizeAwarded;

    [Header("Chest Type")]
    public int WoodChest;
    public int BrozneChest;
    public int SliverChest;
    public int GoldChest;
    public int PlatinumChest;
    public List<string> ChestTypes;

    [Header("WoodChestDrops")]
    public int WoodCommon;
    public int WoodUncommon;
    public int WoodRare;
    public int WoodEpic;
    public int WoodLegendary;
    public List<string> WoodChestAwards;

    [Header(" Sliver Chest Drops ")]
    public int SliverCommon;
    public int SliverUncommon;
    public int SliverRare;
    public int SliverEpic;
    public int SliverLegendary;
    public List<string> SliverChestAwards;

    [Header("Brozne Chest Drops")]
    public int BrozneCommon;
    public int BrozneUncommon;
    public int BrozneRare;
    public int BrozneEpic;
    public int BrozneLegendary;
    public List<string> BrozneChestAwards;

    [Header("Gold Chest Drops")]
    public int GoldCommon;
    public int GoldUncommon;
    public int GoldRare;
    public int GoldEpic;
    public int GoldLegendary;
    public List<string> GoldChestAwards;

    [Header("Platinum Chest Drops")]
    public int PlatinumCommon;
    public int PlatinumUncommon;
    public int PlatinumRare;
    public int PlatinumEpic;
    public int PlatinumLegendary;
    public List<string> PlatinumChestAwards;


    // Start is called before the first frame update
    void Start()
    {
        //ChestTypes.Add(new string("WoodChest"));
        for (int i = 0; i < WoodChest; i++) { ChestTypes.Add(new string("WoodChest"));  }
        for (int i = 0; i < BrozneChest; i++) { ChestTypes.Add(new string("SliverChest")); }
        for (int i = 0; i < SliverChest; i++) { ChestTypes.Add(new string("BrozneChest")); }
        for (int i = 0; i < GoldChest; i++) { ChestTypes.Add(new string("GoldChest")); }
        for (int i = 0; i < PlatinumChest; i++) { ChestTypes.Add(new string("PlatinumChest")); }
        //ChestTypes.Add(new string("WoodChest"));
        for(int i = 0;i < WoodCommon;i++) { WoodChestAwards.Add(new string("WoodCommon")); }
        for (int i = 0; i < WoodUncommon; i++) { WoodChestAwards.Add(new string("WoodUncommon")); }
        for (int i = 0; i < WoodRare; i++) { WoodChestAwards.Add(new string("WoodRare")); }
        for (int i = 0; i < WoodEpic; i++) { WoodChestAwards.Add(new string("WoodEpic")); }
        for (int i = 0; i < WoodLegendary; i++) { WoodChestAwards.Add(new string("WoodLegendary")); }

        for (int i = 0; i < BrozneCommon; i++) { BrozneChestAwards.Add(new string("BrozneCommon")); }
        for (int i = 0; i < BrozneUncommon; i++) { BrozneChestAwards.Add(new string("BrozneUncommon")); }
        for (int i = 0; i < BrozneRare; i++) { BrozneChestAwards.Add(new string("BrozneRare")); }
        for (int i = 0; i < BrozneEpic; i++) { BrozneChestAwards.Add(new string("BrozneEpic")); }
        for (int i = 0; i < BrozneLegendary; i++) { BrozneChestAwards.Add(new string("BrozneLegendary")); }

        for (int i = 0; i < SliverCommon; i++) { SliverChestAwards.Add(new string("SliverCommon")); }
        for (int i = 0; i < SliverUncommon; i++) { SliverChestAwards.Add(new string("SliverUncommon")); }
        for (int i = 0; i < SliverRare; i++) { SliverChestAwards.Add(new string("SliverRare")); }
        for (int i = 0; i < SliverEpic; i++) { SliverChestAwards.Add(new string("SliverEpic")); }
        for (int i = 0; i < SliverLegendary; i++) { SliverChestAwards.Add(new string("SliverLegendary")); }

        for (int i = 0; i < GoldCommon; i++) { GoldChestAwards.Add(new string("GoldCommon")); }
        for (int i = 0; i < GoldUncommon; i++) { GoldChestAwards.Add(new string("GoldUncommon")); }
        for (int i = 0; i < GoldRare; i++) { GoldChestAwards.Add(new string("GoldRare")); }
        for (int i = 0; i < GoldEpic; i++) { GoldChestAwards.Add(new string("GoldEpic")); }
        for (int i = 0; i < GoldLegendary; i++) { GoldChestAwards.Add(new string("GoldLegendary")); }

        for (int i = 0; i < PlatinumCommon; i++) { PlatinumChestAwards.Add(new string("PlatinumCommon")); }
        for (int i = 0; i < PlatinumUncommon; i++) { PlatinumChestAwards.Add(new string("PlatinumUncommon")); }
        for (int i = 0; i < PlatinumRare; i++) { PlatinumChestAwards.Add(new string("PlatinumRare")); }
        for (int i = 0; i < PlatinumEpic; i++) { PlatinumChestAwards.Add(new string("PlatinumEpic")); }
        for (int i = 0; i < PlatinumLegendary; i++) { PlatinumChestAwards.Add(new string("PlatinumLegendary")); }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            chestAwarded = ChestTypes[Random.Range(0,ChestTypes.Count)];
            if (chestAwarded == "WoodChest")
            {
                prizeAwarded = WoodChestAwards[Random.Range(0, WoodChestAwards.Count)];
            }
            if (chestAwarded == "BrozneChest")
            {
                prizeAwarded = BrozneChestAwards[Random.Range(0, BrozneChestAwards.Count)];
            }
            if (chestAwarded == "SliverChest")
            {
                prizeAwarded = SliverChestAwards[Random.Range(0, SliverChestAwards.Count)];
            }
            if (chestAwarded == "GoldChest")
            {
                prizeAwarded = GoldChestAwards[Random.Range(0, GoldChestAwards.Count)];
            }
            if (chestAwarded == "PlatinumChest")
            {
                prizeAwarded = PlatinumChestAwards[Random.Range(0, PlatinumChestAwards.Count)];
            }
            Debug.Log("Your chest is: " + chestAwarded);
            Debug.Log("Your item rarity is: " + prizeAwarded);
            //if (chestAwarded == "WoodChestAwards") 
            //{
            //WoodChestAwards =  WoodChest[Random.Range(0, WoodChestAwards.Count)];
            //Debug.Log("WoodCommon");
            //}
            //else 
            //{
            //Debug.Log("Not a WoodChest");
            //}
            //chestAwarded = WoodChestAwards[Random.Range(0, WoodChestAwards.Count)];
        }
    }
}
