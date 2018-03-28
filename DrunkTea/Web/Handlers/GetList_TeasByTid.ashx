<%@ WebHandler Language="C#" Class="GetList_TeasByTid" %>

using System;
using System.Web;
using BLL;
using Model;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class GetList_TeasByTid : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string Tid = context.Request.Params["Tid"];
        string Number = context.Request.Params["Number"];
        Teas lst = new TeasManager().GetList_TeasByTid(Tid);
        lst.Number =Convert.ToInt32(Number);
        DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(Teas));
        ds.WriteObject(context.Response.OutputStream, lst);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}