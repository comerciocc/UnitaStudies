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
            ApprovedLists al = new ApprovedLists();

            al.AddPortfolio("Institutional Cash Plus Account");
            al.AddPortfolio("Protector Portfolio");
            al.AddPortfolio("Consolidator Portfolio");
            al.AddPortfolio("Builder Portfolio");
            al.AddPortfolio("N-e-FG Stable Portfolio");
            al.AddPortfolio("N-e-FG Moderate Portfolio");
            al.AddPortfolio("N-e-FG Aggressive Portfolio");

            var expectedPortofolioCount = 7;

            Assert.AreEqual(expectedPortofolioCount, al.Portfolios.Count());
        }

        [TestMethod]
        public void populateHoldings()
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

            var expectedHoldingsCount = 16;

            Assert.AreEqual(expectedHoldingsCount, al.Holdings.Count());

        }

        [TestMethod]
        public void populateAssets()
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

            var expectedAssetCount = 10;

            Assert.AreEqual(expectedAssetCount, al.Assets.Count());


        }

    }
}
