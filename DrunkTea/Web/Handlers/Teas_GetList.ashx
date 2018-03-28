<%@ WebHandler Language="C#" Class="Teas_GetList" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class Teas_GetList : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        List<Teas> lst = new TeasManager().GetList();
        DataContractJsonSerializer dt = new DataContractJsonSerializer(typeof(List<Teas>));
        dt.WriteObject(context.Response.OutputStream, lst);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}