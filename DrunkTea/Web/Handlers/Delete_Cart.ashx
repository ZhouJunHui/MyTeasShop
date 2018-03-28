<%@ WebHandler Language="C#" Class="Delete_Cart" %>

using System;
using System.Web;
using BLL;
using Model;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
public class Delete_Cart : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string Uid = context.Request.Params["Uid"];
        string Tid = context.Request.Params["Tid"];
        var Tids = Tid.Split(',');
        bool boo = true;
        for (int i = 0; i < Tids.Length; i++)
        {
            string Tid_Data = Tids[i];
            if (!new CartManager().Delete(Uid, Tid_Data))
                boo = false;
        }
        DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(bool));
        ds.WriteObject(context.Response.OutputStream, boo);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}