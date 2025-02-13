﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Downloadv2 : System.Web.UI.Page
{
    public string PhoneList;
    public bool IsDownload = false;
    public string Disabled = "disabled='disabled'";
    public string DownloadList = "";
    public string QRImageURL = "";
    public string MobileDownloadPage;
    public MobilePhone SelectedMobilephone;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SetManu(object sender, EventArgs e)
    {
        MobilePhone SelectedMobilephone = new MobilePhone();

        drpModel.Enabled = true;

        List<MobilePhone> Filtered = SelectedMobilephone.FilterManufacturer(drpManu.SelectedValue);

        drpModel.Items.Clear();
        drpModel.Items.Add(new ListItem("select"));

        for (int i = 0; i < Filtered.Count; i++)
        {
            drpModel.Items.Add(new ListItem(Filtered[i].Model,Filtered[i].ID.ToString()));
        }

        if (drpManu.Items[0].Text == "select")
        {
            drpManu.Items.RemoveAt(0);
        }
    }

    protected void SetModel(object sender, EventArgs e)
    {
        if (drpModel.Items[0].Text == "select")
        {
            drpModel.Items.RemoveAt(0);
        }

        IsDownload = true;

        // get the model
        SelectedMobilephone = MobilePhone.GetMobilePhoneByID(Int32.Parse(drpModel.SelectedValue));
        // determine the OS runtime
        //

        if (SelectedMobilephone.Runtime==RunTimeOS.Symbian)
        {
            MobileDownloadPage = "http://www.getn2f.com/2";

            DownloadList = @"<span class='downloadlink'>Download Live <a style='font-size:smaller' href='http://www.getn2f.com/3'>.Sisx </a><small>Live v1.0 (455k)</small></span><br />";
            QRImageURL = "/images/qr2.gif";
        }
        else if (SelectedMobilephone.Runtime == RunTimeOS.J2ME)
        {
            MobileDownloadPage = "http://www.getn2f.com/1";

            DownloadList = @"<span class='downloadlink' style='color:#cccccc;background: url(images/link-arrow-grey.gif) left 3px no-repeat'>Download Live <small>Currently unsupported</small></span><br />";
            
            QRImageURL = "/images/qr1.gif";
        }

        DownloadList += @"<span class='downloadlink'>Download Ask <a style='font-size:smaller' href='http://www.getn2f.com/4'>.Jar </a> | <a style='font-size:smaller' href='http://www.getn2f.com/5'>.Jad </a><small>Ask v1.0 (245k)</small></span><br />
                             <span class='downloadlink'>Download Tag <a style='font-size:smaller' href='http://www.getn2f.com/6'>.Jar </a> | <a style='font-size:smaller' href='http://www.getn2f.com/7'>.Jad </a><small>Tag v1.0  (125k)</small></span><br />
                             <span class='downloadlink'>Download Snapup <a style='font-size:smaller' href='http://www.getn2f.com/8'>.Jar </a> | <a style='font-size:smaller' href='http://www.getn2f.com/9'>.Jad </a><small>Snapup v1.0  (100k)</small></span><br />";


    }

    /// <summary>
    /// set the page skin
    /// </summary>
    /// <param name="e"></param>
    protected override void OnPreInit(EventArgs e)
    {
        Master.SkinID = "domore";
        base.OnPreInit(e);
    }
}
