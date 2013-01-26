﻿using System;
using System.Web.Optimization;

namespace DurandalTemplate.App_Start {
  public class BundleConfig {
    public static void RegisterBundles(BundleCollection bundles) {
      bundles.IgnoreList.Clear();
      AddDefaultIgnorePatterns(bundles.IgnoreList);

      bundles.Add(
        new ScriptBundle("~/scripts/vendor")
          .Include("~/Scripts/jquery-1.8.3.min.js")
          .Include("~/Scripts/knockout-2.2.0.js")
          .Include("~/Scripts/sammy-0.7.2.min.js")
          .Include("~/Scripts/bootstrap.min.js")
        );

      bundles.Add(
        new StyleBundle("~/Content/css")
          .Include("~/Content/ie10mobile.css")
          .Include("~/Content/bootstrap.min.css")
          .Include("~/Content/app.css")
          .Include("~/Content/bootstrap-responsive.min.css")
          .Include("~/Content/font-awesome.min.css")
        );
    }

    public static void AddDefaultIgnorePatterns(IgnoreList ignoreList) {
      if(ignoreList == null) {
        throw new ArgumentNullException("ignoreList");
      }

      ignoreList.Ignore("*.intellisense.js");
      ignoreList.Ignore("*-vsdoc.js");
      ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
      //ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
      //ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
    }
  }
}