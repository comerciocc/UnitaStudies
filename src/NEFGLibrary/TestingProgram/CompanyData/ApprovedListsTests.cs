﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NEFGLibrary.CompanyData;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TestingProgram.CompanyData
{
    [TestClass]
    public class ApprovedListsTests
    {
        [TestMethod]
        public void populatePortfolio()
        {
            ApprovedLists al = CreatePorfolioData();

            var expectedPortofolioCount = 7;

            Assert.AreEqual(expectedPortofolioCount, al.Portfolios.Count());
        }

        public static ApprovedLists CreatePorfolioData()
        {
            ApprovedLists al = new ApprovedLists();

            al.AddPortfolio("Institutional Cash Plus Account");
            al.AddPortfolio("Protector Portfolio");
            al.AddPortfolio("Consolidator Portfolio");
            al.AddPortfolio("Builder Portfolio");
            al.AddPortfolio("N-e-FG Stable Portfolio");
            al.AddPortfolio("N-e-FG Moderate Portfolio");
            al.AddPortfolio("N-e-FG Aggressive Portfolio");
            return al;
        }

        [TestMethod]
        public void populateHoldings()
        {
            ApprovedLists al = CreateHoldingData();

            var expectedHoldingsCount = 16;

            Assert.AreEqual(expectedHoldingsCount, al.Holdings.Count());

        }

        public static ApprovedLists CreateHoldingData()
        {
            ApprovedLists al = new ApprovedLists();
            al.AddHolding("PSG Income E");
            al.AddHolding("Coronation Strategic Income P");
            al.AddHolding("STANLIB Income B2");
            al.AddHolding("NeFG BCI Income Provider");
            al.AddHolding("Allan Gray Stable A");
            al.AddHolding("Coronation Balanced Defensive P");
            al.AddHolding("Allan Gray Balanced A");
            al.AddHolding("Coronation Balanced Plus P");
            al.AddHolding("PSG Balanced B");
            al.AddHolding("NeFG BCI Flexible");
            al.AddHolding("Prudential Equity B");
            al.AddHolding("Coronation Top 20 P");
            al.AddHolding("NeFG BCI Equity");
            al.AddHolding("Investec Absolute Balanced B");
            al.AddHolding("Investec Opportunity R");
            al.AddHolding("Private Share Portfolio");
            return al;
        }

        [TestMethod]
        public void populateAssets()
        {
            ApprovedLists al = CreateAssetData();

            var expectedAssetCount = 10;

            Assert.AreEqual(expectedAssetCount, al.Assets.Count());


        }

        public static ApprovedLists CreateAssetData()
        {
            ApprovedLists al = new ApprovedLists();
            al.AddAsset("Domestic Cash");
            al.AddAsset("Domestic Bonds");
            al.AddAsset("Domestic Property");
            al.AddAsset("Domestic Other");
            al.AddAsset("Offshore Cash");
            al.AddAsset("Offshore Bonds");
            al.AddAsset("Offshore Property");
            al.AddAsset("Offshore Other");
            al.AddAsset("Domestic Equity");
            al.AddAsset("Offshore Equity");
            return al;
        }

        public static ApprovedLists CreateApprovedList()
        {
            var al = new ApprovedLists
            {
                Assets = CreateAssetData().Assets,
                Holdings = CreateHoldingData().Holdings,
                Portfolios = CreatePorfolioData().Portfolios
            };
            return al;
        }
    }
}
