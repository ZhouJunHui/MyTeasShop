<%@ WebHandler Language="C#" Class="Teas_GetListByTName" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class Teas_GetListByTName : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string Tname = context.Request.Params["Tname"];
        List<Teas> lst = new TeasManager().Teas_GetListByTName(Tname);
        DataContractJsonSerializer dt = new DataContractJsonSerializer(typeof(List<Teas>));
        dt.WriteObject(context.Response.OutputStream, lst);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}